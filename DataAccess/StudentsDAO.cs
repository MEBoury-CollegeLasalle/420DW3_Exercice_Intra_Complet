using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.DataAccess;
public class StudentsDAO {
    private static readonly string TABLE_NAME = "Etudiants";
    private readonly SqlDataAdapter sqlDataAdapter;
    private readonly SqlConnection connection;

    // Texte des commandes en Transact-SQL
    private readonly string selectQuery = $"SELECT * FROM {TABLE_NAME};";
    private readonly string insertQuery = $"INSERT INTO {TABLE_NAME} (Nom, Prenom, NumEtudiant) VALUES (@nom, @prenom, @numEtudiant); SELECT * FROM {TABLE_NAME} WHERE Id = SCOPE_IDENTITY();";
    private readonly string updateQuery = $"UPDATE {TABLE_NAME} SET Nom = @nom, Prenom = @prenom, NumEtudiant = @numEtudiant, DateModification = @dateModif WHERE (Id = @id AND DateModification = @oldDateModif);";
    private readonly string deleteQuery = $"DELETE FROM {TABLE_NAME} WHERE Id = @id;";

    public StudentsDAO(SqlConnection connection) {
        this.connection = connection;
        this.sqlDataAdapter = this.CreateDataAdapter();
    }

    public void LoadData(DataSet dataSet) {
        if (dataSet.Tables.Contains(TABLE_NAME)) {
            dataSet.Tables[TABLE_NAME]?.Clear();
        }

        if (this.connection.State != ConnectionState.Open) {
            this.connection.Open();
        }
        _ = this.sqlDataAdapter.Fill(dataSet, TABLE_NAME);
        connection.Close();

        DataTable table = dataSet.Tables[TABLE_NAME] ?? throw new Exception($"Table [{TABLE_NAME}] inexistante dans le DataSet.");
        this.ConfigureDataTable(table);

    }

    public DataTable GetDataTable(DataSet dataSet) {
        this.LoadData(dataSet);
        DataTable table = dataSet.Tables[TABLE_NAME] ?? throw new Exception($"Table [{TABLE_NAME}] inexistante dans le DataSet.");
        return table;
    }

    public void SaveChanges(DataSet dataSet) {

        if (this.connection.State != ConnectionState.Open) {
            this.connection.Open();
        }
        _ = this.sqlDataAdapter.Update(dataSet, TABLE_NAME);
        connection.Close();
    }

    private void ConfigureDataTable(DataTable table) {

        DataColumn idColumn = table.Columns["Id"] ?? throw new Exception("Colonne [Id] inexistante dans la table.");
        idColumn.ReadOnly = true;
        idColumn.AllowDBNull = true;

        DataColumn nameColumn = table.Columns["Nom"] ?? throw new Exception("Colonne [Nom] inexistante dans la table.");
        nameColumn.MaxLength = 32;

        DataColumn firstNameColumn = table.Columns["Prenom"] ?? throw new Exception("Colonne [Prenom] inexistante dans la table.");
        firstNameColumn.MaxLength = 32;

        DataColumn dateCreatedColumn = table.Columns["DateCreation"] ?? throw new Exception("Colonne [DateCreation] inexistante dans la table.");
        dateCreatedColumn.ReadOnly = true;
        dateCreatedColumn.AllowDBNull = true;

        DataColumn dateModifiedColumn = table.Columns["DateModification"] ?? throw new Exception("Colonne [DateModification] inexistante dans la table.");
        dateModifiedColumn.AllowDBNull = true;

    }

    private SqlDataAdapter CreateDataAdapter() {
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        adapter.SelectCommand = new SqlCommand(this.selectQuery, this.connection);

        adapter.InsertCommand = new SqlCommand(this.insertQuery, this.connection);
        adapter.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
        _ = adapter.InsertCommand.Parameters.Add("@nom", SqlDbType.NVarChar, 32, "Nom");
        _ = adapter.InsertCommand.Parameters.Add("@prenom", SqlDbType.NVarChar, 32, "Prenom");
        _ = adapter.InsertCommand.Parameters.Add("@numEtudiant", SqlDbType.Int, 4, "NumEtudiant");

        adapter.UpdateCommand = new SqlCommand(this.updateQuery, this.connection);
        _ = adapter.UpdateCommand.Parameters.Add("@nom", SqlDbType.NVarChar, 32, "Nom");
        _ = adapter.UpdateCommand.Parameters.Add("@prenom", SqlDbType.NVarChar, 32, "Prenom");
        _ = adapter.UpdateCommand.Parameters.Add("@numEtudiant", SqlDbType.Int, 4, "NumEtudiant");
        _ = adapter.UpdateCommand.Parameters.Add("@dateModif", SqlDbType.DateTime, 6, "DateModification");
        _ = adapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "Id");
        adapter.UpdateCommand.Parameters.Add("@oldDateModif", SqlDbType.DateTime, 6, "DateModification").SourceVersion = DataRowVersion.Original;

        adapter.DeleteCommand = new SqlCommand(this.deleteQuery, this.connection);
        _ = adapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "Id");

        adapter.RowUpdating += this.OnRowUpdating;

        return adapter;

    }

    private void OnRowUpdating(object sender, SqlRowUpdatingEventArgs arguments) {
        if (arguments.StatementType == StatementType.Update) {
            arguments.Command.Parameters[3].Value = DateTime.Now;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.DataAccess;
public class CoursesDAO {
    private static readonly string TABLE_NAME = "Cours";
    private readonly SqlDataAdapter sqlDataAdapter;
    private readonly SqlConnection connection;

    // Texte des commandes en Transact-SQL
    private readonly string selectQuery = $"SELECT * FROM {TABLE_NAME};";
    private readonly string insertQuery = $"INSERT INTO {TABLE_NAME} (Code, Titre, Description) VALUES (@code, @titre, @description); SELECT * FROM {TABLE_NAME} WHERE Id = SCOPE_IDENTITY();";
    private readonly string updateQuery = $"UPDATE {TABLE_NAME} SET Code = @code, Titre = @titre, Description = @description, DateModification = @dateModif WHERE (Id = @id AND DateModification = @oldDateModif);";
    private readonly string deleteQuery = $"DELETE FROM {TABLE_NAME} WHERE Id = @id;";

    public CoursesDAO(SqlConnection connection) {
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
        this.sqlDataAdapter.Fill(dataSet, TABLE_NAME);
        connection.Close();

        DataTable table = dataSet.Tables[TABLE_NAME] ?? throw new Exception($"Table [{TABLE_NAME}] inexistante dans le DataSet.");
        this.ConfigureDataTable(table);

    }

    public DataTable GetDataTable(DataSet dataSet) {

    }

    public void SaveChanges(DataSet dataSet) {

        if (this.connection.State != ConnectionState.Open) {
            this.connection.Open();
        }
        this.sqlDataAdapter.Update(dataSet, TABLE_NAME);
        connection.Close();
    }

    private void ConfigureDataTable(DataTable table) {

        DataColumn idColumn = table.Columns["Id"] ?? throw new Exception("Colonne [Id] inexistante dans la table.");
        idColumn.ReadOnly = true;
        idColumn.AllowDBNull = true;

        DataColumn codeColumn = table.Columns["Code"] ?? throw new Exception("Colonne [Code] inexistante dans la table.");
        codeColumn.MaxLength = 12;

        DataColumn titleColumn = table.Columns["Titre"] ?? throw new Exception("Colonne [Titre] inexistante dans la table.");
        titleColumn.MaxLength = 128;

        DataColumn descColumn = table.Columns["Description"] ?? throw new Exception("Colonne [Description] inexistante dans la table.");
        descColumn.AllowDBNull = true;

        DataColumn dateCreatedColumn = table.Columns["DateCreation"] ?? throw new Exception("Colonne [DateCreation] inexistante dans la table.");
        dateCreatedColumn.ReadOnly = true;
        dateCreatedColumn.AllowDBNull = true;

        DataColumn dateModifiedColumn = table.Columns["DateModification"] ?? throw new Exception("Colonne [DateModification] inexistante dans la table.");
        dateModifiedColumn.ReadOnly = true;
        dateModifiedColumn.AllowDBNull = true;

    }

    private SqlDataAdapter CreateDataAdapter() {
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        adapter.SelectCommand = new SqlCommand(this.selectQuery, this.connection);

        adapter.InsertCommand = new SqlCommand(this.insertQuery, this.connection);
        adapter.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
        _ = adapter.InsertCommand.Parameters.Add("@code", SqlDbType.NVarChar, 12, "Code");
        _ = adapter.InsertCommand.Parameters.Add("@titre", SqlDbType.NVarChar, 128, "Titre");
        _ = adapter.InsertCommand.Parameters.Add("@description", SqlDbType.Text, -1, "Description");

        adapter.UpdateCommand = new SqlCommand(this.updateQuery, this.connection);
        _ = adapter.UpdateCommand.Parameters.Add("@code", SqlDbType.NVarChar, 12, "Code");
        _ = adapter.UpdateCommand.Parameters.Add("@titre", SqlDbType.NVarChar, 128, "Titre");
        _ = adapter.UpdateCommand.Parameters.Add("@description", SqlDbType.Text, -1, "Description");
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
            arguments.Row["DateModification"] = DateTime.Now;
        }
    }

}

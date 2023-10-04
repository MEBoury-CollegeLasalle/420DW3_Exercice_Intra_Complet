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

    }

    public DataTable GetDataTable(DataSet dataSet) {

    }

    public void SaveChanges(DataSet dataSet) { 

    }

    private void ConfigureDataTable(DataTable table) {

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

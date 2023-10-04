using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.DataAccess;
public class CoursesDAO {
    private readonly string tableName = "Cours";
    private readonly SqlDataAdapter sqlDataAdapter;
    private readonly SqlConnection connection;

    public CoursesDAO(SqlConnection connection) {
        this.connection = connection;
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

    }

    private void OnRowUpdating(object sender, SqlRowUpdatingEventArgs arguments) {

    }

}

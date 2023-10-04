using _420DW3_Exercice_Intra_Test.DataAccess;
using _420DW3_Exercice_Intra_Test.GUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.Business;
public class CoursesManager {
    private CoursesForm form;
    private CoursesDAO courseDAO;
    private DataSet dataSet;

    public CoursesManager(SqlConnection connection, DataSet dataSet) {
        this.dataSet = dataSet;
        this.form = new CoursesForm(this);
        this.courseDAO = new CoursesDAO(connection);
    }

    public void OpenCoursesWindow() {
        DialogResult result = this.form.ShowDialog();
    }
}

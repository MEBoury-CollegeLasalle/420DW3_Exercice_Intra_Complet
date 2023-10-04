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
    private CoursesDAO coursesDAO;
    private DataSet dataSet;

    public CoursesManager(SqlConnection connection, DataSet dataSet) {
        this.dataSet = dataSet;
        this.form = new CoursesForm(this);
        this.coursesDAO = new CoursesDAO(connection);
    }

    public void OpenCoursesWindow() {
        this.LoadCoursesData();
        DialogResult result = this.form.ShowDialog();
        if (result == DialogResult.OK) {
            this.coursesDAO.SaveChanges(this.dataSet);
        }
    }

    public void LoadCoursesData() {
        DataTable table = this.coursesDAO.GetDataTable(this.dataSet);
        this.form.BindDataTable(table);
    }
}

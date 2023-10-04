using _420DW3_Exercice_Intra_Test.DataAccess;
using _420DW3_Exercice_Intra_Test.GUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.Business;
public class CoursesManager {
    private CoursesForm form;
    private CoursesDAO courseDAO;

    public CoursesManager(SqlConnection connection) {
        this.form = new CoursesForm(this);
        this.courseDAO = new CoursesDAO(connection);
    }

    public void OpenCoursesWindow() {
        DialogResult result = this.form.ShowDialog();
    }
}

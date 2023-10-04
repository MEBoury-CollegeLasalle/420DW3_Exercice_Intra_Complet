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
public class StudentsManager {
    private readonly StudentsForm form;
    private readonly StudentsDAO studentsDAO;
    private readonly DataSet dataSet;

    public StudentsManager(SqlConnection connection, DataSet dataSet) {
        this.dataSet = dataSet;
        this.form = new StudentsForm(this);
        this.studentsDAO = new StudentsDAO(connection);
    }

    public void OpenStudentsWindow() {
        this.LoadStudentsData();
        DialogResult result = this.form.ShowDialog();
        if (result == DialogResult.OK) {
            this.studentsDAO.SaveChanges(this.dataSet);
        }
    }

    public void LoadStudentsData() {
        DataTable table = this.studentsDAO.GetDataTable(this.dataSet);
        this.form.BindDataTable(table);
    }
}

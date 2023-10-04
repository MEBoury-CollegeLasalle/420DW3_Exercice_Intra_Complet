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
public class ProgramManager {
    private readonly ProgramMainMenu menu;
    private readonly DataSet dataSet;
    private readonly SqlConnection connection;
    private readonly CoursesManager coursesManager;

    public ProgramManager() {

        ApplicationConfiguration.Initialize();

        this.menu = new ProgramMainMenu(this);
        this.dataSet = new DataSet();
        this.connection = ConnectionFactory.GetConnection();

        this.coursesManager = new CoursesManager(this.connection, this.dataSet);

    }

    public void OpenCoursesManagementWindow() {
        this.coursesManager.OpenCoursesWindow();
    }

    public void Start() {
        Application.Run(this.menu);
    }

    public void Terminate() {
        if (this.connection.State == ConnectionState.Open) {
            this.connection.Close();
        }
        Application.Exit();
    }

}

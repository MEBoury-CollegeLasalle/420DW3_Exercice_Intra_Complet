using _420DW3_Exercice_Intra_Test.Business;

namespace _420DW3_Exercice_Intra_Test.GUI;

public partial class ProgramMainMenu : Form {
    private ProgramManager manager;

    public ProgramMainMenu(ProgramManager manager) {
        this.manager = manager;
        this.InitializeComponent();
    }

    private void buttonQuit_Click(object sender, EventArgs e) {
        this.manager.Terminate();
    }

    private void ButtonManageCourses_Click(object sender, EventArgs e) {
        this.manager.OpenCoursesManagementWindow();
    }
}

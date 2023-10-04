using _420DW3_Exercice_Intra_Test.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.Business;
public class CoursesManager {
    private CoursesForm form;

    public CoursesManager() {
        this.form = new CoursesForm(this);
    }

    public void OpenCoursesWindow() {
        DialogResult result = this.form.ShowDialog();
    }
}

using _420DW3_Exercice_Intra_Test.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DW3_Exercice_Intra_Test.GUI;
public partial class CoursesForm : Form {
    private CoursesManager manager;

    public CoursesForm(CoursesManager manager) {
        this.manager = manager;
        this.InitializeComponent();
    }
}

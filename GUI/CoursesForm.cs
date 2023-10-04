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

    public void BindDataTable(DataTable table) {
        this.dataGridView1.DataSource = table;
        this.dataGridView1.Refresh();
    }

    private void buttonClose_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void buttonSave_Click(object sender, EventArgs e) {
        this.DialogResult= DialogResult.OK;
    }
}

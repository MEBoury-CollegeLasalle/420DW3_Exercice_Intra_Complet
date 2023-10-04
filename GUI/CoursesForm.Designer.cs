namespace _420DW3_Exercice_Intra_Test.GUI;

partial class CoursesForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        dataGridView1 = new DataGridView();
        buttonClose = new Button();
        buttonSave = new Button();
        buttonLoadData = new Button();
        ((System.ComponentModel.ISupportInitialize) dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(776, 380);
        dataGridView1.TabIndex = 0;
        // 
        // buttonClose
        // 
        buttonClose.Location = new Point(654, 398);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new Size(134, 40);
        buttonClose.TabIndex = 1;
        buttonClose.Text = "Fermer";
        buttonClose.UseVisualStyleBackColor = true;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(514, 398);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(134, 40);
        buttonSave.TabIndex = 2;
        buttonSave.Text = "Sauvegarder";
        buttonSave.UseVisualStyleBackColor = true;
        // 
        // buttonLoadData
        // 
        buttonLoadData.Location = new Point(358, 398);
        buttonLoadData.Name = "buttonLoadData";
        buttonLoadData.Size = new Size(150, 40);
        buttonLoadData.TabIndex = 3;
        buttonLoadData.Text = "Charger Données";
        buttonLoadData.UseVisualStyleBackColor = true;
        // 
        // CoursesForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(buttonLoadData);
        this.Controls.Add(buttonSave);
        this.Controls.Add(buttonClose);
        this.Controls.Add(dataGridView1);
        this.Name = "CoursesForm";
        this.Text = "CoursesForm";
        ((System.ComponentModel.ISupportInitialize) dataGridView1).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button buttonClose;
    private Button buttonSave;
    private Button buttonLoadData;
}
namespace _420DW3_Exercice_Intra_Test.GUI;

partial class StudentsForm {
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
        studentsGridView = new DataGridView();
        buttonQuit = new Button();
        buttonSave = new Button();
        buttonLoad = new Button();
        ((System.ComponentModel.ISupportInitialize) studentsGridView).BeginInit();
        this.SuspendLayout();
        // 
        // studentsGridView
        // 
        studentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        studentsGridView.Location = new Point(12, 12);
        studentsGridView.Name = "studentsGridView";
        studentsGridView.RowHeadersWidth = 51;
        studentsGridView.RowTemplate.Height = 29;
        studentsGridView.Size = new Size(776, 376);
        studentsGridView.TabIndex = 0;
        // 
        // buttonQuit
        // 
        buttonQuit.Location = new Point(664, 394);
        buttonQuit.Name = "buttonQuit";
        buttonQuit.Size = new Size(124, 44);
        buttonQuit.TabIndex = 1;
        buttonQuit.Text = "Fermer";
        buttonQuit.UseVisualStyleBackColor = true;
        buttonQuit.Click += this.ButtonQuit_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(534, 394);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(124, 44);
        buttonSave.TabIndex = 2;
        buttonSave.Text = "Sauvegarder";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += this.ButtonSave_Click;
        // 
        // buttonLoad
        // 
        buttonLoad.Location = new Point(370, 394);
        buttonLoad.Name = "buttonLoad";
        buttonLoad.Size = new Size(158, 44);
        buttonLoad.TabIndex = 3;
        buttonLoad.Text = "Charger Données";
        buttonLoad.UseVisualStyleBackColor = true;
        buttonLoad.Click += this.ButtonLoad_Click;
        // 
        // StudentsForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(buttonLoad);
        this.Controls.Add(buttonSave);
        this.Controls.Add(buttonQuit);
        this.Controls.Add(studentsGridView);
        this.Name = "StudentsForm";
        this.Text = "StudentsForm";
        ((System.ComponentModel.ISupportInitialize) studentsGridView).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private DataGridView studentsGridView;
    private Button buttonQuit;
    private Button buttonSave;
    private Button buttonLoad;
}
namespace _420DW3_Exercice_Intra_Test.GUI;

partial class ProgramMainMenu {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        buttonQuit = new Button();
        buttonManageCourses = new Button();
        this.SuspendLayout();
        // 
        // buttonQuit
        // 
        buttonQuit.Location = new Point(12, 315);
        buttonQuit.Name = "buttonQuit";
        buttonQuit.Size = new Size(358, 48);
        buttonQuit.TabIndex = 0;
        buttonQuit.Text = "Quitter";
        buttonQuit.UseVisualStyleBackColor = true;
        buttonQuit.Click += this.buttonQuit_Click;
        // 
        // buttonManageCourses
        // 
        buttonManageCourses.Location = new Point(12, 65);
        buttonManageCourses.Name = "buttonManageCourses";
        buttonManageCourses.Size = new Size(358, 48);
        buttonManageCourses.TabIndex = 1;
        buttonManageCourses.Text = "Gérer les cours";
        buttonManageCourses.UseVisualStyleBackColor = true;
        buttonManageCourses.Click += this.ButtonManageCourses_Click;
        // 
        // ProgramMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(382, 453);
        this.Controls.Add(buttonManageCourses);
        this.Controls.Add(buttonQuit);
        this.Name = "ProgramMainMenu";
        this.Text = "Menu Principal";
        this.ResumeLayout(false);
    }

    #endregion

    private Button buttonQuit;
    private Button buttonManageCourses;
}

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
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize) dataGridView1).BeginInit();
        panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(800, 398);
        dataGridView1.TabIndex = 0;
        // 
        // buttonClose
        // 
        buttonClose.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        buttonClose.Location = new Point(616, 3);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new Size(172, 40);
        buttonClose.TabIndex = 1;
        buttonClose.Text = "Fermer";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += this.ButtonClose_Click;
        // 
        // buttonSave
        // 
        buttonSave.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        buttonSave.Location = new Point(445, 3);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(165, 40);
        buttonSave.TabIndex = 2;
        buttonSave.Text = "Sauvegarder";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += this.ButtonSave_Click;
        // 
        // buttonLoadData
        // 
        buttonLoadData.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        buttonLoadData.Location = new Point(273, 3);
        buttonLoadData.Name = "buttonLoadData";
        buttonLoadData.Size = new Size(166, 40);
        buttonLoadData.TabIndex = 3;
        buttonLoadData.Text = "Charger Données";
        buttonLoadData.UseVisualStyleBackColor = true;
        buttonLoadData.Click += this.ButtonLoadData_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonLoadData);
        panel1.Controls.Add(buttonClose);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 398);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 52);
        panel1.TabIndex = 4;
        // 
        // CoursesForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(dataGridView1);
        this.Controls.Add(panel1);
        this.Name = "CoursesForm";
        this.Text = "CoursesForm";
        ((System.ComponentModel.ISupportInitialize) dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button buttonClose;
    private Button buttonSave;
    private Button buttonLoadData;
    private Panel panel1;
}
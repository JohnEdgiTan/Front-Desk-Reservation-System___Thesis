namespace WindowsFormsApplication1
{
    partial class backupdatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupdatabase));
            this.BackupButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browserfiletb = new System.Windows.Forms.TextBox();
            this.backupgb = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxDatabaseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.finenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.browserfiletbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboboxdatabasenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backupbuttonelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backupgbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backupgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.MintCream;
            this.BackupButton.FlatAppearance.BorderSize = 0;
            this.BackupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.BackupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.BackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupButton.Location = new System.Drawing.Point(317, 216);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(75, 23);
            this.BackupButton.TabIndex = 2;
            this.BackupButton.Text = "Backup";
            this.BackupButton.UseVisualStyleBackColor = false;
            this.BackupButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(315, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // browserfiletb
            // 
            this.browserfiletb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.browserfiletb.Location = new System.Drawing.Point(34, 119);
            this.browserfiletb.Multiline = true;
            this.browserfiletb.Name = "browserfiletb";
            this.browserfiletb.Size = new System.Drawing.Size(356, 20);
            this.browserfiletb.TabIndex = 2;
            // 
            // backupgb
            // 
            this.backupgb.BackColor = System.Drawing.Color.MediumAquamarine;
            this.backupgb.Controls.Add(this.label3);
            this.backupgb.Controls.Add(this.ComboBoxDatabaseName);
            this.backupgb.Controls.Add(this.label2);
            this.backupgb.Controls.Add(this.label1);
            this.backupgb.Controls.Add(this.filename);
            this.backupgb.Controls.Add(this.browserfiletb);
            this.backupgb.Controls.Add(this.BackupButton);
            this.backupgb.Controls.Add(this.button2);
            this.backupgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupgb.Location = new System.Drawing.Point(375, 76);
            this.backupgb.Name = "backupgb";
            this.backupgb.Size = new System.Drawing.Size(423, 269);
            this.backupgb.TabIndex = 3;
            this.backupgb.TabStop = false;
            this.backupgb.Text = "Browse Folder to place the Back Up Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Database";
            // 
            // ComboBoxDatabaseName
            // 
            this.ComboBoxDatabaseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDatabaseName.FormattingEnabled = true;
            this.ComboBoxDatabaseName.Location = new System.Drawing.Point(36, 189);
            this.ComboBoxDatabaseName.Name = "ComboBoxDatabaseName";
            this.ComboBoxDatabaseName.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxDatabaseName.TabIndex = 7;
            this.ComboBoxDatabaseName.Click += new System.EventHandler(this.ComboBoxDatabaseName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Back Up Database File Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filename
            // 
            this.filename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filename.Location = new System.Drawing.Point(34, 52);
            this.filename.Multiline = true;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(356, 20);
            this.filename.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // finenameelipse
            // 
            this.finenameelipse.ElipseRadius = 7;
            this.finenameelipse.TargetControl = this.filename;
            // 
            // browserfiletbelipse
            // 
            this.browserfiletbelipse.ElipseRadius = 7;
            this.browserfiletbelipse.TargetControl = this.browserfiletb;
            // 
            // comboboxdatabasenameelipse
            // 
            this.comboboxdatabasenameelipse.ElipseRadius = 7;
            this.comboboxdatabasenameelipse.TargetControl = this.ComboBoxDatabaseName;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 7;
            this.button2elipse.TargetControl = this.button2;
            // 
            // backupbuttonelipse
            // 
            this.backupbuttonelipse.ElipseRadius = 7;
            this.backupbuttonelipse.TargetControl = this.BackupButton;
            // 
            // backupgbelipse
            // 
            this.backupgbelipse.ElipseRadius = 30;
            this.backupgbelipse.TargetControl = this.backupgb;
            // 
            // backupdatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1253, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backupgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backupdatabase";
            this.Text = "backupdatabase";
            this.Load += new System.EventHandler(this.backupdatabase_Load);
            this.backupgb.ResumeLayout(false);
            this.backupgb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox browserfiletb;
        private System.Windows.Forms.GroupBox backupgb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.ComboBox ComboBoxDatabaseName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse finenameelipse;
        private Bunifu.Framework.UI.BunifuElipse browserfiletbelipse;
        private Bunifu.Framework.UI.BunifuElipse comboboxdatabasenameelipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse backupbuttonelipse;
        private Bunifu.Framework.UI.BunifuElipse backupgbelipse;
    }
}
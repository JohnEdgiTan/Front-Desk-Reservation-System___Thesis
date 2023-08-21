
namespace WindowsFormsApplication1
{
    partial class Restoredatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restoredatabase));
            this.button2 = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.restoregb = new System.Windows.Forms.GroupBox();
            this.ComboBoxDatabaseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backupbuttonelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboboxdatabaseelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.restoreelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.restoregb.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(302, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.MintCream;
            this.BackupButton.FlatAppearance.BorderSize = 0;
            this.BackupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.BackupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.BackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupButton.Location = new System.Drawing.Point(303, 135);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(75, 23);
            this.BackupButton.TabIndex = 2;
            this.BackupButton.Text = "Restore";
            this.BackupButton.UseVisualStyleBackColor = false;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // restoregb
            // 
            this.restoregb.BackColor = System.Drawing.Color.MediumAquamarine;
            this.restoregb.Controls.Add(this.ComboBoxDatabaseName);
            this.restoregb.Controls.Add(this.label2);
            this.restoregb.Controls.Add(this.label1);
            this.restoregb.Controls.Add(this.filename);
            this.restoregb.Controls.Add(this.button2);
            this.restoregb.Controls.Add(this.BackupButton);
            this.restoregb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoregb.Location = new System.Drawing.Point(458, 170);
            this.restoregb.Name = "restoregb";
            this.restoregb.Size = new System.Drawing.Size(396, 184);
            this.restoregb.TabIndex = 6;
            this.restoregb.TabStop = false;
            this.restoregb.Text = "Browse file to be Restored";
            // 
            // ComboBoxDatabaseName
            // 
            this.ComboBoxDatabaseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDatabaseName.FormattingEnabled = true;
            this.ComboBoxDatabaseName.Location = new System.Drawing.Point(22, 108);
            this.ComboBoxDatabaseName.Name = "ComboBoxDatabaseName";
            this.ComboBoxDatabaseName.Size = new System.Drawing.Size(356, 21);
            this.ComboBoxDatabaseName.TabIndex = 8;
            this.ComboBoxDatabaseName.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Back Up Database File Name and Location";
            // 
            // filename
            // 
            this.filename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filename.Location = new System.Drawing.Point(22, 44);
            this.filename.Multiline = true;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(356, 20);
            this.filename.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filenameelipse
            // 
            this.filenameelipse.ElipseRadius = 7;
            this.filenameelipse.TargetControl = this.filename;
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
            // comboboxdatabaseelipse
            // 
            this.comboboxdatabaseelipse.ElipseRadius = 7;
            this.comboboxdatabaseelipse.TargetControl = this.ComboBoxDatabaseName;
            // 
            // restoreelipse
            // 
            this.restoreelipse.ElipseRadius = 30;
            this.restoreelipse.TargetControl = this.restoregb;
            // 
            // Restoredatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1253, 485);
            this.Controls.Add(this.restoregb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Restoredatabase";
            this.Text = "Restoredatabase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Restoredatabase_Load);
            this.restoregb.ResumeLayout(false);
            this.restoregb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.GroupBox restoregb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox ComboBoxDatabaseName;
        private Bunifu.Framework.UI.BunifuElipse filenameelipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse backupbuttonelipse;
        private Bunifu.Framework.UI.BunifuElipse comboboxdatabaseelipse;
        private Bunifu.Framework.UI.BunifuElipse restoreelipse;
    }
}
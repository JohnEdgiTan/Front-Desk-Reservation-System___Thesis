namespace WindowsFormsApplication1
{
    partial class delete_services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_services));
            this.servicenametb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serviceslisttb = new System.Windows.Forms.DataGridView();
            this.servicenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.serviceselipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serviceslisttb)).BeginInit();
            this.SuspendLayout();
            // 
            // servicenametb
            // 
            this.servicenametb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicenametb.FormattingEnabled = true;
            this.servicenametb.Location = new System.Drawing.Point(117, 12);
            this.servicenametb.Name = "servicenametb";
            this.servicenametb.Size = new System.Drawing.Size(174, 21);
            this.servicenametb.TabIndex = 1;
            this.servicenametb.Click += new System.EventHandler(this.servicenametb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Service Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(297, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(378, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serviceslisttb
            // 
            this.serviceslisttb.AllowUserToAddRows = false;
            this.serviceslisttb.BackgroundColor = System.Drawing.SystemColors.Window;
            this.serviceslisttb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceslisttb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceslisttb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serviceslisttb.Location = new System.Drawing.Point(0, 47);
            this.serviceslisttb.Name = "serviceslisttb";
            this.serviceslisttb.RowHeadersVisible = false;
            this.serviceslisttb.Size = new System.Drawing.Size(492, 68);
            this.serviceslisttb.TabIndex = 4;
            // 
            // servicenameelipse
            // 
            this.servicenameelipse.ElipseRadius = 7;
            this.servicenameelipse.TargetControl = this.servicenametb;
            // 
            // buttonelipse
            // 
            this.buttonelipse.ElipseRadius = 7;
            this.buttonelipse.TargetControl = this.button1;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 7;
            this.button2elipse.TargetControl = this.button2;
            // 
            // serviceselipse
            // 
            this.serviceselipse.ElipseRadius = 7;
            this.serviceselipse.TargetControl = this.serviceslisttb;
            // 
            // delete_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(492, 115);
            this.Controls.Add(this.serviceslisttb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicenametb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_services";
            this.Text = "Delete Services";
            this.Load += new System.EventHandler(this.delete_services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceslisttb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox servicenametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView serviceslisttb;
        private Bunifu.Framework.UI.BunifuElipse servicenameelipse;
        private Bunifu.Framework.UI.BunifuElipse buttonelipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse serviceselipse;
    }
}
namespace WindowsFormsApplication1
{
    partial class update_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_staff));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.role2tb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email2tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone1tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name3tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone2tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.code3tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.departmenttb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.departmentelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phone1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.role2tbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.code3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.emailelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phone2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button7elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(258, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 94;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(177, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 93;
            this.button6.Text = "Confirm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // role2tb
            // 
            this.role2tb.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Employee"});
            this.role2tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.role2tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.role2tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role2tb.FormattingEnabled = true;
            this.role2tb.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.role2tb.Location = new System.Drawing.Point(83, 86);
            this.role2tb.Name = "role2tb";
            this.role2tb.Size = new System.Drawing.Size(125, 21);
            this.role2tb.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Role";
            // 
            // email2tb
            // 
            this.email2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email2tb.Location = new System.Drawing.Point(336, 33);
            this.email2tb.Multiline = true;
            this.email2tb.Name = "email2tb";
            this.email2tb.Size = new System.Drawing.Size(149, 20);
            this.email2tb.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Email";
            // 
            // phone1tb
            // 
            this.phone1tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone1tb.Location = new System.Drawing.Point(83, 60);
            this.phone1tb.Multiline = true;
            this.phone1tb.Name = "phone1tb";
            this.phone1tb.Size = new System.Drawing.Size(125, 20);
            this.phone1tb.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Phone1";
            // 
            // name3tb
            // 
            this.name3tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name3tb.Location = new System.Drawing.Point(83, 7);
            this.name3tb.Multiline = true;
            this.name3tb.Name = "name3tb";
            this.name3tb.Size = new System.Drawing.Size(125, 20);
            this.name3tb.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Name";
            // 
            // phone2tb
            // 
            this.phone2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone2tb.Location = new System.Drawing.Point(336, 59);
            this.phone2tb.Multiline = true;
            this.phone2tb.Name = "phone2tb";
            this.phone2tb.Size = new System.Drawing.Size(149, 20);
            this.phone2tb.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "Phone2";
            // 
            // code3tb
            // 
            this.code3tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code3tb.Location = new System.Drawing.Point(336, 7);
            this.code3tb.Multiline = true;
            this.code3tb.Name = "code3tb";
            this.code3tb.Size = new System.Drawing.Size(149, 20);
            this.code3tb.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(282, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "Staff ID";
            // 
            // departmenttb
            // 
            this.departmenttb.AutoCompleteCustomSource.AddRange(new string[] {
            "Front Desk ",
            "Laundry Department",
            "Management",
            "Accounting"});
            this.departmenttb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmenttb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmenttb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmenttb.FormattingEnabled = true;
            this.departmenttb.Items.AddRange(new object[] {
            "Front Desk ",
            "Laundry Department",
            "Management",
            "Accounting"});
            this.departmenttb.Location = new System.Drawing.Point(83, 33);
            this.departmenttb.Name = "departmenttb";
            this.departmenttb.Size = new System.Drawing.Size(125, 21);
            this.departmenttb.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Department";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(214, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 95;
            this.button1.Text = "Load Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nameelipse
            // 
            this.nameelipse.ElipseRadius = 7;
            this.nameelipse.TargetControl = this.name3tb;
            // 
            // departmentelipse
            // 
            this.departmentelipse.ElipseRadius = 7;
            this.departmentelipse.TargetControl = this.departmenttb;
            // 
            // phone1elipse
            // 
            this.phone1elipse.ElipseRadius = 7;
            this.phone1elipse.TargetControl = this.phone1tb;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 7;
            this.button1elipse.TargetControl = this.button1;
            // 
            // role2tbelipse
            // 
            this.role2tbelipse.ElipseRadius = 7;
            this.role2tbelipse.TargetControl = this.role2tb;
            // 
            // code3elipse
            // 
            this.code3elipse.ElipseRadius = 7;
            this.code3elipse.TargetControl = this.code3tb;
            // 
            // emailelipse
            // 
            this.emailelipse.ElipseRadius = 7;
            this.emailelipse.TargetControl = this.email2tb;
            // 
            // phone2elipse
            // 
            this.phone2elipse.ElipseRadius = 7;
            this.phone2elipse.TargetControl = this.phone2tb;
            // 
            // button6elipse
            // 
            this.button6elipse.ElipseRadius = 7;
            this.button6elipse.TargetControl = this.button6;
            // 
            // button7elipse
            // 
            this.button7elipse.ElipseRadius = 7;
            this.button7elipse.TargetControl = this.button7;
            // 
            // update_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(495, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.role2tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email2tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone1tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name3tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone2tb);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.code3tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.departmenttb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Staff";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.update_staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox role2tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email2tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone1tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name3tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone2tb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox code3tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox departmenttb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse nameelipse;
        private Bunifu.Framework.UI.BunifuElipse departmentelipse;
        private Bunifu.Framework.UI.BunifuElipse phone1elipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse role2tbelipse;
        private Bunifu.Framework.UI.BunifuElipse code3elipse;
        private Bunifu.Framework.UI.BunifuElipse emailelipse;
        private Bunifu.Framework.UI.BunifuElipse phone2elipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button7elipse;
    }
}
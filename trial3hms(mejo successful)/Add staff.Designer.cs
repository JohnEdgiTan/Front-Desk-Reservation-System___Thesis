namespace WindowsFormsApplication1
{
    partial class Add_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_staff));
            this.departmenttb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name3tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone2tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.code3tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email2tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone1tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.role2tb = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.usernamecopy = new System.Windows.Forms.TextBox();
            this.pbctb = new System.Windows.Forms.TextBox();
            this.pbc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userlevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.staffpasswords = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name3tbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.departmentelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phone1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.roleelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.code3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phone6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phonetb2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.emailtbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.usernamecopyelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffpasswordelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passclueelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userlevelelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button7elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmenttb
            // 
            this.departmenttb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmenttb.FormattingEnabled = true;
            this.departmenttb.Items.AddRange(new object[] {
            "Front Desk ",
            "Laundry Department",
            "Management",
            "Accounting"});
            this.departmenttb.Location = new System.Drawing.Point(85, 67);
            this.departmenttb.Name = "departmenttb";
            this.departmenttb.Size = new System.Drawing.Size(125, 21);
            this.departmenttb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Department";
            // 
            // name3tb
            // 
            this.name3tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name3tb.Location = new System.Drawing.Point(85, 23);
            this.name3tb.Multiline = true;
            this.name3tb.Name = "name3tb";
            this.name3tb.Size = new System.Drawing.Size(125, 20);
            this.name3tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name";
            // 
            // phone2tb
            // 
            this.phone2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone2tb.Location = new System.Drawing.Point(331, 109);
            this.phone2tb.Multiline = true;
            this.phone2tb.Name = "phone2tb";
            this.phone2tb.Size = new System.Drawing.Size(168, 20);
            this.phone2tb.TabIndex = 8;
            this.phone2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone2tb_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(273, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Phone2";
            // 
            // code3tb
            // 
            this.code3tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code3tb.Location = new System.Drawing.Point(331, 24);
            this.code3tb.Multiline = true;
            this.code3tb.Name = "code3tb";
            this.code3tb.Size = new System.Drawing.Size(168, 20);
            this.code3tb.TabIndex = 6;
            this.code3tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code3tb_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Role";
            // 
            // email2tb
            // 
            this.email2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email2tb.Location = new System.Drawing.Point(331, 67);
            this.email2tb.Multiline = true;
            this.email2tb.Name = "email2tb";
            this.email2tb.Size = new System.Drawing.Size(168, 20);
            this.email2tb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Email";
            // 
            // phone1tb
            // 
            this.phone1tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone1tb.Location = new System.Drawing.Point(85, 109);
            this.phone1tb.Multiline = true;
            this.phone1tb.Name = "phone1tb";
            this.phone1tb.Size = new System.Drawing.Size(125, 20);
            this.phone1tb.TabIndex = 3;
            this.phone1tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone1tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Phone1";
            // 
            // role2tb
            // 
            this.role2tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role2tb.FormattingEnabled = true;
            this.role2tb.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.role2tb.Location = new System.Drawing.Point(86, 152);
            this.role2tb.Name = "role2tb";
            this.role2tb.Size = new System.Drawing.Size(125, 21);
            this.role2tb.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(295, 327);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 30);
            this.button7.TabIndex = 12;
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
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(186, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "Confirm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Username";
            // 
            // usernamecopy
            // 
            this.usernamecopy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamecopy.Location = new System.Drawing.Point(84, 30);
            this.usernamecopy.Multiline = true;
            this.usernamecopy.Name = "usernamecopy";
            this.usernamecopy.Size = new System.Drawing.Size(125, 20);
            this.usernamecopy.TabIndex = 9;
            // 
            // pbctb
            // 
            this.pbctb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbctb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pbctb.Location = new System.Drawing.Point(328, 29);
            this.pbctb.Multiline = true;
            this.pbctb.Name = "pbctb";
            this.pbctb.Size = new System.Drawing.Size(168, 21);
            this.pbctb.TabIndex = 76;
            this.pbctb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbc
            // 
            this.pbc.AutoSize = true;
            this.pbc.Location = new System.Drawing.Point(239, 33);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(77, 13);
            this.pbc.TabIndex = 77;
            this.pbc.Text = "Password Clue";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departmenttb);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.code3tb);
            this.groupBox1.Controls.Add(this.role2tb);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phone2tb);
            this.groupBox1.Controls.Add(this.email2tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name3tb);
            this.groupBox1.Controls.Add(this.phone1tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 190);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.userlevel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.staffpasswords);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pbctb);
            this.groupBox2.Controls.Add(this.pbc);
            this.groupBox2.Controls.Add(this.usernamecopy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 110);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            // 
            // userlevel
            // 
            this.userlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlevel.FormattingEnabled = true;
            this.userlevel.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Super Admin"});
            this.userlevel.Location = new System.Drawing.Point(328, 72);
            this.userlevel.Name = "userlevel";
            this.userlevel.Size = new System.Drawing.Size(168, 21);
            this.userlevel.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "User level";
            // 
            // staffpasswords
            // 
            this.staffpasswords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffpasswords.Location = new System.Drawing.Point(84, 73);
            this.staffpasswords.Multiline = true;
            this.staffpasswords.Name = "staffpasswords";
            this.staffpasswords.PasswordChar = '*';
            this.staffpasswords.Size = new System.Drawing.Size(125, 20);
            this.staffpasswords.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Password";
            // 
            // name3tbelipse
            // 
            this.name3tbelipse.ElipseRadius = 7;
            this.name3tbelipse.TargetControl = this.name3tb;
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
            // roleelipse
            // 
            this.roleelipse.ElipseRadius = 7;
            this.roleelipse.TargetControl = this.role2tb;
            // 
            // code3elipse
            // 
            this.code3elipse.ElipseRadius = 7;
            this.code3elipse.TargetControl = this.code3tb;
            // 
            // phone6elipse
            // 
            this.phone6elipse.ElipseRadius = 7;
            this.phone6elipse.TargetControl = this.phone1tb;
            // 
            // phonetb2elipse
            // 
            this.phonetb2elipse.ElipseRadius = 7;
            this.phonetb2elipse.TargetControl = this.phone2tb;
            // 
            // emailtbelipse
            // 
            this.emailtbelipse.ElipseRadius = 7;
            this.emailtbelipse.TargetControl = this.email2tb;
            // 
            // usernamecopyelipse
            // 
            this.usernamecopyelipse.ElipseRadius = 7;
            this.usernamecopyelipse.TargetControl = this.usernamecopy;
            // 
            // staffpasswordelipse
            // 
            this.staffpasswordelipse.ElipseRadius = 7;
            this.staffpasswordelipse.TargetControl = this.staffpasswords;
            // 
            // passclueelipse
            // 
            this.passclueelipse.ElipseRadius = 7;
            this.passclueelipse.TargetControl = this.pbctb;
            // 
            // userlevelelipse
            // 
            this.userlevelelipse.ElipseRadius = 7;
            this.userlevelelipse.TargetControl = this.userlevel;
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
            // Add_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_staff";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Add_staff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox departmenttb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name3tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone2tb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox code3tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email2tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone1tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox role2tb;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernamecopy;
        private System.Windows.Forms.TextBox pbctb;
        private System.Windows.Forms.Label pbc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox staffpasswords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userlevel;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse name3tbelipse;
        private Bunifu.Framework.UI.BunifuElipse departmentelipse;
        private Bunifu.Framework.UI.BunifuElipse phone1elipse;
        private Bunifu.Framework.UI.BunifuElipse roleelipse;
        private Bunifu.Framework.UI.BunifuElipse code3elipse;
        private Bunifu.Framework.UI.BunifuElipse phone6elipse;
        private Bunifu.Framework.UI.BunifuElipse phonetb2elipse;
        private Bunifu.Framework.UI.BunifuElipse emailtbelipse;
        private Bunifu.Framework.UI.BunifuElipse usernamecopyelipse;
        private Bunifu.Framework.UI.BunifuElipse staffpasswordelipse;
        private Bunifu.Framework.UI.BunifuElipse passclueelipse;
        private Bunifu.Framework.UI.BunifuElipse userlevelelipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button7elipse;
    }
}
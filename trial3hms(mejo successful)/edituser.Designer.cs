
namespace WindowsFormsApplication1
{
    partial class edituser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edituser));
            this.userleveledit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordedit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passclueedit = new System.Windows.Forms.TextBox();
            this.pbc = new System.Windows.Forms.Label();
            this.usernamedit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newpasswordedit = new System.Windows.Forms.TextBox();
            this.confirmpasswordedit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffnameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.usernameelispse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passwordeditelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.newpasswordeditelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.confirmpasselipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passclueelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userlevelelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.restriction = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userleveledit
            // 
            this.userleveledit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userleveledit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userleveledit.FormattingEnabled = true;
            this.userleveledit.Items.AddRange(new object[] {
            "Super Admin",
            "Admin",
            "User"});
            this.userleveledit.Location = new System.Drawing.Point(79, 138);
            this.userleveledit.Name = "userleveledit";
            this.userleveledit.Size = new System.Drawing.Size(125, 21);
            this.userleveledit.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "User level";
            // 
            // passwordedit
            // 
            this.passwordedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordedit.Location = new System.Drawing.Point(344, 24);
            this.passwordedit.Multiline = true;
            this.passwordedit.Name = "passwordedit";
            this.passwordedit.PasswordChar = '*';
            this.passwordedit.Size = new System.Drawing.Size(125, 20);
            this.passwordedit.TabIndex = 78;
            this.passwordedit.TextChanged += new System.EventHandler(this.passwordedit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Password";
            // 
            // passclueedit
            // 
            this.passclueedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passclueedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passclueedit.Location = new System.Drawing.Point(347, 194);
            this.passclueedit.Multiline = true;
            this.passclueedit.Name = "passclueedit";
            this.passclueedit.Size = new System.Drawing.Size(125, 21);
            this.passclueedit.TabIndex = 76;
            // 
            // pbc
            // 
            this.pbc.AutoSize = true;
            this.pbc.Location = new System.Drawing.Point(259, 199);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(77, 13);
            this.pbc.TabIndex = 77;
            this.pbc.Text = "Password Clue";
            // 
            // usernamedit
            // 
            this.usernamedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamedit.Location = new System.Drawing.Point(80, 100);
            this.usernamedit.Multiline = true;
            this.usernamedit.Name = "usernamedit";
            this.usernamedit.Size = new System.Drawing.Size(125, 20);
            this.usernamedit.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Enter Staff Name for which user you want to edit";
            // 
            // staffname
            // 
            this.staffname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffname.Location = new System.Drawing.Point(80, 24);
            this.staffname.Multiline = true;
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(125, 20);
            this.staffname.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Staff Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(130, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Load Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(15, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(394, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 85;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newpasswordedit
            // 
            this.newpasswordedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpasswordedit.Enabled = false;
            this.newpasswordedit.Location = new System.Drawing.Point(347, 96);
            this.newpasswordedit.Multiline = true;
            this.newpasswordedit.Name = "newpasswordedit";
            this.newpasswordedit.PasswordChar = '*';
            this.newpasswordedit.Size = new System.Drawing.Size(125, 20);
            this.newpasswordedit.TabIndex = 86;
            // 
            // confirmpasswordedit
            // 
            this.confirmpasswordedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpasswordedit.Enabled = false;
            this.confirmpasswordedit.Location = new System.Drawing.Point(347, 145);
            this.confirmpasswordedit.Multiline = true;
            this.confirmpasswordedit.Name = "confirmpasswordedit";
            this.confirmpasswordedit.PasswordChar = '*';
            this.confirmpasswordedit.Size = new System.Drawing.Size(125, 20);
            this.confirmpasswordedit.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Confirm New Password";
            // 
            // staffnameelipse
            // 
            this.staffnameelipse.ElipseRadius = 5;
            this.staffnameelipse.TargetControl = this.staffname;
            // 
            // usernameelispse
            // 
            this.usernameelispse.ElipseRadius = 5;
            this.usernameelispse.TargetControl = this.usernamedit;
            // 
            // passwordeditelipse
            // 
            this.passwordeditelipse.ElipseRadius = 5;
            this.passwordeditelipse.TargetControl = this.passwordedit;
            // 
            // newpasswordeditelipse
            // 
            this.newpasswordeditelipse.ElipseRadius = 5;
            this.newpasswordeditelipse.TargetControl = this.newpasswordedit;
            // 
            // confirmpasselipse
            // 
            this.confirmpasselipse.ElipseRadius = 5;
            this.confirmpasselipse.TargetControl = this.confirmpasswordedit;
            // 
            // passclueelipse
            // 
            this.passclueelipse.ElipseRadius = 5;
            this.passclueelipse.TargetControl = this.passclueedit;
            // 
            // userlevelelipse
            // 
            this.userlevelelipse.ElipseRadius = 5;
            this.userlevelelipse.TargetControl = this.userleveledit;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 5;
            this.button1elipse.TargetControl = this.button1;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 5;
            this.button2elipse.TargetControl = this.button2;
            // 
            // button3elipse
            // 
            this.button3elipse.ElipseRadius = 5;
            this.button3elipse.TargetControl = this.button3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(359, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 91;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox2.Location = new System.Drawing.Point(357, 122);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 92;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // restriction
            // 
            this.restriction.AutoSize = true;
            this.restriction.ForeColor = System.Drawing.Color.Red;
            this.restriction.Location = new System.Drawing.Point(291, 47);
            this.restriction.Name = "restriction";
            this.restriction.Size = new System.Drawing.Size(181, 13);
            this.restriction.TabIndex = 93;
            this.restriction.Text = "Not Allowed To Auto Load Password";
            this.restriction.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(351, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 94;
            this.button4.Text = "Check Password";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.restriction);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmpasswordedit);
            this.Controls.Add(this.newpasswordedit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffname);
            this.Controls.Add(this.userleveledit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordedit);
            this.Controls.Add(this.usernamedit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbc);
            this.Controls.Add(this.passclueedit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edituser";
            this.Text = "Edit User Info";
            this.Load += new System.EventHandler(this.edituser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userleveledit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passwordedit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passclueedit;
        private System.Windows.Forms.Label pbc;
        private System.Windows.Forms.TextBox usernamedit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox newpasswordedit;
        private System.Windows.Forms.TextBox confirmpasswordedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse staffnameelipse;
        private Bunifu.Framework.UI.BunifuElipse usernameelispse;
        private Bunifu.Framework.UI.BunifuElipse passwordeditelipse;
        private Bunifu.Framework.UI.BunifuElipse newpasswordeditelipse;
        private Bunifu.Framework.UI.BunifuElipse confirmpasselipse;
        private Bunifu.Framework.UI.BunifuElipse passclueelipse;
        private Bunifu.Framework.UI.BunifuElipse userlevelelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse button3elipse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label restriction;
        private System.Windows.Forms.Button button4;
    }
}
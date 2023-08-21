namespace WindowsFormsApplication1
{
    partial class update_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_payment));
            this.button2 = new System.Windows.Forms.Button();
            this.notestb = new System.Windows.Forms.TextBox();
            this.paymenttimetb = new System.Windows.Forms.DateTimePicker();
            this.paymentdatetb = new System.Windows.Forms.DateTimePicker();
            this.paymenttotaltb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymenttypetb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentguestnametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refnotb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.refnotbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paymenttotaltbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.notestbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paymenttypetbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paymentguestnameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(206, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notestb
            // 
            this.notestb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notestb.Location = new System.Drawing.Point(83, 93);
            this.notestb.Multiline = true;
            this.notestb.Name = "notestb";
            this.notestb.Size = new System.Drawing.Size(191, 56);
            this.notestb.TabIndex = 65;
            this.notestb.Text = "N/A";
            // 
            // paymenttimetb
            // 
            this.paymenttimetb.CustomFormat = "yyyy/MM/dd";
            this.paymenttimetb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.paymenttimetb.Location = new System.Drawing.Point(181, 41);
            this.paymenttimetb.Name = "paymenttimetb";
            this.paymenttimetb.ShowUpDown = true;
            this.paymenttimetb.Size = new System.Drawing.Size(93, 20);
            this.paymenttimetb.TabIndex = 63;
            // 
            // paymentdatetb
            // 
            this.paymentdatetb.CustomFormat = "yyyy/MM/dd";
            this.paymentdatetb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paymentdatetb.Location = new System.Drawing.Point(83, 41);
            this.paymentdatetb.Name = "paymentdatetb";
            this.paymentdatetb.Size = new System.Drawing.Size(92, 20);
            this.paymentdatetb.TabIndex = 5;
            // 
            // paymenttotaltb
            // 
            this.paymenttotaltb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymenttotaltb.Location = new System.Drawing.Point(83, 67);
            this.paymenttotaltb.Multiline = true;
            this.paymenttotaltb.Name = "paymenttotaltb";
            this.paymenttotaltb.Size = new System.Drawing.Size(191, 20);
            this.paymenttotaltb.TabIndex = 4;
            this.paymenttotaltb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymenttotaltb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ref #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Guest Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Payment Type";
            // 
            // paymenttypetb
            // 
            this.paymenttypetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymenttypetb.FormattingEnabled = true;
            this.paymenttypetb.Items.AddRange(new object[] {
            "Cash",
            "Gcash"});
            this.paymenttypetb.Location = new System.Drawing.Point(83, 19);
            this.paymenttypetb.Name = "paymenttypetb";
            this.paymenttypetb.Size = new System.Drawing.Size(191, 21);
            this.paymenttypetb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentguestnametb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.paymenttypetb);
            this.groupBox2.Location = new System.Drawing.Point(7, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Type";
            // 
            // paymentguestnametb
            // 
            this.paymentguestnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentguestnametb.Location = new System.Drawing.Point(83, 50);
            this.paymentguestnametb.Multiline = true;
            this.paymentguestnametb.Name = "paymentguestnametb";
            this.paymentguestnametb.Size = new System.Drawing.Size(191, 20);
            this.paymentguestnametb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(90, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refnotb);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.notestb);
            this.groupBox1.Controls.Add(this.paymenttimetb);
            this.groupBox1.Controls.Add(this.paymentdatetb);
            this.groupBox1.Controls.Add(this.paymenttotaltb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // refnotb
            // 
            this.refnotb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refnotb.FormattingEnabled = true;
            this.refnotb.Location = new System.Drawing.Point(83, 13);
            this.refnotb.Name = "refnotb";
            this.refnotb.Size = new System.Drawing.Size(191, 21);
            this.refnotb.TabIndex = 67;
            this.refnotb.Click += new System.EventHandler(this.refnotb_Click);
            this.refnotb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refnotb_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(281, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 34);
            this.button3.TabIndex = 66;
            this.button3.Text = "Load Info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refnotbelipse
            // 
            this.refnotbelipse.ElipseRadius = 7;
            this.refnotbelipse.TargetControl = this.refnotb;
            // 
            // paymenttotaltbelipse
            // 
            this.paymenttotaltbelipse.ElipseRadius = 7;
            this.paymenttotaltbelipse.TargetControl = this.paymenttotaltb;
            // 
            // notestbelipse
            // 
            this.notestbelipse.ElipseRadius = 7;
            this.notestbelipse.TargetControl = this.notestb;
            // 
            // paymenttypetbelipse
            // 
            this.paymenttypetbelipse.ElipseRadius = 7;
            this.paymenttypetbelipse.TargetControl = this.paymenttypetb;
            // 
            // paymentguestnameelipse
            // 
            this.paymentguestnameelipse.ElipseRadius = 7;
            this.paymentguestnameelipse.TargetControl = this.paymentguestnametb;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 7;
            this.button1elipse.TargetControl = this.button1;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 7;
            this.button2elipse.TargetControl = this.button2;
            // 
            // button3elipse
            // 
            this.button3elipse.ElipseRadius = 7;
            this.button3elipse.TargetControl = this.button3;
            // 
            // update_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(355, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_payment";
            this.Text = "Update Payment";
            this.Load += new System.EventHandler(this.update_payment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox notestb;
        private System.Windows.Forms.DateTimePicker paymenttimetb;
        private System.Windows.Forms.DateTimePicker paymentdatetb;
        private System.Windows.Forms.TextBox paymenttotaltb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox paymenttypetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox paymentguestnametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox refnotb;
        private Bunifu.Framework.UI.BunifuElipse refnotbelipse;
        private Bunifu.Framework.UI.BunifuElipse paymenttotaltbelipse;
        private Bunifu.Framework.UI.BunifuElipse notestbelipse;
        private Bunifu.Framework.UI.BunifuElipse paymenttypetbelipse;
        private Bunifu.Framework.UI.BunifuElipse paymentguestnameelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse button3elipse;
    }
}
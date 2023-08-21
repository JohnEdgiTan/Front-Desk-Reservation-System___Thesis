namespace WindowsFormsApplication1
{
    partial class Add_service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_service));
            this.label1 = new System.Windows.Forms.Label();
            this.code4tb = new System.Windows.Forms.TextBox();
            this.ratetb = new System.Windows.Forms.TextBox();
            this.typetb = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotaltb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guestname2tb = new System.Windows.Forms.TextBox();
            this.servicedatarecordedtb = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.servicenametb = new System.Windows.Forms.ComboBox();
            this.codeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.typeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.servicenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ratetbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.subtotalelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guestnameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button7elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantitytb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // code4tb
            // 
            this.code4tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code4tb.Location = new System.Drawing.Point(89, 34);
            this.code4tb.Multiline = true;
            this.code4tb.Name = "code4tb";
            this.code4tb.Size = new System.Drawing.Size(153, 20);
            this.code4tb.TabIndex = 2;
            this.code4tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code4tb_KeyPress);
            // 
            // ratetb
            // 
            this.ratetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratetb.Location = new System.Drawing.Point(89, 91);
            this.ratetb.Multiline = true;
            this.ratetb.Name = "ratetb";
            this.ratetb.Size = new System.Drawing.Size(153, 20);
            this.ratetb.TabIndex = 5;
            this.ratetb.TextChanged += new System.EventHandler(this.ratetb_TextChanged);
            this.ratetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratetb_KeyPress);
            // 
            // typetb
            // 
            this.typetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typetb.FormattingEnabled = true;
            this.typetb.Location = new System.Drawing.Point(89, 7);
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(153, 21);
            this.typetb.TabIndex = 3;
            this.typetb.SelectedValueChanged += new System.EventHandler(this.typetb_SelectedValueChanged);
            this.typetb.Click += new System.EventHandler(this.typetb_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(146, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
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
            this.button6.Location = new System.Drawing.Point(65, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Ok";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "SN_ID";
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(89, 118);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(153, 20);
            this.quantitytb.TabIndex = 6;
            this.quantitytb.ValueChanged += new System.EventHandler(this.quantitytb_ValueChanged);
            this.quantitytb.Click += new System.EventHandler(this.quantitytb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Subtotal";
            // 
            // subtotaltb
            // 
            this.subtotaltb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtotaltb.Location = new System.Drawing.Point(89, 145);
            this.subtotaltb.Multiline = true;
            this.subtotaltb.Name = "subtotaltb";
            this.subtotaltb.Size = new System.Drawing.Size(153, 20);
            this.subtotaltb.TabIndex = 7;
            this.subtotaltb.Text = "0";
            this.subtotaltb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subtotaltb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Guest Name";
            // 
            // guestname2tb
            // 
            this.guestname2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestname2tb.Location = new System.Drawing.Point(89, 171);
            this.guestname2tb.Multiline = true;
            this.guestname2tb.Name = "guestname2tb";
            this.guestname2tb.Size = new System.Drawing.Size(153, 20);
            this.guestname2tb.TabIndex = 8;
            // 
            // servicedatarecordedtb
            // 
            this.servicedatarecordedtb.CustomFormat = "yyyy/MM/dd";
            this.servicedatarecordedtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.servicedatarecordedtb.Location = new System.Drawing.Point(89, 198);
            this.servicedatarecordedtb.Name = "servicedatarecordedtb";
            this.servicedatarecordedtb.Size = new System.Drawing.Size(153, 20);
            this.servicedatarecordedtb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Date Recorded";
            // 
            // servicenametb
            // 
            this.servicenametb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicenametb.FormattingEnabled = true;
            this.servicenametb.Location = new System.Drawing.Point(89, 62);
            this.servicenametb.Name = "servicenametb";
            this.servicenametb.Size = new System.Drawing.Size(153, 21);
            this.servicenametb.TabIndex = 70;
            this.servicenametb.SelectedValueChanged += new System.EventHandler(this.servicenametb_SelectedValueChanged);
            this.servicenametb.Click += new System.EventHandler(this.servicenametb_Click);
            // 
            // codeelipse
            // 
            this.codeelipse.ElipseRadius = 7;
            this.codeelipse.TargetControl = this.code4tb;
            // 
            // typeelipse
            // 
            this.typeelipse.ElipseRadius = 7;
            this.typeelipse.TargetControl = this.typetb;
            // 
            // servicenameelipse
            // 
            this.servicenameelipse.ElipseRadius = 7;
            this.servicenameelipse.TargetControl = this.servicenametb;
            // 
            // ratetbelipse
            // 
            this.ratetbelipse.ElipseRadius = 7;
            this.ratetbelipse.TargetControl = this.ratetb;
            // 
            // subtotalelipse
            // 
            this.subtotalelipse.ElipseRadius = 7;
            this.subtotalelipse.TargetControl = this.subtotaltb;
            // 
            // guestnameelipse
            // 
            this.guestnameelipse.ElipseRadius = 7;
            this.guestnameelipse.TargetControl = this.guestname2tb;
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
            // Add_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(252, 261);
            this.Controls.Add(this.servicenametb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.servicedatarecordedtb);
            this.Controls.Add(this.guestname2tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotaltb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.ratetb);
            this.Controls.Add(this.code4tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.Add_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitytb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code4tb;
        private System.Windows.Forms.TextBox ratetb;
        private System.Windows.Forms.ComboBox typetb;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantitytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotaltb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox guestname2tb;
        private System.Windows.Forms.DateTimePicker servicedatarecordedtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox servicenametb;
        private Bunifu.Framework.UI.BunifuElipse codeelipse;
        private Bunifu.Framework.UI.BunifuElipse typeelipse;
        private Bunifu.Framework.UI.BunifuElipse servicenameelipse;
        private Bunifu.Framework.UI.BunifuElipse ratetbelipse;
        private Bunifu.Framework.UI.BunifuElipse subtotalelipse;
        private Bunifu.Framework.UI.BunifuElipse guestnameelipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button7elipse;
    }
}
namespace WindowsFormsApplication1
{
    partial class update_service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_service));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.typetb = new System.Windows.Forms.ComboBox();
            this.ratetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guestname2tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotaltb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.NumericUpDown();
            this.servicenametb = new System.Windows.Forms.ComboBox();
            this.code4tb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.codeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.typeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.servicenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ratetbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.subtotalelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guestnameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantitytb)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Service ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Rate";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(162, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 68;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(81, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 67;
            this.button6.Text = "Ok";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // typetb
            // 
            this.typetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typetb.FormattingEnabled = true;
            this.typetb.Location = new System.Drawing.Point(82, 38);
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(152, 21);
            this.typetb.TabIndex = 65;
            this.typetb.TextChanged += new System.EventHandler(this.typetb_TextChanged);
            this.typetb.Click += new System.EventHandler(this.typetb_Click);
            // 
            // ratetb
            // 
            this.ratetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratetb.Location = new System.Drawing.Point(82, 93);
            this.ratetb.Multiline = true;
            this.ratetb.Name = "ratetb";
            this.ratetb.Size = new System.Drawing.Size(152, 20);
            this.ratetb.TabIndex = 64;
            this.ratetb.TextChanged += new System.EventHandler(this.ratetb_TextChanged);
            this.ratetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratetb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 72;
            this.button1.Text = "Load Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guestname2tb
            // 
            this.guestname2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestname2tb.Location = new System.Drawing.Point(81, 175);
            this.guestname2tb.Multiline = true;
            this.guestname2tb.Name = "guestname2tb";
            this.guestname2tb.Size = new System.Drawing.Size(153, 20);
            this.guestname2tb.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Guest Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Subtotal";
            // 
            // subtotaltb
            // 
            this.subtotaltb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtotaltb.Location = new System.Drawing.Point(81, 148);
            this.subtotaltb.Multiline = true;
            this.subtotaltb.Name = "subtotaltb";
            this.subtotaltb.Size = new System.Drawing.Size(153, 20);
            this.subtotaltb.TabIndex = 73;
            this.subtotaltb.Text = "0";
            this.subtotaltb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subtotaltb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Quantity";
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(81, 121);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(153, 20);
            this.quantitytb.TabIndex = 77;
            this.quantitytb.Click += new System.EventHandler(this.quantitytb_Click);
            // 
            // servicenametb
            // 
            this.servicenametb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicenametb.FormattingEnabled = true;
            this.servicenametb.Location = new System.Drawing.Point(81, 65);
            this.servicenametb.Name = "servicenametb";
            this.servicenametb.Size = new System.Drawing.Size(153, 21);
            this.servicenametb.TabIndex = 79;
            this.servicenametb.TextUpdate += new System.EventHandler(this.servicenametb_TextUpdate);
            this.servicenametb.TextChanged += new System.EventHandler(this.servicenametb_TextChanged);
            this.servicenametb.Click += new System.EventHandler(this.servicenametb_Click);
            // 
            // code4tb
            // 
            this.code4tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.code4tb.FormattingEnabled = true;
            this.code4tb.Location = new System.Drawing.Point(81, 11);
            this.code4tb.Name = "code4tb";
            this.code4tb.Size = new System.Drawing.Size(153, 21);
            this.code4tb.TabIndex = 80;
            this.code4tb.Click += new System.EventHandler(this.code4tb_Click);
            this.code4tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code4tb_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(162, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(240, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 72;
            this.button3.Text = "Load Info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeelipse
            // 
            this.codeelipse.ElipseRadius = 7;
            this.codeelipse.TargetControl = this.code4tb;
            // 
            // button3elipse
            // 
            this.button3elipse.ElipseRadius = 7;
            this.button3elipse.TargetControl = this.button3;
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
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 7;
            this.button2elipse.TargetControl = this.button2;
            // 
            // update_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(311, 245);
            this.Controls.Add(this.code4tb);
            this.Controls.Add(this.servicenametb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.guestname2tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotaltb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.ratetb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Services";
            this.Load += new System.EventHandler(this.update_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitytb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox typetb;
        private System.Windows.Forms.TextBox ratetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox guestname2tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotaltb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantitytb;
        private System.Windows.Forms.ComboBox servicenametb;
        private System.Windows.Forms.ComboBox code4tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuElipse codeelipse;
        private Bunifu.Framework.UI.BunifuElipse button3elipse;
        private Bunifu.Framework.UI.BunifuElipse typeelipse;
        private Bunifu.Framework.UI.BunifuElipse servicenameelipse;
        private Bunifu.Framework.UI.BunifuElipse ratetbelipse;
        private Bunifu.Framework.UI.BunifuElipse subtotalelipse;
        private Bunifu.Framework.UI.BunifuElipse guestnameelipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
    }
}
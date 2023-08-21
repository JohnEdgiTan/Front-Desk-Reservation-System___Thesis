namespace WindowsFormsApplication1
{
    partial class update_roomtype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_roomtype));
            this.maxinfantnotb = new System.Windows.Forms.NumericUpDown();
            this.maxchildnotb = new System.Windows.Forms.NumericUpDown();
            this.maxadultnotb = new System.Windows.Forms.NumericUpDown();
            this.smokingallowedtb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.codetb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bedtypetb = new System.Windows.Forms.ComboBox();
            this.nameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button7elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.codetbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bedtypeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.smokingallowedelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maxinfantnotb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxchildnotb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxadultnotb)).BeginInit();
            this.SuspendLayout();
            // 
            // maxinfantnotb
            // 
            this.maxinfantnotb.Location = new System.Drawing.Point(86, 87);
            this.maxinfantnotb.Name = "maxinfantnotb";
            this.maxinfantnotb.Size = new System.Drawing.Size(125, 20);
            this.maxinfantnotb.TabIndex = 98;
            // 
            // maxchildnotb
            // 
            this.maxchildnotb.Location = new System.Drawing.Point(86, 59);
            this.maxchildnotb.Name = "maxchildnotb";
            this.maxchildnotb.Size = new System.Drawing.Size(125, 20);
            this.maxchildnotb.TabIndex = 97;
            // 
            // maxadultnotb
            // 
            this.maxadultnotb.Location = new System.Drawing.Point(86, 31);
            this.maxadultnotb.Name = "maxadultnotb";
            this.maxadultnotb.Size = new System.Drawing.Size(125, 20);
            this.maxadultnotb.TabIndex = 96;
            // 
            // smokingallowedtb
            // 
            this.smokingallowedtb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smokingallowedtb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smokingallowedtb.FormattingEnabled = true;
            this.smokingallowedtb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.smokingallowedtb.Location = new System.Drawing.Point(355, 58);
            this.smokingallowedtb.Name = "smokingallowedtb";
            this.smokingallowedtb.Size = new System.Drawing.Size(125, 21);
            this.smokingallowedtb.TabIndex = 94;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(262, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 93;
            this.label22.Text = "Smoking Allowed";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(296, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 91;
            this.label19.Text = "Bed Type";
            // 
            // codetb
            // 
            this.codetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codetb.Location = new System.Drawing.Point(355, 7);
            this.codetb.Multiline = true;
            this.codetb.Name = "codetb";
            this.codetb.Size = new System.Drawing.Size(125, 20);
            this.codetb.TabIndex = 90;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(273, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 89;
            this.label20.Text = "Room Type ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Max Infant No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 87;
            this.label17.Text = "Max Child No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 86;
            this.label16.Text = "Max Adult No";
            // 
            // nametb
            // 
            this.nametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametb.Location = new System.Drawing.Point(86, 6);
            this.nametb.Multiline = true;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(125, 20);
            this.nametb.TabIndex = 85;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 84;
            this.label15.Text = "Name";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(241, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 83;
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
            this.button6.Location = new System.Drawing.Point(160, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 82;
            this.button6.Text = "Ok";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(218, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 35);
            this.button1.TabIndex = 99;
            this.button1.Text = "Load Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bedtypetb
            // 
            this.bedtypetb.AutoCompleteCustomSource.AddRange(new string[] {
            "Single Bed",
            "Twin Bed",
            "Queen Bed",
            "Twin XL Bed",
            "King Bed",
            "Cal King Bed",
            "Day Bed",
            "Water Bed",
            "Bookcase Bed",
            "Murphy Bed",
            "Full-Poster Bed",
            "Low-Poster Bed",
            "Round Bed",
            "Divan Bed",
            "Traditional Canopy Bed",
            "Hanging Bed",
            "Lighted Bed",
            "Traditional Bed"});
            this.bedtypetb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bedtypetb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bedtypetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bedtypetb.FormattingEnabled = true;
            this.bedtypetb.Items.AddRange(new object[] {
            "Single Bed",
            "Twin Bed",
            "Queen Bed",
            "Twin XL Bed",
            "King Bed",
            "Cal King Bed",
            "Day Bed",
            "Water Bed",
            "Bookcase Bed",
            "Murphy Bed",
            "Full-Poster Bed",
            "Low-Poster Bed",
            "Round Bed",
            "Divan Bed",
            "Traditional Canopy Bed",
            "Hanging Bed",
            "Lighted Bed",
            "Traditional Bed"});
            this.bedtypetb.Location = new System.Drawing.Point(355, 31);
            this.bedtypetb.Name = "bedtypetb";
            this.bedtypetb.Size = new System.Drawing.Size(125, 21);
            this.bedtypetb.TabIndex = 100;
            // 
            // nameelipse
            // 
            this.nameelipse.ElipseRadius = 7;
            this.nameelipse.TargetControl = this.nametb;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 7;
            this.button1elipse.TargetControl = this.button1;
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
            // codetbelipse
            // 
            this.codetbelipse.ElipseRadius = 7;
            this.codetbelipse.TargetControl = this.codetb;
            // 
            // bedtypeelipse
            // 
            this.bedtypeelipse.ElipseRadius = 7;
            this.bedtypeelipse.TargetControl = this.bedtypetb;
            // 
            // smokingallowedelipse
            // 
            this.smokingallowedelipse.ElipseRadius = 7;
            this.smokingallowedelipse.TargetControl = this.smokingallowedtb;
            // 
            // update_roomtype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(492, 144);
            this.Controls.Add(this.bedtypetb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxinfantnotb);
            this.Controls.Add(this.maxchildnotb);
            this.Controls.Add(this.maxadultnotb);
            this.Controls.Add(this.smokingallowedtb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.codetb);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_roomtype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Room Type";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.update_roomtype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxinfantnotb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxchildnotb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxadultnotb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown maxinfantnotb;
        private System.Windows.Forms.NumericUpDown maxchildnotb;
        private System.Windows.Forms.NumericUpDown maxadultnotb;
        private System.Windows.Forms.ComboBox smokingallowedtb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox codetb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bedtypetb;
        private Bunifu.Framework.UI.BunifuElipse nameelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button7elipse;
        private Bunifu.Framework.UI.BunifuElipse codetbelipse;
        private Bunifu.Framework.UI.BunifuElipse bedtypeelipse;
        private Bunifu.Framework.UI.BunifuElipse smokingallowedelipse;
    }
}
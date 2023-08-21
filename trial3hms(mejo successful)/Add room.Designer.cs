namespace WindowsFormsApplication1
{
    partial class Add_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_room));
            this.smokingallowed2tb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.code2tb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.name2tb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.roomtype2tb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomno2tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bedtype2tb = new System.Windows.Forms.ComboBox();
            this.maxadultno2tb = new System.Windows.Forms.NumericUpDown();
            this.maxchildno2tb = new System.Windows.Forms.NumericUpDown();
            this.maxinfantno2tb = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.roomno2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.nametbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button7elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.code2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.roomtypeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bedtypeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.smokingnotallowedelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maxadultno2tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxchildno2tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxinfantno2tb)).BeginInit();
            this.SuspendLayout();
            // 
            // smokingallowed2tb
            // 
            this.smokingallowed2tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smokingallowed2tb.FormattingEnabled = true;
            this.smokingallowed2tb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.smokingallowed2tb.Location = new System.Drawing.Point(321, 86);
            this.smokingallowed2tb.Name = "smokingallowed2tb";
            this.smokingallowed2tb.Size = new System.Drawing.Size(125, 21);
            this.smokingallowed2tb.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(229, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 68;
            this.label22.Text = "Smoking Allowed";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(254, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 66;
            this.label19.Text = "Bed Type";
            // 
            // code2tb
            // 
            this.code2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code2tb.Location = new System.Drawing.Point(321, 7);
            this.code2tb.Multiline = true;
            this.code2tb.Name = "code2tb";
            this.code2tb.Size = new System.Drawing.Size(125, 20);
            this.code2tb.TabIndex = 7;
            this.code2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code2tb_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(268, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "Room ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Max Infant No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Max Child No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Max Adult No";
            // 
            // name2tb
            // 
            this.name2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name2tb.Location = new System.Drawing.Point(78, 6);
            this.name2tb.Multiline = true;
            this.name2tb.Name = "name2tb";
            this.name2tb.Size = new System.Drawing.Size(125, 20);
            this.name2tb.TabIndex = 1;
            this.name2tb.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Name";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(234, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
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
            this.button6.Location = new System.Drawing.Point(153, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Confirm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // roomtype2tb
            // 
            this.roomtype2tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomtype2tb.FormattingEnabled = true;
            this.roomtype2tb.Location = new System.Drawing.Point(78, 32);
            this.roomtype2tb.Name = "roomtype2tb";
            this.roomtype2tb.Size = new System.Drawing.Size(125, 21);
            this.roomtype2tb.TabIndex = 2;
            this.roomtype2tb.SelectedValueChanged += new System.EventHandler(this.roomtype2tb_SelectedValueChanged);
            this.roomtype2tb.Click += new System.EventHandler(this.roomtype2tb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Room Type";
            // 
            // roomno2tb
            // 
            this.roomno2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomno2tb.Location = new System.Drawing.Point(321, 33);
            this.roomno2tb.Multiline = true;
            this.roomno2tb.Name = "roomno2tb";
            this.roomno2tb.Size = new System.Drawing.Size(125, 20);
            this.roomno2tb.TabIndex = 8;
            this.roomno2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomno2tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Room No";
            // 
            // bedtype2tb
            // 
            this.bedtype2tb.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.bedtype2tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bedtype2tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bedtype2tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bedtype2tb.FormattingEnabled = true;
            this.bedtype2tb.Items.AddRange(new object[] {
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
            this.bedtype2tb.Location = new System.Drawing.Point(321, 59);
            this.bedtype2tb.Name = "bedtype2tb";
            this.bedtype2tb.Size = new System.Drawing.Size(125, 21);
            this.bedtype2tb.TabIndex = 9;
            this.bedtype2tb.Click += new System.EventHandler(this.bedtype2tb_Click);
            // 
            // maxadultno2tb
            // 
            this.maxadultno2tb.Location = new System.Drawing.Point(78, 62);
            this.maxadultno2tb.Name = "maxadultno2tb";
            this.maxadultno2tb.Size = new System.Drawing.Size(125, 20);
            this.maxadultno2tb.TabIndex = 4;
            // 
            // maxchildno2tb
            // 
            this.maxchildno2tb.Location = new System.Drawing.Point(78, 90);
            this.maxchildno2tb.Name = "maxchildno2tb";
            this.maxchildno2tb.Size = new System.Drawing.Size(125, 20);
            this.maxchildno2tb.TabIndex = 5;
            // 
            // maxinfantno2tb
            // 
            this.maxinfantno2tb.Location = new System.Drawing.Point(78, 116);
            this.maxinfantno2tb.Name = "maxinfantno2tb";
            this.maxinfantno2tb.Size = new System.Drawing.Size(125, 20);
            this.maxinfantno2tb.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(209, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomno2elipse
            // 
            this.roomno2elipse.ElipseRadius = 7;
            this.roomno2elipse.TargetControl = this.roomno2tb;
            // 
            // nametbelipse
            // 
            this.nametbelipse.ElipseRadius = 7;
            this.nametbelipse.TargetControl = this.name2tb;
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
            // code2elipse
            // 
            this.code2elipse.ElipseRadius = 7;
            this.code2elipse.TargetControl = this.code2tb;
            // 
            // roomtypeelipse
            // 
            this.roomtypeelipse.ElipseRadius = 7;
            this.roomtypeelipse.TargetControl = this.roomtype2tb;
            // 
            // bedtypeelipse
            // 
            this.bedtypeelipse.ElipseRadius = 7;
            this.bedtypeelipse.TargetControl = this.bedtype2tb;
            // 
            // smokingnotallowedelipse
            // 
            this.smokingnotallowedelipse.ElipseRadius = 7;
            this.smokingnotallowedelipse.TargetControl = this.smokingallowed2tb;
            // 
            // Add_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(453, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxinfantno2tb);
            this.Controls.Add(this.maxchildno2tb);
            this.Controls.Add(this.maxadultno2tb);
            this.Controls.Add(this.bedtype2tb);
            this.Controls.Add(this.roomtype2tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomno2tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smokingallowed2tb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.code2tb);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.name2tb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_room";
            this.Load += new System.EventHandler(this.Add_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxadultno2tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxchildno2tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxinfantno2tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox smokingallowed2tb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox code2tb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox name2tb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox roomtype2tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomno2tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bedtype2tb;
        private System.Windows.Forms.NumericUpDown maxadultno2tb;
        private System.Windows.Forms.NumericUpDown maxchildno2tb;
        private System.Windows.Forms.NumericUpDown maxinfantno2tb;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse roomno2elipse;
        private Bunifu.Framework.UI.BunifuElipse nametbelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button6elipse;
        private Bunifu.Framework.UI.BunifuElipse button7elipse;
        private Bunifu.Framework.UI.BunifuElipse code2elipse;
        private Bunifu.Framework.UI.BunifuElipse roomtypeelipse;
        private Bunifu.Framework.UI.BunifuElipse bedtypeelipse;
        private Bunifu.Framework.UI.BunifuElipse smokingnotallowedelipse;
    }
}
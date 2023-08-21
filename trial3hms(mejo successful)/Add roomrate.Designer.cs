namespace WindowsFormsApplication1
{
    partial class Add_roomrate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_roomrate));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.roomtypetb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomrate2tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomtypeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.roomrateelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(123, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
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
            this.button2.Location = new System.Drawing.Point(205, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roomtypetb
            // 
            this.roomtypetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomtypetb.FormattingEnabled = true;
            this.roomtypetb.Location = new System.Drawing.Point(70, 7);
            this.roomtypetb.Name = "roomtypetb";
            this.roomtypetb.Size = new System.Drawing.Size(121, 21);
            this.roomtypetb.TabIndex = 1;
            this.roomtypetb.Click += new System.EventHandler(this.roomtypetb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Rate";
            // 
            // roomrate2tb
            // 
            this.roomrate2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomrate2tb.Location = new System.Drawing.Point(258, 7);
            this.roomrate2tb.Multiline = true;
            this.roomrate2tb.Name = "roomrate2tb";
            this.roomrate2tb.Size = new System.Drawing.Size(119, 20);
            this.roomrate2tb.TabIndex = 2;
            this.roomrate2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomrate2tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Type";
            // 
            // roomtypeelipse
            // 
            this.roomtypeelipse.ElipseRadius = 7;
            this.roomtypeelipse.TargetControl = this.roomtypetb;
            // 
            // roomrateelipse
            // 
            this.roomrateelipse.ElipseRadius = 7;
            this.roomrateelipse.TargetControl = this.roomrate2tb;
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
            // Add_roomrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(400, 67);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomrate2tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomtypetb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_roomrate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room Rate";
            this.Load += new System.EventHandler(this.Add_roomrate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox roomtypetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomrate2tb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse roomtypeelipse;
        private Bunifu.Framework.UI.BunifuElipse roomrateelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
    }
}
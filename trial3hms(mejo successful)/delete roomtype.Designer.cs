namespace WindowsFormsApplication1
{
    partial class delete_roomtype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_roomtype));
            this.label1 = new System.Windows.Forms.Label();
            this.reservationtb = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roomtypetb = new System.Windows.Forms.ComboBox();
            this.roomtypelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reservationdataelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationtb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Room Type";
            // 
            // reservationtb
            // 
            this.reservationtb.AllowUserToAddRows = false;
            this.reservationtb.BackgroundColor = System.Drawing.Color.White;
            this.reservationtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationtb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reservationtb.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.reservationtb.Location = new System.Drawing.Point(0, 69);
            this.reservationtb.Name = "reservationtb";
            this.reservationtb.RowHeadersVisible = false;
            this.reservationtb.Size = new System.Drawing.Size(227, 183);
            this.reservationtb.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(140, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomtypetb
            // 
            this.roomtypetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomtypetb.FormattingEnabled = true;
            this.roomtypetb.Location = new System.Drawing.Point(83, 7);
            this.roomtypetb.Name = "roomtypetb";
            this.roomtypetb.Size = new System.Drawing.Size(129, 21);
            this.roomtypetb.TabIndex = 1;
            // 
            // roomtypelipse
            // 
            this.roomtypelipse.ElipseRadius = 5;
            this.roomtypelipse.TargetControl = this.roomtypetb;
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
            // reservationdataelipse
            // 
            this.reservationdataelipse.ElipseRadius = 5;
            this.reservationdataelipse.TargetControl = this.reservationtb;
            // 
            // delete_roomtype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(227, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationtb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomtypetb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_roomtype";
            this.Text = "Delete Room Type";
            this.Load += new System.EventHandler(this.delete_roomtype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reservationtb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox roomtypetb;
        private Bunifu.Framework.UI.BunifuElipse roomtypelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse reservationdataelipse;
    }
}
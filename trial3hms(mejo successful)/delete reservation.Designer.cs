﻿namespace WindowsFormsApplication1
{
    partial class delete_reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_reservation));
            this.guestnamelisttb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reservationtb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomnotb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.guestnamelistelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.roomnotbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationtb)).BeginInit();
            this.SuspendLayout();
            // 
            // guestnamelisttb
            // 
            this.guestnamelisttb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestnamelisttb.FormattingEnabled = true;
            this.guestnamelisttb.Location = new System.Drawing.Point(75, 5);
            this.guestnamelisttb.Name = "guestnamelisttb";
            this.guestnamelisttb.Size = new System.Drawing.Size(120, 21);
            this.guestnamelisttb.TabIndex = 1;
            this.guestnamelisttb.Click += new System.EventHandler(this.guestnamelisttb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
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
            this.button2.Location = new System.Drawing.Point(337, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reservationtb
            // 
            this.reservationtb.AllowUserToAddRows = false;
            this.reservationtb.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reservationtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationtb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reservationtb.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.reservationtb.Location = new System.Drawing.Point(0, 78);
            this.reservationtb.Name = "reservationtb";
            this.reservationtb.RowHeadersVisible = false;
            this.reservationtb.Size = new System.Drawing.Size(424, 168);
            this.reservationtb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guest Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room No";
            // 
            // roomnotb
            // 
            this.roomnotb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomnotb.Location = new System.Drawing.Point(264, 6);
            this.roomnotb.Multiline = true;
            this.roomnotb.Name = "roomnotb";
            this.roomnotb.Size = new System.Drawing.Size(148, 20);
            this.roomnotb.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(189, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // guestnamelistelipse
            // 
            this.guestnamelistelipse.ElipseRadius = 5;
            this.guestnamelistelipse.TargetControl = this.guestnamelisttb;
            // 
            // roomnotbelipse
            // 
            this.roomnotbelipse.ElipseRadius = 5;
            this.roomnotbelipse.TargetControl = this.roomnotb;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 5;
            this.button1elipse.TargetControl = this.button1;
            // 
            // button3elipse
            // 
            this.button3elipse.ElipseRadius = 5;
            this.button3elipse.TargetControl = this.button3;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 5;
            this.button2elipse.TargetControl = this.button2;
            // 
            // delete_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(424, 246);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.roomnotb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationtb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guestnamelisttb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_reservation";
            this.Text = "Delete Reservation";
            this.Load += new System.EventHandler(this.delete_reservation_Load);
            this.Leave += new System.EventHandler(this.delete_reservation_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.reservationtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox guestnamelisttb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView reservationtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomnotb;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuElipse guestnamelistelipse;
        private Bunifu.Framework.UI.BunifuElipse roomnotbelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button3elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
    }
}
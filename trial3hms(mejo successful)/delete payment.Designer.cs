namespace WindowsFormsApplication1
{
    partial class delete_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_payment));
            this.paymentlisttb = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guestnamedeletetb = new System.Windows.Forms.ComboBox();
            this.refnodeletetb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allowsearchrefnotb = new System.Windows.Forms.CheckBox();
            this.guestnamedeletelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.refnodeleteelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paymentlistelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paymentlisttb)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentlisttb
            // 
            this.paymentlisttb.AllowUserToAddRows = false;
            this.paymentlisttb.BackgroundColor = System.Drawing.SystemColors.Window;
            this.paymentlisttb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentlisttb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentlisttb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentlisttb.Location = new System.Drawing.Point(0, 105);
            this.paymentlisttb.Name = "paymentlisttb";
            this.paymentlisttb.RowHeadersVisible = false;
            this.paymentlisttb.Size = new System.Drawing.Size(501, 99);
            this.paymentlisttb.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(414, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
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
            this.button1.Location = new System.Drawing.Point(333, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guest Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guestnamedeletetb
            // 
            this.guestnamedeletetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestnamedeletetb.FormattingEnabled = true;
            this.guestnamedeletetb.Location = new System.Drawing.Point(77, 6);
            this.guestnamedeletetb.Name = "guestnamedeletetb";
            this.guestnamedeletetb.Size = new System.Drawing.Size(163, 21);
            this.guestnamedeletetb.TabIndex = 1;
            this.guestnamedeletetb.SelectedValueChanged += new System.EventHandler(this.guestnamedeletetb_SelectedValueChanged);
            this.guestnamedeletetb.Click += new System.EventHandler(this.guestnamedeletetb_Click);
            // 
            // refnodeletetb
            // 
            this.refnodeletetb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refnodeletetb.FormattingEnabled = true;
            this.refnodeletetb.Location = new System.Drawing.Point(296, 6);
            this.refnodeletetb.Name = "refnodeletetb";
            this.refnodeletetb.Size = new System.Drawing.Size(196, 21);
            this.refnodeletetb.TabIndex = 10;
            this.refnodeletetb.Click += new System.EventHandler(this.refnodeletetb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ref. No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Note: If with multiple entries of Payment Check Allow Reference No to Select Spec" +
    "ific Payment";
            // 
            // allowsearchrefnotb
            // 
            this.allowsearchrefnotb.AutoSize = true;
            this.allowsearchrefnotb.Location = new System.Drawing.Point(24, 37);
            this.allowsearchrefnotb.Name = "allowsearchrefnotb";
            this.allowsearchrefnotb.Size = new System.Drawing.Size(186, 17);
            this.allowsearchrefnotb.TabIndex = 13;
            this.allowsearchrefnotb.Text = "Allow Search With Reference No.";
            this.allowsearchrefnotb.UseVisualStyleBackColor = true;
            this.allowsearchrefnotb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // guestnamedeletelipse
            // 
            this.guestnamedeletelipse.ElipseRadius = 7;
            this.guestnamedeletelipse.TargetControl = this.guestnamedeletetb;
            // 
            // refnodeleteelipse
            // 
            this.refnodeleteelipse.ElipseRadius = 7;
            this.refnodeleteelipse.TargetControl = this.refnodeletetb;
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
            // paymentlistelipse
            // 
            this.paymentlistelipse.ElipseRadius = 7;
            this.paymentlistelipse.TargetControl = this.paymentlisttb;
            // 
            // delete_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(501, 204);
            this.Controls.Add(this.allowsearchrefnotb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refnodeletetb);
            this.Controls.Add(this.paymentlisttb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestnamedeletetb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_payment";
            this.Text = "Delete Payment";
            this.Load += new System.EventHandler(this.delete_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentlisttb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentlisttb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox guestnamedeletetb;
        private System.Windows.Forms.ComboBox refnodeletetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allowsearchrefnotb;
        private Bunifu.Framework.UI.BunifuElipse guestnamedeletelipse;
        private Bunifu.Framework.UI.BunifuElipse refnodeleteelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
        private Bunifu.Framework.UI.BunifuElipse paymentlistelipse;
    }
}
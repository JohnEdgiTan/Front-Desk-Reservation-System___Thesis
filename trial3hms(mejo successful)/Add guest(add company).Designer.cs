namespace WindowsFormsApplication1
{
    partial class addcompanyguest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcompanyguest));
            this.companylisttb = new System.Windows.Forms.DataGridView();
            this.ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companyname2tb = new System.Windows.Forms.TextBox();
            this.dateaddedtb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.companynameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dateaddedelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.companylistelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.okelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cancelelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companylisttb)).BeginInit();
            this.SuspendLayout();
            // 
            // companylisttb
            // 
            this.companylisttb.AllowUserToAddRows = false;
            this.companylisttb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companylisttb.BackgroundColor = System.Drawing.Color.White;
            this.companylisttb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companylisttb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companylisttb.Location = new System.Drawing.Point(11, 59);
            this.companylisttb.Name = "companylisttb";
            this.companylisttb.RowHeadersVisible = false;
            this.companylisttb.Size = new System.Drawing.Size(261, 165);
            this.companylisttb.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.White;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Location = new System.Drawing.Point(62, 230);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "Confirm";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name";
            // 
            // companyname2tb
            // 
            this.companyname2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyname2tb.Location = new System.Drawing.Point(97, 7);
            this.companyname2tb.Multiline = true;
            this.companyname2tb.Name = "companyname2tb";
            this.companyname2tb.Size = new System.Drawing.Size(175, 20);
            this.companyname2tb.TabIndex = 3;
            // 
            // dateaddedtb
            // 
            this.dateaddedtb.CustomFormat = "yyyy-MM-dd";
            this.dateaddedtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateaddedtb.Location = new System.Drawing.Point(97, 33);
            this.dateaddedtb.Name = "dateaddedtb";
            this.dateaddedtb.Size = new System.Drawing.Size(175, 20);
            this.dateaddedtb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Added";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(143, 230);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // companynameelipse
            // 
            this.companynameelipse.ElipseRadius = 7;
            this.companynameelipse.TargetControl = this.companyname2tb;
            // 
            // dateaddedelipse
            // 
            this.dateaddedelipse.ElipseRadius = 7;
            this.dateaddedelipse.TargetControl = this.dateaddedtb;
            // 
            // companylistelipse
            // 
            this.companylistelipse.ElipseRadius = 7;
            this.companylistelipse.TargetControl = this.companylisttb;
            // 
            // okelipse
            // 
            this.okelipse.ElipseRadius = 7;
            this.okelipse.TargetControl = this.ok;
            // 
            // cancelelipse
            // 
            this.cancelelipse.ElipseRadius = 7;
            this.cancelelipse.TargetControl = this.cancel;
            // 
            // addcompanyguest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateaddedtb);
            this.Controls.Add(this.companyname2tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.companylisttb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addcompanyguest";
            this.Text = "Add Company";
            this.Load += new System.EventHandler(this.Add_guest_add_company__Load);
            ((System.ComponentModel.ISupportInitialize)(this.companylisttb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companylisttb;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyname2tb;
        private System.Windows.Forms.DateTimePicker dateaddedtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private Bunifu.Framework.UI.BunifuElipse companynameelipse;
        private Bunifu.Framework.UI.BunifuElipse dateaddedelipse;
        private Bunifu.Framework.UI.BunifuElipse companylistelipse;
        private Bunifu.Framework.UI.BunifuElipse okelipse;
        private Bunifu.Framework.UI.BunifuElipse cancelelipse;
    }
}
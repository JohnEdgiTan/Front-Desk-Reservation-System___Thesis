
namespace WindowsFormsApplication1
{
    partial class Userloginhistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userloginhistory));
            this.loginhistory = new System.Windows.Forms.DataGridView();
            this.Searchuser = new System.Windows.Forms.Button();
            this.userlistbt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.from3tb = new System.Windows.Forms.DateTimePicker();
            this.to3tb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // loginhistory
            // 
            this.loginhistory.AllowUserToAddRows = false;
            this.loginhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loginhistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.loginhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginhistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginhistory.Location = new System.Drawing.Point(0, 78);
            this.loginhistory.Name = "loginhistory";
            this.loginhistory.RowHeadersVisible = false;
            this.loginhistory.Size = new System.Drawing.Size(304, 308);
            this.loginhistory.TabIndex = 0;
            // 
            // Searchuser
            // 
            this.Searchuser.Location = new System.Drawing.Point(213, 4);
            this.Searchuser.Name = "Searchuser";
            this.Searchuser.Size = new System.Drawing.Size(80, 22);
            this.Searchuser.TabIndex = 1;
            this.Searchuser.Text = "Search";
            this.Searchuser.UseVisualStyleBackColor = true;
            this.Searchuser.Click += new System.EventHandler(this.button1_Click);
            // 
            // userlistbt
            // 
            this.userlistbt.Location = new System.Drawing.Point(99, 6);
            this.userlistbt.Name = "userlistbt";
            this.userlistbt.Size = new System.Drawing.Size(111, 20);
            this.userlistbt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for User";
            // 
            // from3tb
            // 
            this.from3tb.CustomFormat = "yyyy/MM/dd";
            this.from3tb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from3tb.Location = new System.Drawing.Point(50, 39);
            this.from3tb.Name = "from3tb";
            this.from3tb.Size = new System.Drawing.Size(83, 20);
            this.from3tb.TabIndex = 4;
            // 
            // to3tb
            // 
            this.to3tb.CustomFormat = "yyyy/MM/dd";
            this.to3tb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to3tb.Location = new System.Drawing.Point(213, 39);
            this.to3tb.Name = "to3tb";
            this.to3tb.Size = new System.Drawing.Size(82, 20);
            this.to3tb.TabIndex = 5;
            this.to3tb.CloseUp += new System.EventHandler(this.to3tb_CloseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // Userloginhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(304, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.to3tb);
            this.Controls.Add(this.from3tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlistbt);
            this.Controls.Add(this.Searchuser);
            this.Controls.Add(this.loginhistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Userloginhistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login History";
            this.Load += new System.EventHandler(this.Userloginhistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loginhistory;
        private System.Windows.Forms.Button Searchuser;
        private System.Windows.Forms.TextBox userlistbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker from3tb;
        private System.Windows.Forms.DateTimePicker to3tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
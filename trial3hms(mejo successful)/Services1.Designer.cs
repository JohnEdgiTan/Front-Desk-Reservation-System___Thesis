namespace WindowsFormsApplication1
{
    partial class Services1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.servicesdata = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.servicenames = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actioncb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.servicessearchtb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.arrowup = new System.Windows.Forms.Button();
            this.arrowdown = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnote = new System.Windows.Forms.Button();
            this.notes6 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noteslistdg5 = new System.Windows.Forms.DataGridView();
            this.actioncbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.servicesearchelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesdata)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.servicesdata);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2MinSize = 1;
            this.splitContainer1.Size = new System.Drawing.Size(1253, 595);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 0;
            // 
            // servicesdata
            // 
            this.servicesdata.AllowUserToAddRows = false;
            this.servicesdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.servicesdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.servicesdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.servicesdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.servicesdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicesdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.servicesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servicesdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.servicesdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicesdata.EnableHeadersVisualStyles = false;
            this.servicesdata.Location = new System.Drawing.Point(0, 50);
            this.servicesdata.Name = "servicesdata";
            this.servicesdata.ReadOnly = true;
            this.servicesdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicesdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.servicesdata.RowHeadersVisible = false;
            this.servicesdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.servicesdata.Size = new System.Drawing.Size(1251, 209);
            this.servicesdata.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.servicenames);
            this.panel2.Controls.Add(this.services);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 50);
            this.panel2.TabIndex = 5;
            // 
            // servicenames
            // 
            this.servicenames.BackColor = System.Drawing.Color.MediumAquamarine;
            this.servicenames.FlatAppearance.BorderSize = 0;
            this.servicenames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.servicenames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.servicenames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicenames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenames.Location = new System.Drawing.Point(119, 10);
            this.servicenames.Name = "servicenames";
            this.servicenames.Size = new System.Drawing.Size(138, 30);
            this.servicenames.TabIndex = 3;
            this.servicenames.Text = "Hotel Service Names";
            this.servicenames.UseVisualStyleBackColor = false;
            this.servicenames.Click += new System.EventHandler(this.servicenames_Click);
            // 
            // services
            // 
            this.services.BackColor = System.Drawing.Color.MediumAquamarine;
            this.services.FlatAppearance.BorderSize = 0;
            this.services.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.services.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.Location = new System.Drawing.Point(9, 10);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(103, 30);
            this.services.TabIndex = 2;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = false;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.servicessearchtb);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.arrowup);
            this.groupBox1.Controls.Add(this.arrowdown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1251, 38);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 12;
            this.guna2Panel1.Controls.Add(this.actioncb);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(2, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(196, 27);
            this.guna2Panel1.TabIndex = 30;
            // 
            // actioncb
            // 
            this.actioncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actioncb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actioncb.FormattingEnabled = true;
            this.actioncb.Location = new System.Drawing.Point(115, 2);
            this.actioncb.Name = "actioncb";
            this.actioncb.Size = new System.Drawing.Size(79, 23);
            this.actioncb.TabIndex = 26;
            this.actioncb.SelectedValueChanged += new System.EventHandler(this.actioncb_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select Action:";
            // 
            // servicessearchtb
            // 
            this.servicessearchtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.servicessearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicessearchtb.Location = new System.Drawing.Point(1047, 10);
            this.servicessearchtb.Multiline = true;
            this.servicessearchtb.Name = "servicessearchtb";
            this.servicessearchtb.Size = new System.Drawing.Size(104, 24);
            this.servicessearchtb.TabIndex = 28;
            this.servicessearchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servicessearchtb.TextChanged += new System.EventHandler(this.servicessearchtb_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1157, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 26);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Guest Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // arrowup
            // 
            this.arrowup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrowup.FlatAppearance.BorderSize = 0;
            this.arrowup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowup.Image = ((System.Drawing.Image)(resources.GetObject("arrowup.Image")));
            this.arrowup.Location = new System.Drawing.Point(1177, 9);
            this.arrowup.Name = "arrowup";
            this.arrowup.Size = new System.Drawing.Size(41, 24);
            this.arrowup.TabIndex = 1;
            this.arrowup.UseVisualStyleBackColor = true;
            this.arrowup.Click += new System.EventHandler(this.arrowup_Click);
            // 
            // arrowdown
            // 
            this.arrowdown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrowdown.FlatAppearance.BorderSize = 0;
            this.arrowdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.arrowdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.arrowdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowdown.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.arrowdown.Image = ((System.Drawing.Image)(resources.GetObject("arrowdown.Image")));
            this.arrowdown.Location = new System.Drawing.Point(1219, 9);
            this.arrowdown.Name = "arrowdown";
            this.arrowdown.Size = new System.Drawing.Size(21, 24);
            this.arrowdown.TabIndex = 0;
            this.arrowdown.UseVisualStyleBackColor = true;
            this.arrowdown.Click += new System.EventHandler(this.arrowdown_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1251, 140);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnote);
            this.tabPage4.Controls.Add(this.notes6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1243, 114);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Notes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnote
            // 
            this.btnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnote.BackColor = System.Drawing.SystemColors.Window;
            this.btnote.FlatAppearance.BorderSize = 0;
            this.btnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnote.Image = ((System.Drawing.Image)(resources.GetObject("btnote.Image")));
            this.btnote.Location = new System.Drawing.Point(1186, 53);
            this.btnote.Name = "btnote";
            this.btnote.Size = new System.Drawing.Size(54, 58);
            this.btnote.TabIndex = 6;
            this.btnote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnote.UseVisualStyleBackColor = false;
            this.btnote.Click += new System.EventHandler(this.btnote_Click);
            // 
            // notes6
            // 
            this.notes6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes6.Location = new System.Drawing.Point(0, 0);
            this.notes6.Multiline = true;
            this.notes6.Name = "notes6";
            this.notes6.Size = new System.Drawing.Size(1243, 114);
            this.notes6.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.noteslistdg5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1243, 114);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Notes List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noteslistdg5
            // 
            this.noteslistdg5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteslistdg5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.noteslistdg5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteslistdg5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteslistdg5.GridColor = System.Drawing.SystemColors.Window;
            this.noteslistdg5.Location = new System.Drawing.Point(0, 0);
            this.noteslistdg5.Name = "noteslistdg5";
            this.noteslistdg5.RowHeadersVisible = false;
            this.noteslistdg5.Size = new System.Drawing.Size(1243, 114);
            this.noteslistdg5.TabIndex = 4;
            // 
            // actioncbelipse
            // 
            this.actioncbelipse.ElipseRadius = 15;
            this.actioncbelipse.TargetControl = this.actioncb;
            // 
            // servicesearchelipse
            // 
            this.servicesearchelipse.ElipseRadius = 15;
            this.servicesearchelipse.TargetControl = this.servicessearchtb;
            // 
            // Services1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1253, 595);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Services1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Services1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesdata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button arrowup;
        private System.Windows.Forms.Button arrowdown;
        private System.Windows.Forms.TextBox servicessearchtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox notes6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView noteslistdg5;
        private System.Windows.Forms.DataGridView servicesdata;
        private System.Windows.Forms.Button btnote;
        private System.Windows.Forms.Button servicenames;
        private System.Windows.Forms.Button services;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox actioncb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse actioncbelipse;
        private Bunifu.Framework.UI.BunifuElipse servicesearchelipse;
    }
}
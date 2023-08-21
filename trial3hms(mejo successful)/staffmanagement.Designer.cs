namespace WindowsFormsApplication1
{
    partial class staffmanagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffmanagement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.staffdata = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actioncb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.staffemailtb = new System.Windows.Forms.TextBox();
            this.staffnametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.arrowup = new System.Windows.Forms.Button();
            this.arrowdown = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnote = new System.Windows.Forms.Button();
            this.notes7 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.noteslistdg6 = new System.Windows.Forms.DataGridView();
            this.actioncbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffnameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffemailelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffuserlevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg6)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.staffuserlevel);
            this.splitContainer1.Panel1.Controls.Add(this.staffdata);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 1;
            this.splitContainer1.Size = new System.Drawing.Size(1253, 700);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 0;
            // 
            // staffdata
            // 
            this.staffdata.AllowUserToAddRows = false;
            this.staffdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.staffdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.staffdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.staffdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffdata.EnableHeadersVisualStyles = false;
            this.staffdata.Location = new System.Drawing.Point(0, 30);
            this.staffdata.Name = "staffdata";
            this.staffdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.staffdata.RowHeadersVisible = false;
            this.staffdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffdata.Size = new System.Drawing.Size(1251, 226);
            this.staffdata.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 30);
            this.panel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.staffemailtb);
            this.groupBox1.Controls.Add(this.staffnametb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.arrowup);
            this.groupBox1.Controls.Add(this.arrowdown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 435);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1251, 38);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 12;
            this.guna2Panel1.Controls.Add(this.actioncb);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(196, 27);
            this.guna2Panel1.TabIndex = 35;
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
            // staffemailtb
            // 
            this.staffemailtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.staffemailtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffemailtb.Location = new System.Drawing.Point(1042, 10);
            this.staffemailtb.Multiline = true;
            this.staffemailtb.Name = "staffemailtb";
            this.staffemailtb.Size = new System.Drawing.Size(121, 24);
            this.staffemailtb.TabIndex = 34;
            // 
            // staffnametb
            // 
            this.staffnametb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.staffnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffnametb.Location = new System.Drawing.Point(858, 10);
            this.staffnametb.Multiline = true;
            this.staffnametb.Name = "staffnametb";
            this.staffnametb.Size = new System.Drawing.Size(121, 24);
            this.staffnametb.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(982, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Staff Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Staff Name";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1167, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 26);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // arrowup
            // 
            this.arrowup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrowup.FlatAppearance.BorderSize = 0;
            this.arrowup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowup.Image = ((System.Drawing.Image)(resources.GetObject("arrowup.Image")));
            this.arrowup.Location = new System.Drawing.Point(1197, 9);
            this.arrowup.Name = "arrowup";
            this.arrowup.Size = new System.Drawing.Size(29, 24);
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
            this.arrowdown.Location = new System.Drawing.Point(1224, 9);
            this.arrowdown.Name = "arrowdown";
            this.arrowdown.Size = new System.Drawing.Size(21, 24);
            this.arrowdown.TabIndex = 0;
            this.arrowdown.UseVisualStyleBackColor = true;
            this.arrowdown.Click += new System.EventHandler(this.arrowdown_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 219);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnote);
            this.tabPage3.Controls.Add(this.notes7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1243, 193);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnote
            // 
            this.btnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnote.BackColor = System.Drawing.SystemColors.Window;
            this.btnote.FlatAppearance.BorderSize = 0;
            this.btnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnote.Image = ((System.Drawing.Image)(resources.GetObject("btnote.Image")));
            this.btnote.Location = new System.Drawing.Point(1185, 131);
            this.btnote.Name = "btnote";
            this.btnote.Size = new System.Drawing.Size(54, 58);
            this.btnote.TabIndex = 7;
            this.btnote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnote.UseVisualStyleBackColor = false;
            this.btnote.Click += new System.EventHandler(this.btnote_Click);
            // 
            // notes7
            // 
            this.notes7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes7.Location = new System.Drawing.Point(0, 0);
            this.notes7.Multiline = true;
            this.notes7.Name = "notes7";
            this.notes7.Size = new System.Drawing.Size(1243, 193);
            this.notes7.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.noteslistdg6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1243, 193);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Notes List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // noteslistdg6
            // 
            this.noteslistdg6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteslistdg6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.noteslistdg6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteslistdg6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteslistdg6.GridColor = System.Drawing.SystemColors.Window;
            this.noteslistdg6.Location = new System.Drawing.Point(0, 0);
            this.noteslistdg6.Name = "noteslistdg6";
            this.noteslistdg6.RowHeadersVisible = false;
            this.noteslistdg6.Size = new System.Drawing.Size(1243, 193);
            this.noteslistdg6.TabIndex = 5;
            // 
            // actioncbelipse
            // 
            this.actioncbelipse.ElipseRadius = 15;
            this.actioncbelipse.TargetControl = this.actioncb;
            // 
            // staffnameelipse
            // 
            this.staffnameelipse.ElipseRadius = 15;
            this.staffnameelipse.TargetControl = this.staffnametb;
            // 
            // staffemailelipse
            // 
            this.staffemailelipse.ElipseRadius = 15;
            this.staffemailelipse.TargetControl = this.staffemailtb;
            // 
            // staffuserlevel
            // 
            this.staffuserlevel.AutoSize = true;
            this.staffuserlevel.Location = new System.Drawing.Point(1210, 422);
            this.staffuserlevel.Name = "staffuserlevel";
            this.staffuserlevel.Size = new System.Drawing.Size(35, 13);
            this.staffuserlevel.TabIndex = 8;
            this.staffuserlevel.Text = "label1";
            // 
            // staffmanagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1253, 700);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "staffmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "staffmanagement";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.staffmanagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button arrowup;
        private System.Windows.Forms.Button arrowdown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox notes7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView noteslistdg6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView staffdata;
        private System.Windows.Forms.TextBox staffemailtb;
        private System.Windows.Forms.TextBox staffnametb;
        private System.Windows.Forms.Button btnote;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox actioncb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse actioncbelipse;
        private Bunifu.Framework.UI.BunifuElipse staffnameelipse;
        private Bunifu.Framework.UI.BunifuElipse staffemailelipse;
        public System.Windows.Forms.Label staffuserlevel;
    }
}
namespace WindowsFormsApplication1
{
    partial class Guestform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guestform));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.guestsdata = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actioncb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namesearchtb = new System.Windows.Forms.TextBox();
            this.emailsearchtb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.arrowup = new System.Windows.Forms.Button();
            this.arrowdown = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnote = new System.Windows.Forms.Button();
            this.notes3 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.noteslistdg2 = new System.Windows.Forms.DataGridView();
            this.actioncbelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.emailsearchelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.namesearch = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.guestsdata);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2MinSize = 1;
            this.splitContainer1.Size = new System.Drawing.Size(1253, 700);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.TabIndex = 0;
            // 
            // guestsdata
            // 
            this.guestsdata.AllowUserToAddRows = false;
            this.guestsdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.guestsdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guestsdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.guestsdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestsdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.guestsdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guestsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guestsdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.guestsdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.guestsdata.EnableHeadersVisualStyles = false;
            this.guestsdata.Location = new System.Drawing.Point(0, 33);
            this.guestsdata.Name = "guestsdata";
            this.guestsdata.ReadOnly = true;
            this.guestsdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestsdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guestsdata.RowHeadersVisible = false;
            this.guestsdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.guestsdata.Size = new System.Drawing.Size(1251, 242);
            this.guestsdata.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 33);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.namesearchtb);
            this.groupBox1.Controls.Add(this.emailsearchtb);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.arrowup);
            this.groupBox1.Controls.Add(this.arrowdown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 472);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1251, 38);
            this.groupBox1.TabIndex = 3;
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
            this.guna2Panel1.Location = new System.Drawing.Point(0, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(196, 27);
            this.guna2Panel1.TabIndex = 33;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(989, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = " Name";
            // 
            // namesearchtb
            // 
            this.namesearchtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.namesearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namesearchtb.Location = new System.Drawing.Point(853, 10);
            this.namesearchtb.Multiline = true;
            this.namesearchtb.Name = "namesearchtb";
            this.namesearchtb.Size = new System.Drawing.Size(132, 24);
            this.namesearchtb.TabIndex = 29;
            // 
            // emailsearchtb
            // 
            this.emailsearchtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailsearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailsearchtb.Location = new System.Drawing.Point(1025, 10);
            this.emailsearchtb.Multiline = true;
            this.emailsearchtb.Name = "emailsearchtb";
            this.emailsearchtb.Size = new System.Drawing.Size(132, 24);
            this.emailsearchtb.TabIndex = 30;
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1251, 182);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnote);
            this.tabPage2.Controls.Add(this.notes3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1243, 156);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnote
            // 
            this.btnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnote.BackColor = System.Drawing.SystemColors.Window;
            this.btnote.FlatAppearance.BorderSize = 0;
            this.btnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnote.Image = ((System.Drawing.Image)(resources.GetObject("btnote.Image")));
            this.btnote.Location = new System.Drawing.Point(1182, 91);
            this.btnote.Name = "btnote";
            this.btnote.Size = new System.Drawing.Size(54, 58);
            this.btnote.TabIndex = 6;
            this.btnote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnote.UseVisualStyleBackColor = false;
            this.btnote.Click += new System.EventHandler(this.btnote_Click);
            // 
            // notes3
            // 
            this.notes3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes3.Location = new System.Drawing.Point(3, 3);
            this.notes3.Multiline = true;
            this.notes3.Name = "notes3";
            this.notes3.Size = new System.Drawing.Size(1237, 150);
            this.notes3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.noteslistdg2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1243, 156);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Notes List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // noteslistdg2
            // 
            this.noteslistdg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteslistdg2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.noteslistdg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteslistdg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteslistdg2.GridColor = System.Drawing.SystemColors.Window;
            this.noteslistdg2.Location = new System.Drawing.Point(0, 0);
            this.noteslistdg2.Name = "noteslistdg2";
            this.noteslistdg2.RowHeadersVisible = false;
            this.noteslistdg2.Size = new System.Drawing.Size(1243, 156);
            this.noteslistdg2.TabIndex = 1;
            // 
            // actioncbelipse
            // 
            this.actioncbelipse.ElipseRadius = 15;
            this.actioncbelipse.TargetControl = this.actioncb;
            // 
            // emailsearchelipse
            // 
            this.emailsearchelipse.ElipseRadius = 15;
            this.emailsearchelipse.TargetControl = this.emailsearchtb;
            // 
            // namesearch
            // 
            this.namesearch.ElipseRadius = 15;
            this.namesearch.TargetControl = this.namesearchtb;
            // 
            // Guestform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1253, 700);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guestform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Guestform";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Guestform_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestsdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button arrowup;
        private System.Windows.Forms.Button arrowdown;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox notes3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView noteslistdg2;
        private System.Windows.Forms.TextBox namesearchtb;
        private System.Windows.Forms.TextBox emailsearchtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView guestsdata;
        private System.Windows.Forms.Button btnote;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox actioncb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse actioncbelipse;
        private Bunifu.Framework.UI.BunifuElipse emailsearchelipse;
        private Bunifu.Framework.UI.BunifuElipse namesearch;
    }
}
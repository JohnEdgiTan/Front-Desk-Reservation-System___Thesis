namespace WindowsFormsApplication1
{
    partial class Reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notessection = new System.Windows.Forms.SplitContainer();
            this.actionpanel = new System.Windows.Forms.Panel();
            this.reservationdata3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actioncb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guestname2tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to2tb = new System.Windows.Forms.DateTimePicker();
            this.from2tb = new System.Windows.Forms.DateTimePicker();
            this.choices2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrowup = new System.Windows.Forms.Button();
            this.arrowdown = new System.Windows.Forms.Button();
            this.paymentstb2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnote = new System.Windows.Forms.Button();
            this.Notes2 = new System.Windows.Forms.TextBox();
            this.notelist = new System.Windows.Forms.TabPage();
            this.noteslistdg = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.secretrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notessection)).BeginInit();
            this.notessection.Panel1.SuspendLayout();
            this.notessection.Panel2.SuspendLayout();
            this.notessection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.paymentstb2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.notelist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg)).BeginInit();
            this.SuspendLayout();
            // 
            // notessection
            // 
            this.notessection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notessection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notessection.Location = new System.Drawing.Point(0, 0);
            this.notessection.Name = "notessection";
            this.notessection.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // notessection.Panel1
            // 
            this.notessection.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.notessection.Panel1.Controls.Add(this.actionpanel);
            this.notessection.Panel1.Controls.Add(this.reservationdata3);
            this.notessection.Panel1.Controls.Add(this.panel2);
            this.notessection.Panel1.Controls.Add(this.groupBox1);
            this.notessection.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // notessection.Panel2
            // 
            this.notessection.Panel2.Controls.Add(this.paymentstb2);
            this.notessection.Panel2MinSize = 1;
            this.notessection.Size = new System.Drawing.Size(946, 600);
            this.notessection.SplitterDistance = 477;
            this.notessection.TabIndex = 2;
            // 
            // actionpanel
            // 
            this.actionpanel.BackColor = System.Drawing.Color.LightGray;
            this.actionpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionpanel.Location = new System.Drawing.Point(0, 266);
            this.actionpanel.Name = "actionpanel";
            this.actionpanel.Size = new System.Drawing.Size(944, 171);
            this.actionpanel.TabIndex = 5;
            // 
            // reservationdata3
            // 
            this.reservationdata3.AllowUserToAddRows = false;
            this.reservationdata3.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservationdata3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.reservationdata3.BackgroundColor = System.Drawing.Color.LightGray;
            this.reservationdata3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationdata3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reservationdata3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationdata3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.reservationdata3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationdata3.DefaultCellStyle = dataGridViewCellStyle19;
            this.reservationdata3.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationdata3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.reservationdata3.EnableHeadersVisualStyles = false;
            this.reservationdata3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.reservationdata3.Location = new System.Drawing.Point(0, 41);
            this.reservationdata3.Name = "reservationdata3";
            this.reservationdata3.ReadOnly = true;
            this.reservationdata3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationdata3.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.reservationdata3.RowHeadersVisible = false;
            this.reservationdata3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reservationdata3.Size = new System.Drawing.Size(944, 225);
            this.reservationdata3.StandardTab = true;
            this.reservationdata3.TabIndex = 4;
            this.reservationdata3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.reservationdata2_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.secretrefresh);
            this.panel2.Controls.Add(this.guna2PictureBox3);
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 41);
            this.panel2.TabIndex = 3;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2PictureBox3.BorderRadius = 5;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.SpringGreen;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(822, 9);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 23);
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2PictureBox2.BorderRadius = 5;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Yellow;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(711, 9);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(30, 23);
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Orange;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(593, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 23);
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Checked Out";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(747, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Reserved";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(852, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Checked In";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.guestname2tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.to2tb);
            this.groupBox1.Controls.Add(this.from2tb);
            this.groupBox1.Controls.Add(this.choices2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.arrowup);
            this.groupBox1.Controls.Add(this.arrowdown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 437);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(944, 38);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 12;
            this.guna2Panel1.Controls.Add(this.actioncb);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(6, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(197, 27);
            this.guna2Panel1.TabIndex = 28;
            // 
            // actioncb
            // 
            this.actioncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actioncb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actioncb.FormattingEnabled = true;
            this.actioncb.Location = new System.Drawing.Point(117, 2);
            this.actioncb.Name = "actioncb";
            this.actioncb.Size = new System.Drawing.Size(79, 23);
            this.actioncb.TabIndex = 26;
            this.actioncb.SelectedIndexChanged += new System.EventHandler(this.actioncb_SelectedIndexChanged);
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
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(860, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 26);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Guest Name";
            // 
            // guestname2tb
            // 
            this.guestname2tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guestname2tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestname2tb.Location = new System.Drawing.Point(764, 11);
            this.guestname2tb.Multiline = true;
            this.guestname2tb.Name = "guestname2tb";
            this.guestname2tb.Size = new System.Drawing.Size(93, 23);
            this.guestname2tb.TabIndex = 23;
            this.guestname2tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "From";
            // 
            // to2tb
            // 
            this.to2tb.CustomFormat = "yyyy/MM/dd";
            this.to2tb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to2tb.Location = new System.Drawing.Point(591, 12);
            this.to2tb.Name = "to2tb";
            this.to2tb.Size = new System.Drawing.Size(100, 20);
            this.to2tb.TabIndex = 20;
            this.to2tb.CloseUp += new System.EventHandler(this.to2tb_CloseUp);
            // 
            // from2tb
            // 
            this.from2tb.CustomFormat = "yyyy/MM/dd";
            this.from2tb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from2tb.Location = new System.Drawing.Point(461, 12);
            this.from2tb.Name = "from2tb";
            this.from2tb.Size = new System.Drawing.Size(100, 20);
            this.from2tb.TabIndex = 19;
            // 
            // choices2
            // 
            this.choices2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choices2.FormattingEnabled = true;
            this.choices2.Items.AddRange(new object[] {
            "Checked out",
            "Checked in",
            "Reserved"});
            this.choices2.Location = new System.Drawing.Point(298, 12);
            this.choices2.Name = "choices2";
            this.choices2.Size = new System.Drawing.Size(126, 21);
            this.choices2.TabIndex = 17;
            this.choices2.SelectedValueChanged += new System.EventHandler(this.choices2_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sort By:";
            // 
            // arrowup
            // 
            this.arrowup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrowup.FlatAppearance.BorderSize = 0;
            this.arrowup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.arrowup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowup.Image = ((System.Drawing.Image)(resources.GetObject("arrowup.Image")));
            this.arrowup.Location = new System.Drawing.Point(878, 9);
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
            this.arrowdown.Location = new System.Drawing.Point(917, 9);
            this.arrowdown.Name = "arrowdown";
            this.arrowdown.Size = new System.Drawing.Size(21, 24);
            this.arrowdown.TabIndex = 0;
            this.arrowdown.UseVisualStyleBackColor = true;
            this.arrowdown.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentstb2
            // 
            this.paymentstb2.Controls.Add(this.tabPage4);
            this.paymentstb2.Controls.Add(this.notelist);
            this.paymentstb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentstb2.Location = new System.Drawing.Point(0, 0);
            this.paymentstb2.Name = "paymentstb2";
            this.paymentstb2.SelectedIndex = 0;
            this.paymentstb2.Size = new System.Drawing.Size(944, 117);
            this.paymentstb2.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnote);
            this.tabPage4.Controls.Add(this.Notes2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(936, 91);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "USer";
            this.label5.Visible = false;
            // 
            // btnote
            // 
            this.btnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnote.BackColor = System.Drawing.SystemColors.Window;
            this.btnote.FlatAppearance.BorderSize = 0;
            this.btnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnote.Image = ((System.Drawing.Image)(resources.GetObject("btnote.Image")));
            this.btnote.Location = new System.Drawing.Point(873, 26);
            this.btnote.Name = "btnote";
            this.btnote.Size = new System.Drawing.Size(54, 58);
            this.btnote.TabIndex = 2;
            this.btnote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnote.UseVisualStyleBackColor = false;
            this.btnote.Click += new System.EventHandler(this.btnote_Click_1);
            this.btnote.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnote_ChangeUICues);
            // 
            // Notes2
            // 
            this.Notes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notes2.Location = new System.Drawing.Point(3, 3);
            this.Notes2.Multiline = true;
            this.Notes2.Name = "Notes2";
            this.Notes2.Size = new System.Drawing.Size(930, 85);
            this.Notes2.TabIndex = 0;
            // 
            // notelist
            // 
            this.notelist.Controls.Add(this.noteslistdg);
            this.notelist.Location = new System.Drawing.Point(4, 22);
            this.notelist.Name = "notelist";
            this.notelist.Size = new System.Drawing.Size(936, 91);
            this.notelist.TabIndex = 4;
            this.notelist.Text = "Notes List";
            this.notelist.UseVisualStyleBackColor = true;
            // 
            // noteslistdg
            // 
            this.noteslistdg.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.noteslistdg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.noteslistdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteslistdg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.noteslistdg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteslistdg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.noteslistdg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noteslistdg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.noteslistdg.ColumnHeadersHeight = 4;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.noteslistdg.DefaultCellStyle = dataGridViewCellStyle23;
            this.noteslistdg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteslistdg.EnableHeadersVisualStyles = false;
            this.noteslistdg.GridColor = System.Drawing.SystemColors.Window;
            this.noteslistdg.Location = new System.Drawing.Point(0, 0);
            this.noteslistdg.Name = "noteslistdg";
            this.noteslistdg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noteslistdg.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.noteslistdg.RowHeadersVisible = false;
            this.noteslistdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.noteslistdg.Size = new System.Drawing.Size(936, 91);
            this.noteslistdg.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.actioncb;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.guestname2tb;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.to2tb;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.from2tb;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.choices2;
            // 
            // secretrefresh
            // 
            this.secretrefresh.Location = new System.Drawing.Point(0, -1);
            this.secretrefresh.Name = "secretrefresh";
            this.secretrefresh.Size = new System.Drawing.Size(31, 23);
            this.secretrefresh.TabIndex = 9;
            this.secretrefresh.Text = "button1";
            this.secretrefresh.UseVisualStyleBackColor = true;
            this.secretrefresh.Visible = false;
            this.secretrefresh.Click += new System.EventHandler(this.secretrefresh_Click_1);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(946, 600);
            this.Controls.Add(this.notessection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.notessection.Panel1.ResumeLayout(false);
            this.notessection.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notessection)).EndInit();
            this.notessection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.paymentstb2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.notelist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteslistdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer notessection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox actioncb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox guestname2tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker to2tb;
        private System.Windows.Forms.DateTimePicker from2tb;
        private System.Windows.Forms.ComboBox choices2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button arrowup;
        private System.Windows.Forms.Button arrowdown;
        private System.Windows.Forms.TabControl paymentstb2;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnote;
        private System.Windows.Forms.TextBox Notes2;
        private System.Windows.Forms.TabPage notelist;
        private System.Windows.Forms.DataGridView noteslistdg;
        public System.Windows.Forms.DataGridView reservationdata3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel actionpanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        public System.Windows.Forms.Button secretrefresh;
    }
}
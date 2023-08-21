
namespace WindowsFormsApplication1
{
    partial class reservationmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationmenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Button();
            this.guests = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.Room = new System.Windows.Forms.Button();
            this.booking = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.newuipanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.staffnametext = new Bunifu.UI.WinForms.BunifuLabel();
            this.userleveltext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.newuipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.userleveltext);
            this.panel1.Controls.Add(this.staffnametext);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 53);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(7, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 33);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menupanel.Controls.Add(this.logout);
            this.menupanel.Controls.Add(this.settings);
            this.menupanel.Controls.Add(this.account);
            this.menupanel.Controls.Add(this.Database);
            this.menupanel.Controls.Add(this.Reports);
            this.menupanel.Controls.Add(this.staff);
            this.menupanel.Controls.Add(this.Time);
            this.menupanel.Controls.Add(this.label2);
            this.menupanel.Controls.Add(this.guests);
            this.menupanel.Controls.Add(this.Services);
            this.menupanel.Controls.Add(this.Room);
            this.menupanel.Controls.Add(this.booking);
            this.menupanel.Controls.Add(this.dashboard);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 53);
            this.menupanel.Name = "menupanel";
            this.menupanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menupanel.Size = new System.Drawing.Size(175, 608);
            this.menupanel.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 350);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logout.Size = new System.Drawing.Size(175, 35);
            this.logout.TabIndex = 17;
            this.logout.Text = "Logout";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Location = new System.Drawing.Point(0, 315);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settings.Size = new System.Drawing.Size(175, 35);
            this.settings.TabIndex = 16;
            this.settings.Text = "System Settings";
            this.settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // account
            // 
            this.account.Dock = System.Windows.Forms.DockStyle.Top;
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Image = ((System.Drawing.Image)(resources.GetObject("account.Image")));
            this.account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.Location = new System.Drawing.Point(0, 280);
            this.account.Name = "account";
            this.account.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.account.Size = new System.Drawing.Size(175, 35);
            this.account.TabIndex = 15;
            this.account.Text = "Accounts";
            this.account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // Database
            // 
            this.Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.Database.FlatAppearance.BorderSize = 0;
            this.Database.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Database.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database.Image = ((System.Drawing.Image)(resources.GetObject("Database.Image")));
            this.Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Database.Location = new System.Drawing.Point(0, 245);
            this.Database.Name = "Database";
            this.Database.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Database.Size = new System.Drawing.Size(175, 35);
            this.Database.TabIndex = 11;
            this.Database.Text = "Database";
            this.Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Database.UseVisualStyleBackColor = true;
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // Reports
            // 
            this.Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports.FlatAppearance.BorderSize = 0;
            this.Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports.Location = new System.Drawing.Point(0, 210);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Reports.Size = new System.Drawing.Size(175, 35);
            this.Reports.TabIndex = 10;
            this.Reports.Text = "Reports";
            this.Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // staff
            // 
            this.staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.staff.FlatAppearance.BorderSize = 0;
            this.staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff.Image = ((System.Drawing.Image)(resources.GetObject("staff.Image")));
            this.staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff.Location = new System.Drawing.Point(0, 175);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.staff.Size = new System.Drawing.Size(175, 35);
            this.staff.TabIndex = 9;
            this.staff.Text = "Staff";
            this.staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // Time
            // 
            this.Time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Time.FlatAppearance.BorderSize = 0;
            this.Time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(0, 558);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(175, 25);
            this.Time.TabIndex = 8;
            this.Time.Text = "button1";
            this.Time.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Time.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatAppearance.BorderSize = 0;
            this.label2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "button1";
            this.label2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.label2.UseVisualStyleBackColor = true;
            // 
            // guests
            // 
            this.guests.Dock = System.Windows.Forms.DockStyle.Top;
            this.guests.FlatAppearance.BorderSize = 0;
            this.guests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.guests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guests.Image = ((System.Drawing.Image)(resources.GetObject("guests.Image")));
            this.guests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guests.Location = new System.Drawing.Point(0, 140);
            this.guests.Name = "guests";
            this.guests.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guests.Size = new System.Drawing.Size(175, 35);
            this.guests.TabIndex = 6;
            this.guests.Text = "Guest";
            this.guests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guests.UseVisualStyleBackColor = true;
            this.guests.Click += new System.EventHandler(this.guests_Click_1);
            // 
            // Services
            // 
            this.Services.Dock = System.Windows.Forms.DockStyle.Top;
            this.Services.FlatAppearance.BorderSize = 0;
            this.Services.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Services.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Image = ((System.Drawing.Image)(resources.GetObject("Services.Image")));
            this.Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Services.Location = new System.Drawing.Point(0, 105);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Services.Size = new System.Drawing.Size(175, 35);
            this.Services.TabIndex = 5;
            this.Services.Text = "Services";
            this.Services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Room
            // 
            this.Room.Dock = System.Windows.Forms.DockStyle.Top;
            this.Room.FlatAppearance.BorderSize = 0;
            this.Room.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Room.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.Image = ((System.Drawing.Image)(resources.GetObject("Room.Image")));
            this.Room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room.Location = new System.Drawing.Point(0, 70);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Room.Size = new System.Drawing.Size(175, 35);
            this.Room.TabIndex = 3;
            this.Room.Text = "Room";
            this.Room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Room.UseVisualStyleBackColor = true;
            this.Room.Click += new System.EventHandler(this.Room_Click);
            // 
            // booking
            // 
            this.booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.booking.FlatAppearance.BorderSize = 0;
            this.booking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.booking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking.Image = ((System.Drawing.Image)(resources.GetObject("booking.Image")));
            this.booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booking.Location = new System.Drawing.Point(0, 35);
            this.booking.Name = "booking";
            this.booking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.booking.Size = new System.Drawing.Size(175, 35);
            this.booking.TabIndex = 2;
            this.booking.Text = "Booking";
            this.booking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.booking.UseVisualStyleBackColor = true;
            this.booking.Click += new System.EventHandler(this.guests_Click);
            // 
            // dashboard
            // 
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.Black;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(175, 35);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // newuipanel
            // 
            this.newuipanel.AutoSize = true;
            this.newuipanel.BackColor = System.Drawing.Color.Beige;
            this.newuipanel.Controls.Add(this.label3);
            this.newuipanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newuipanel.Location = new System.Drawing.Point(175, 53);
            this.newuipanel.Name = "newuipanel";
            this.newuipanel.Size = new System.Drawing.Size(1109, 608);
            this.newuipanel.TabIndex = 2;
            this.newuipanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 23;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(1230, 5);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(46, 46);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // staffnametext
            // 
            this.staffnametext.AllowParentOverrides = false;
            this.staffnametext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.staffnametext.AutoEllipsis = false;
            this.staffnametext.AutoSize = false;
            this.staffnametext.CursorType = System.Windows.Forms.Cursors.Default;
            this.staffnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnametext.Location = new System.Drawing.Point(933, 5);
            this.staffnametext.Name = "staffnametext";
            this.staffnametext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.staffnametext.Size = new System.Drawing.Size(291, 24);
            this.staffnametext.TabIndex = 2;
            this.staffnametext.Text = "bunifuLabel1";
            this.staffnametext.TextAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.staffnametext.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // userleveltext
            // 
            this.userleveltext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userleveltext.Location = new System.Drawing.Point(1010, 31);
            this.userleveltext.Name = "userleveltext";
            this.userleveltext.Size = new System.Drawing.Size(217, 17);
            this.userleveltext.TabIndex = 3;
            this.userleveltext.Text = "label1";
            this.userleveltext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reservationmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.newuipanel);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 680);
            this.Name = "reservationmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Front Desk Property Management System";
            this.Load += new System.EventHandler(this.reservationmenu_Load);
            this.panel1.ResumeLayout(false);
            this.menupanel.ResumeLayout(false);
            this.newuipanel.ResumeLayout(false);
            this.newuipanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button guests;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button Room;
        private System.Windows.Forms.Button booking;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button Time;
        public System.Windows.Forms.Button label2;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button Database;
        private System.Windows.Forms.Button Reports;
        public System.Windows.Forms.Panel newuipanel;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button settings;
        public System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        public System.Windows.Forms.Label userleveltext;
        public Bunifu.UI.WinForms.BunifuLabel staffnametext;
    }
}
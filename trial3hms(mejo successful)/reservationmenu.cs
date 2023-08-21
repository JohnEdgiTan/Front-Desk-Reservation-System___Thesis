using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class reservationmenu : Form
    {
        public reservationmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menupanel.Width == 175)
            {
                menupanel.Width = 56;
                dashboard.Text = "";
                booking.Text = "";
                Room.Text = "";
                Services.Text = "";
                guests.Text = "";
                staff.Text = "";
                Reports.Text = "";
                Database.Text = "";
                settings.Text="";
                account.Text = "";
                logout.Text = "";
            }
            else
            {
                menupanel.Width = 175;
                dashboard.Text = "Dashboard";
                booking.Text = "Booking";
                Room.Text = "Room";
                Services.Text = "Services";
                guests.Text = "Guest";
                staff.Text = "Staff";
                Reports.Text = "Reports";
                Database.Text = "Database";
                account.Text = "Account";
                logout.Text = "Logout";
                settings.Text = "System Settings";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.PaleGreen;
            booking.BackColor = Color.WhiteSmoke;;
            Room.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            dashboard rar = new dashboard();
            rar.Owner = this;
            rar.TopLevel = false;
            rar.TopMost = true;
            rar.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(rar);
            rar.Show();
            rar.BringToFront();
            newuipanel.Update();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void reservationmenu_Load(object sender, EventArgs e)
        {

            if (label3.Text == "User")
            {
                staff.Visible = false;
                Reports.Visible = false;
                Database.Visible = false;
                account.Visible = false;
            }
            DateTime now = DateTime.Now;
            Time.Text = now.ToString();
            dashboard.BackColor = Color.PaleGreen;
            booking.BackColor = Color.WhiteSmoke; ;
            Room.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            dashboard dsb= new dashboard();
            dsb.Owner = this;
            dsb.TopLevel = false;
            dsb.TopMost = true;
            dsb.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(dsb);
            dsb.Show();
            dsb.BringToFront();
            newuipanel.Update();
        }

        private void guests_Click(object sender, EventArgs e)
        {
            booking.BackColor=Color.PaleGreen;
            dashboard.BackColor=Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            Reservation rr = new Reservation();
            rr.Owner = this;
            rr.TopLevel = false;
            rr.TopMost = true;
            rr.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(rr);
            rr.Show();
            rr.BringToFront();
            newuipanel.Update();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            Room.BackColor = Color.PaleGreen;
            booking.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            Rooms roo = new Rooms();
            roo.Owner = this;
            roo.TopLevel = false;
            roo.TopMost = true;
            roo.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(roo);
            roo.Show();
            roo.BringToFront();
            newuipanel.Update();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            Services.BackColor = Color.PaleGreen;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            Services1 sc = new Services1();
            sc.Owner = this;
            sc.TopLevel = false;
            sc.TopMost = true;
            sc.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(sc);
            sc.Show();
            sc.BringToFront();
            newuipanel.Update();
        }

        private void guests_Click_1(object sender, EventArgs e)
        {
            guests.BackColor = Color.PaleGreen;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            Guestform gf = new Guestform();
            gf.Owner = this;
            gf.TopLevel = false;
            gf.TopMost = true;
            gf.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(gf);
            gf.Show();
            gf.BringToFront();
            newuipanel.Update();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            staff.BackColor = Color.PaleGreen;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Reports.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            staffmanagement sf = new staffmanagement();
            sf.Owner = this;
            sf.TopLevel = false;
            sf.TopMost = true;
            sf.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(sf);
            sf.Show();
            sf.BringToFront();
            newuipanel.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports.BackColor = Color.PaleGreen;
            staff.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            Daily_occup_rep dor = new Daily_occup_rep();
            dor.Owner = this;
            dor.TopLevel = false;
            dor.TopMost = true;
            dor.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(dor);
            dor.Show();
            dor.BringToFront();
            newuipanel.Update();
        }

        private void Database_Click(object sender, EventArgs e)
        {
            Reports.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.PaleGreen;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
            newuipanel.Controls.Clear();
            backupdatabase bbd = new backupdatabase();
            bbd.Owner = this;
            bbd.TopLevel = false;
            bbd.TopMost = true;
            bbd.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(bbd);
            bbd.Show();
            bbd.BringToFront();
            newuipanel.Update();
        }


        private void account_Click(object sender, EventArgs e)
        {
            newuipanel.Controls.Clear();
            accounts acc = new accounts();
            acc.Owner = this;
            acc.TopLevel = false;
            acc.TopMost = true;
            acc.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(acc);
            acc.Show();
            acc.BringToFront();
            newuipanel.Update();
            Reports.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.PaleGreen;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.WhiteSmoke;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Reports.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.PaleGreen;
            settings.BackColor = Color.WhiteSmoke;
            Application.Restart();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Reports.BackColor = Color.WhiteSmoke;
            staff.BackColor = Color.WhiteSmoke;
            guests.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Room.BackColor = Color.WhiteSmoke;
            dashboard.BackColor = Color.WhiteSmoke;
            booking.BackColor = Color.WhiteSmoke;
            Services.BackColor = Color.WhiteSmoke;
            Database.BackColor = Color.WhiteSmoke;
            account.BackColor = Color.WhiteSmoke;
            logout.BackColor = Color.WhiteSmoke;
            settings.BackColor = Color.PaleGreen;
            newuipanel.Controls.Clear();
            setting st = new setting();
            st.Owner = this;
            st.TopLevel = false;
            st.TopMost = true;
            st.Dock = DockStyle.Fill;
            this.newuipanel.Controls.Add(st );
            st.Show();
            st.BringToFront();
            newuipanel.Update();
        }
        public void Alert(string msg, FormAlertYellow.enmType type)
        {
            FormAlertYellow frt = new FormAlertYellow();
            frt.showAlert(msg, type);
        }
    }
}

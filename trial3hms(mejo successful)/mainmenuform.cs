using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication1
{
    public partial class mainmenuform : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable datatable2 = new DataTable();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        DataTable datatable3 = new DataTable();
        SqlDataAdapter adapter3 = new SqlDataAdapter();
        DataSet ds3 = new DataSet();
        DataTable datatable4 = new DataTable();
        SqlDataAdapter adapter4 = new SqlDataAdapter();
        DataSet ds4 = new DataSet();
        DataTable datatable5 = new DataTable();
        SqlDataAdapter adapter5 = new SqlDataAdapter();
        DataSet ds5 = new DataSet();    
        DataTable datatable6 = new DataTable();
        SqlDataAdapter adapter6 = new SqlDataAdapter();
        DataSet ds6 = new DataSet();
        DataTable datatable7 = new DataTable();
        SqlDataAdapter adapter7 = new SqlDataAdapter();
        DataSet ds7 = new DataSet();
        string allowstatus;
        public mainmenuform()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString();
            timer1.Start();
        }
        private void mainmenuform_Load(object sender, EventArgs e)
        {
                choices2.Text = "Select Guest Status";
                choices111.Text = "Select CI/CO";
            panel13.Anchor = AnchorStyles.None;
            panel13.Location =
                new Point(ClientSize.Width / 2 - panel13.Size.Width / 2,
                 ClientSize.Height / 2 - panel13.Size.Height / 2);
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name ='N/A'", conn);
                reader = cmd.ExecuteReader();
                int countroomorbed = 0;
                while (reader.Read())
                {
                    countroomorbed++;
                }
                roomavishort.Text = countroomorbed.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Checked in'", conn);
                reader = cmd.ExecuteReader();
                int countcheckedin = 0;
                while (reader.Read())
                {
                    countcheckedin++;
                }
                checkinshort.Text = countcheckedin.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Reserved'", conn);
                reader = cmd.ExecuteReader();
                int countreservation = 0;
                while (reader.Read())
                {
                    countreservation++;
                }
                Reservationshort.Text = countreservation.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Checked out'", conn);
                reader = cmd.ExecuteReader();
                int countcheckedout = 0;
                while (reader.Read())
                {
                    countcheckedout++;
                }
                checkoutshort.Text = countcheckedout.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT AllowCheckOutStatus FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())   
                {
                    allowstatus = (reader["AllowCheckOutStatus"].ToString());
                }
                conn.Close();
                if (allowstatus == "True")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE NOT Status='Checked out'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                servicesdata.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                paymentsdata.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable4.Clear();
                ds4.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomrate", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                roomratesdisplay.DataSource = datatable4;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                dailyoccup2tb.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try 
            { 
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT Guest_Name, Status, DATEDIFF(day,Check_in,Check_Out) AS Days_Before_CheckOut FROM hm.reservation WHERE NOT Status = 'Checked out'", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                deadlinenotif2tb.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Notes1.Text = (reader["Notes"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable7.Clear();
                ds7.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                adapter7.SelectCommand = cmd;
                adapter7.Fill(datatable7);
                noteslistdg.DataSource = datatable7;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            panel9.Controls.Clear();
            Guestform gf = new Guestform();
            gf.Owner = this;
            gf.TopLevel = false;
            gf.TopMost = true;
            this.panel9.Controls.Add(gf);
            gf.Show();
            gf.BringToFront();
            panel9.Update();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            panel9.Controls.Clear();
            Rooms roo = new Rooms();
            roo.Owner = this;
            roo.TopLevel = false;
            roo.TopMost = true;
            this.panel9.Controls.Add(roo);
            roo.Show();
            roo.BringToFront();
            panel9.Update();

        }
        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            panel9.Controls.Clear();
            Services1 sc = new Services1();
            sc.Owner=this;
            sc.TopLevel = false;
            sc.TopMost = true;
            this.panel9.Controls.Add(sc);
            sc.Show();
            sc.BringToFront();
            panel9.Update();
        }
        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            panel9.Controls.Clear();
            staffmanagement sf = new staffmanagement();
            sf.Owner = this;
            sf.TopLevel = false;
            sf.TopMost = true;
            this.panel9.Controls.Add(sf);
            sf.Show();
            sf.BringToFront();
            panel9.Update();
        }
        private void toolStripButton39_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Daily_occup_rep dor = new Daily_occup_rep();
            dor.TopLevel = false;
            dor.TopMost = true;
            this.panel10.Controls.Add(dor);
            dor.Show();
            dor.BringToFront();

        }
        private void toolStripButton40_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton30_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton28_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton29_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Addreservation ci = new Addreservation();
            ci.Owner = this;
            ci.checker = "main menu";
            ci.ShowDialog();
            ci.BringToFront();
        }
        private void toolStripButton24_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton26_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton25_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_reservation ure = new update_reservation();
            ure.ShowDialog();

        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allowstatus = (reader["AllowCheckOutStatus"].ToString());
                }
                conn.Close();
                if (allowstatus == "True") { 
                
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE NOT Status='Checked out'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                servicesdata.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                paymentsdata.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try 
            { 
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT Guest_Name, Status, DATEDIFF(day,Check_in, Check_Out) AS Days_Before_CheckOut FROM hm.reservation WHERE NOT Status = 'Checked out'", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                deadlinenotif2tb.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delete_reservation dre = new delete_reservation();
            dre.ShowDialog();
        }
        private void mainmenuform_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic mboxResult = MessageBox.Show("          Are you sure you want to exit?", "                            Warning", MessageBoxButtons.YesNo);
                if (mboxResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else if (mboxResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Code=hm.reservation.Room WHERE hm.reservation.Check_in ='" + dateofcheckin2tb.Text + "'", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                dailyoccup2tb.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Code=hm.reservation.Room", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                dailyoccup2tb.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void reservation_Click(object sender, EventArgs e)
        {
            panel9.Controls.Clear();
            Reservation rr = new Reservation();
            rr.Owner = this;
            rr.TopLevel = false;
            rr.TopMost = true;
            this.panel9.Controls.Add(rr);
            rr.Show();
            rr.BringToFront();
            panel9.Update();
        }
        private void toolStripButton32_Click(object sender, EventArgs e)
        {
            paneldata.Controls.Clear();
            backupdatabase bb = new backupdatabase();
            bb.TopLevel = false;
            bb.TopMost = true;
            this.paneldata.Controls.Add(bb);
            bb.Show();
            bb.BringToFront();
            paneldata.Update();
        }
        private void toolStripButton27_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            paneldata.Controls.Clear();
            Restoredatabase rd = new Restoredatabase();
            rd.TopLevel = false;
            rd.TopMost = true;
            this.paneldata.Controls.Add(rd);
            rd.Show();
            rd.BringToFront();
            paneldata.Update();
        }
        private void choices2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='" + choices2.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return; 
            }
        }

        private void to2tb_CloseUp(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='" + choices2.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void choices2_SelectedValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='" + choices2.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (choices111.Equals("Check in from"))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name='" + guestname2tb.Text + "' AND Room ='" + roomno2tb.Text + "' AND Check_in between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name='" + guestname2tb.Text + "' AND Room='" + roomno2tb.Text + "' AND Check_Out between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata.DataSource = datatable;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void to2tb_CloseUp_1(object sender, EventArgs e)
        {
            if (choices111.Equals("Check in from"))
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Check_in between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdata.DataSource = datatable;
                conn.Close();
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Check_Out between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdata.DataSource = datatable;
                conn.Close();
            }
        }
        private void roomno2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void mainmenuform_Shown(object sender, EventArgs e)
        {
         
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["database"])
            {
                paneldata.Controls.Clear();
                backupdatabase bb = new backupdatabase();
                bb.TopLevel = false;
                bb.TopMost = true;
                this.paneldata.Controls.Add(bb);
                bb.Show();
                bb.BringToFront();
                paneldata.Update();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["help"])
            {
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["reports"])
            {
                panel10.Controls.Clear();
                Daily_occup_rep dor = new Daily_occup_rep();
                dor.TopLevel = false;
                dor.TopMost = true;
                this.panel10.Controls.Add(dor);
                dor.Show();
                dor.BringToFront();
                panel10.Update();
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["highlights"])
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name ='N/A'", conn);
                    reader = cmd.ExecuteReader();
                    int countroomorbed = 0;
                    while (reader.Read())
                    {
                        countroomorbed++;
                    }
                    roomavishort.Text = countroomorbed.ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Checked in'", conn);
                    reader = cmd.ExecuteReader();
                    int countcheckedin = 0;
                    while (reader.Read())
                    {
                        countcheckedin++;
                    }
                    checkinshort.Text = countcheckedin.ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Reserved'", conn);
                    reader = cmd.ExecuteReader();
                    int countreservation = 0;
                    while (reader.Read())
                    {
                        countreservation++;
                    }
                    Reservationshort.Text = countreservation.ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status ='Checked out'", conn);
                    reader = cmd.ExecuteReader();
                    int countcheckedout = 0;
                    while (reader.Read())
                    {
                        countcheckedout++;
                    }
                    checkoutshort.Text = countcheckedout.ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
            }

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
        }
        private void mainmenuform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnote_Click(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes (Notes,date,time,[User]) VALUES ('" + Notes1.Text + "','" + datenote + "','" + datetimenote + "','" + usernameee.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable7.Clear();
                ds7.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                adapter7.SelectCommand = cmd;
                adapter7.Fill(datatable7);
                noteslistdg.DataSource = datatable7;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernameee_TextChanged(object sender, EventArgs e)
        {
            id2.Text = usernameee.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dailyoccup2tb.RowCount - 1; i++)
            {
                for (j = 0; j <= dailyoccup2tb.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dailyoccup2tb[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
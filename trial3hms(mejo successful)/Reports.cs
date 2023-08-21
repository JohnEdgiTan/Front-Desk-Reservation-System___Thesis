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
using Microsoft.Reporting.WinForms;
using ClosedXML.Excel;


namespace WindowsFormsApplication1
{
    public partial class Daily_occup_rep : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
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
        SqlDataReader reader;
        int counterd;
        string queryString;
        int counters;
        public Daily_occup_rep()
        {
            InitializeComponent();
        }
        private void Daily_occup_rep_Load(object sender, EventArgs e)
        {
            textBox1.Text = (this.Owner as reservationmenu).label2.Text;
            dailyoccupbt.BackColor = Color.PaleGreen;
            reservationgb.Visible = false;
            reservationgb.Dock = DockStyle.None;
            servicereportgb.Visible = false;
            servicereportgb.Dock = DockStyle.None;
            guestgb.Visible = false;
            guestgb.Dock = DockStyle.None;
            roomreportgb.Visible = false;
            roomreportgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = true;
            dailyoccupgb.Dock = DockStyle.Bottom;
            label2.Text = "No Opened Report";
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reportsdt.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE hm.reservation.Check_in ='" + dateofcheckintbdaily.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reportsdt.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reportsdt.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void arrowdown_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }
        private void dailyoccupbt_Click(object sender, EventArgs e)
        {
            dailyoccupbt.BackColor = Color.PaleGreen;
            reservationreportsbt.BackColor = Color.MediumAquamarine;
            servicereportsbt.BackColor = Color.MediumAquamarine;
            guestreportsbt.BackColor = Color.MediumAquamarine;
            roomreportsbt.BackColor = Color.MediumAquamarine;
            reservationgb.Visible = false;
            reservationgb.Dock = DockStyle.None;
            servicereportgb.Visible = false;
            servicereportgb.Dock = DockStyle.None; 
            guestgb.Visible = false;
            guestgb.Dock = DockStyle.None;
            roomreportgb.Visible = false;
            roomreportgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = true;
            dailyoccupgb.Dock = DockStyle.Bottom;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reportsdt.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void guestreportsbt_Click(object sender, EventArgs e)
        {
            dailyoccupbt.BackColor = Color.MediumAquamarine;
            reservationreportsbt.BackColor = Color.MediumAquamarine;
            servicereportsbt.BackColor = Color.MediumAquamarine;
            guestreportsbt.BackColor = Color.PaleGreen;
            roomreportsbt.BackColor = Color.MediumAquamarine;
            reservationgb.Visible = false;
            reservationgb.Dock = DockStyle.None;
            servicereportgb.Visible = false;
            servicereportgb.Dock = DockStyle.None;
            roomreportgb.Visible = false;
            roomreportgb.Dock = DockStyle.None;
            dailyoccupgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = false;
            guestgb.Visible = true;
            guestgb.Dock = DockStyle.Bottom;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                reportsdt.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomreportsbt_Click_1(object sender, EventArgs e)
        {
            dailyoccupbt.BackColor = Color.MediumAquamarine;
            reservationreportsbt.BackColor = Color.MediumAquamarine;
            servicereportsbt.BackColor = Color.MediumAquamarine;
            guestreportsbt.BackColor = Color.MediumAquamarine;
            roomreportsbt.BackColor = Color.PaleGreen;
            reservationgb.Visible = false;
            reservationgb.Dock = DockStyle.None;
            servicereportgb.Visible = false;
            servicereportgb.Dock = DockStyle.None;
            guestgb.Visible = false;
            guestgb.Dock = DockStyle.None;
            dailyoccupgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = false;

            roomreportgb.Visible = true;
            roomreportgb.Dock = DockStyle.Bottom;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                reportsdt.DataSource = datatable3;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(from3tb.Text);
                DateTime todate = Convert.ToDateTime(to3tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void reservationreportbt_Click(object sender, EventArgs e)
        {
            dailyoccupbt.BackColor = Color.MediumAquamarine;
            reservationreportsbt.BackColor = Color.PaleGreen;
            servicereportsbt.BackColor = Color.MediumAquamarine;
            guestreportsbt.BackColor = Color.MediumAquamarine;
            roomreportsbt.BackColor = Color.MediumAquamarine;
            servicereportgb.Visible = false;
            servicereportgb.Dock = DockStyle.None;
            guestgb.Visible = false;
            guestgb.Dock = DockStyle.None;
            roomreportgb.Visible = false;
            roomreportgb.Dock = DockStyle.None;
            dailyoccupgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = false;
            reservationgb.Visible = true;
            reservationgb.Dock = DockStyle.Bottom;
            try
            {
                choices1reserv.SelectedIndex = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable4.Clear();
                ds4.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                reportsdt.DataSource = datatable4;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(fromtbrr.Text);
                DateTime todate = Convert.ToDateTime(totbrr.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

        }

        private void servicereportsbt_Click(object sender, EventArgs e)
        {
            dailyoccupbt.BackColor = Color.MediumAquamarine;
            reservationreportsbt.BackColor = Color.MediumAquamarine;
            servicereportsbt.BackColor = Color.PaleGreen;
            guestreportsbt.BackColor = Color.MediumAquamarine;
            roomreportsbt.BackColor = Color.MediumAquamarine;
            reservationgb.Visible = false;
            reservationgb.Dock = DockStyle.None;
            guestgb.Visible = false;
            guestgb.Dock = DockStyle.None;
            dailyoccupgb.Dock = DockStyle.None;
            dailyoccupgb.Visible = false;
            roomreportgb.Visible = false;
            roomreportgb.Dock = DockStyle.None;
            servicereportgb.Visible = true;
            servicereportgb.Dock = DockStyle.Bottom;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT Service_Name,Type,Quantity,Subtotal,Date_Recorded FROM hm.services", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                reportsdt.DataSource = datatable2;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(from5tb.Text);
                DateTime todate = Convert.ToDateTime(to5tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

        }

        private void arrowdown2_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowdown3_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowdown4_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup2_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void arrowup3_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void arrowup4_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void arrowup_Click_1(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reportpanel.Controls.Clear();
            DailyReport sf = new DailyReport();
            sf.Owner = this;
            sf.TopLevel = false;
            sf.TopMost = true;
            sf.Dock = DockStyle.Fill;
            this.reportpanel.Controls.Add(sf);
            sf.Show();
        }

        private void arrowdown5_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup5_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT Service_Name,Type,Quantity,Subtotal,Date_Recorded FROM hm.services WHERE Date_Recorded between '" + from5tb.Text + "' AND '" + to5tb.Text + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                reportsdt.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void refreshservice_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT Service_Name,Type,Quantity,Subtotal,Date_Recorded FROM hm.services", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                reportsdt.DataSource = datatable2;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(from5tb.Text);
                DateTime todate = Convert.ToDateTime(to5tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void displayservicereport_Click(object sender, EventArgs e)
        {
            reportpanel.Controls.Clear();
            servicereport spr = new servicereport();
            spr.Owner = this;
            spr.TopLevel = false;
            spr.TopMost = true;
            spr.Dock = DockStyle.Fill;
            this.reportpanel.Controls.Add(spr);
            spr.Show();
            spr.BringToFront();
        }

        private void roomreportrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                reportsdt.DataSource = datatable3;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(from3tb.Text);
                DateTime todate = Convert.ToDateTime(to3tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomreportsearh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE hm.roomorbed.Room_No='" + roomnotbreport.Text + "' AND Check_in between '" + from3tb.Text + "' AND '" + to3tb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                reportsdt.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomreportdisplay_Click(object sender, EventArgs e)
        {
            reportpanel.Controls.Clear();
            roomreports rprts = new roomreports();
            rprts.Owner = this;
            rprts.TopLevel = false;
            rprts.TopMost = true;
            rprts.Dock = DockStyle.Fill;
            this.reportpanel.Controls.Add(rprts);
            if (checkboxroomno.Checked == true)
            {
                if (roomnotbreport.Text == "")
                {
                    MessageBox.Show("Room No checkbox is checked but Room No is empty, either please uncheck Room No checkbox or Enter a Room No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    queryString = "SELECT hm.roomorbed.Room_No FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE hm.roomorbed.Room_No='" + roomnotbreport.Text + "'";
                    SqlCommand query;
                    query = new SqlCommand(queryString, conn);
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        counterd++;
                    }
                    conn.Close();
                    if (counterd <= 0)
                    {
                        MessageBox.Show("Room No entred is not present in any Reservation Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        rprts.Show();
                    }
                }
            }
            else
            {
                rprts.Show();
            }
        }

        private void reservationreportsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (choices1reserv.Equals("Check in"))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Guest_Name='" + guestnametbreport.Text + "' AND hm.roomorbed.Room_No='" + roomnotb.Text + "' AND Check_in between '" + fromtbrr.Text + "' AND '" + totbrr.Text + "'", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable);
                    reportsdt.DataSource = datatable4;
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Guest_Name='" + guestnametbreport.Text + "' AND hm.roomorbed.Room_No='" + roomnotb.Text + "' AND Check_Out between '" + fromtbrr.Text + "' AND '" + totbrr.Text + "'", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    reportsdt.DataSource = datatable4;
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

        private void reservationrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                choices1reserv.SelectedIndex = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable4.Clear();
                ds4.Clear();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                reportsdt.DataSource = datatable4;
                conn.Close();
                DateTime fromdate = Convert.ToDateTime(fromtbrr.Text);
                DateTime todate = Convert.ToDateTime(totbrr.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            try
            {
                reportpanel.Controls.Clear();
                Reservationreport rrr = new Reservationreport();
                rrr.Owner = this;
                rrr.TopLevel = false;
                rrr.TopMost = true;
                rrr.Dock = DockStyle.Fill;
                this.reportpanel.Controls.Add(rrr);
                if (checkboxguestname.Checked == true)
                {
                    if (guestnametbreport.Text == "")
                    {
                        MessageBox.Show("Guest is checked but Guest Name is empty, either please uncheck Guest Name or Enter a Guest Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        queryString = "SELECT Guest_Name FROM hm.reservation WHERE Guest_Name='" + guestnametbreport.Text + "'";
                        SqlCommand query;
                        query = new SqlCommand(queryString, conn);
                        reader = query.ExecuteReader();
                        while (reader.Read())
                        {
                            counters++;
                        }
                        conn.Close();
                        if (counters <= 0)
                        {
                            MessageBox.Show("Entered Guest Name is not present in any Reservation Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            rrr.Show();
                        }

                    }

                }
                else
                {
                    rrr.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void guestsreportsearh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + from4tb.Text + "' AND '" + to4tb.Text + "'", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                reportsdt.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void guestreportrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                reportsdt.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void displayguestsreport_Click(object sender, EventArgs e)
        {
            reportpanel.Controls.Clear();
            guestsreport grt = new guestsreport();
            grt.Owner = this;
            grt.TopLevel = false;
            grt.TopMost = true;
            grt.Dock = DockStyle.Fill;
            this.reportpanel.Controls.Add(grt);
            grt.Show();

        }

        private void roomnotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestnametbreport_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }

}

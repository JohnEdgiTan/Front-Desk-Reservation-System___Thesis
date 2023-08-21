using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class dashboard : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
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
        DataTable datatable8 = new DataTable();
        SqlDataAdapter adapter8 = new SqlDataAdapter();
        DataSet ds8 = new DataSet();
        DataTable datatable9 = new DataTable();
        SqlDataAdapter adapter9 = new SqlDataAdapter();
        DataSet ds9 = new DataSet();
        DataTable datatable10 = new DataTable();
        SqlDataAdapter adapter10 = new SqlDataAdapter();
        DataSet ds10 = new DataSet();
        DataTable datatable11 = new DataTable();
        SqlDataAdapter adapter11 = new SqlDataAdapter();
        DataSet ds11 = new DataSet();
        DataTable datatable12 = new DataTable();
        SqlDataAdapter adapter12 = new SqlDataAdapter();
        DataSet ds12 = new DataSet();


        string queryString;
        string checkid;
        int countcheckrooms = 0;
        public dashboard()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

            counterpanel.Anchor = AnchorStyles.None;
            counterpanel.Location =
                new Point(ClientSize.Width / 2 - counterpanel.Size.Width / 2
                );
            try
            {
                conn.Open();
                cmd.Connection = conn;
                queryString = "SELECT User_Name,Password FROM hm.users WHERE User_Name = '" + (this.Owner as reservationmenu).label2.Text + "'";
                SqlCommand query;
                query = new SqlCommand(queryString, conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    checkid = reader["User_Name"].ToString();
                }
                conn.Close();
                label6.Text = "Welcome, " + checkid +"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Reserved'", conn);
                reader = cmd.ExecuteReader();
                int countreserved = 0;
                while (reader.Read())
                {
                    countreserved++;
                }
                conn.Close();
                label1.Text = countreserved.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked in'", conn);
                reader = cmd.ExecuteReader();
                int countcheckedin = 0;
                while (reader.Read())
                {
                    countcheckedin++;
                }
                conn.Close();
                label3.Text = countcheckedin.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked Out'", conn);
                reader = cmd.ExecuteReader();
                int countcheckedout = 0;
                while (reader.Read())
                {
                    countcheckedout++;
                }
                conn.Close();
                label5.Text = countcheckedout.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Reserved-Cancelled'", conn);
                reader = cmd.ExecuteReader();
                int countcheckrescancel = 0;
                while (reader.Read())
                {
                    countcheckrescancel++;
                }
                conn.Close();
                label9.Text = countcheckrescancel.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    countcheckrooms++;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name='N/A'", conn);
                reader = cmd.ExecuteReader();
                int countcheckavail = 0;
                while (reader.Read())
                {
                    countcheckavail++;
                }
                conn.Close();
                label11.Text = countcheckavail.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='Vacant Ready'", conn);
                reader = cmd.ExecuteReader();
                int countcheckvr = 0;
                while (reader.Read())
                {
                    countcheckvr++;
                }
                conn.Close();
                vacantreadybt.Text = countcheckvr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='Vacant Clean'", conn);
                reader = cmd.ExecuteReader();
                int countcheckvc = 0;
                while (reader.Read())
                {
                    countcheckvc++;
                }
                conn.Close();
                vacantcleanbt.Text = countcheckvc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='Vacant Dirty'", conn);
                reader = cmd.ExecuteReader();
                int countcheckvd = 0;
                while (reader.Read())
                {
                    countcheckvd++;
                }
                conn.Close();
                vacantdirtybt.Text = countcheckvd.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='Out of Order'", conn);
                reader = cmd.ExecuteReader();
                int countcheckooo = 0;
                while (reader.Read())
                {
                    countcheckooo++;
                }
                conn.Close();
                outoforderbt.Text = countcheckooo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationdatadash.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                roomdatadash.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            for (int i = 1; i <=roomdatadash.Rows.Count;i++)
            {
                Button b = new Button();
                b.Text = Convert.ToString(roomdatadash.Rows[i-1].Cells[2].Value);
                b.Name = Convert.ToString(roomdatadash.Rows[i-1].Cells[2].Value);
                b.Height = 50;
                b.FlatStyle=FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 3;
                b.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
                b.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
                b.Location = new Point(3, 3);
                for (int x = 1; x <= reservationdatadash.Rows.Count;x++)
                {
                    if((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value)=="Vacant Clean"))                    
                    {
                        b.FlatAppearance.BorderColor = Color.DodgerBlue;
                    }
                    else if ((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value) == "Vacant Dirty"))
                    {
                        b.FlatAppearance.BorderColor = Color.Crimson;
                    }
                    else if ((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value) == "Vacant Ready"))
                    {
                        b.FlatAppearance.BorderColor = Color.LawnGreen;
                    }
                    else
                    {
                        b.FlatAppearance.BorderColor = Color.Black;
                    }
                        if (Convert.ToString(roomdatadash.Rows[i - 1].Cells[1].Value) == "N/A")
                    {
                        b.BackColor = Color.White;
                    }
                    else
                    {
                        if (b.Text == (Convert.ToString(reservationdatadash.Rows[x - 1].Cells[2].Value)))
                        {
                            if ((Convert.ToString(reservationdatadash.Rows[x - 1].Cells[1].Value)) == "Checked in")
                            {
                                b.BackColor = Color.SpringGreen;
                            }
                            else if ((Convert.ToString(reservationdatadash.Rows[x - 1].Cells[1].Value)) == "Reserved")
                            {
                                b.BackColor = Color.Yellow;
                            }
                            else
                            {
                                b.BackColor = Color.Orange;
                            }
                        }
                    }
                }
                if (b.Text == "")
                {
                    flowLayoutPanel1.Controls.Remove(b);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(b);
                }
                


            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customsearch.Text == "Room Availability Range")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in,Check_Out FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE NOT Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND NOT Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND hm.roomorbed.Room_No='"+dbname.Text+"' ", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    customsearchdg.DataSource = datatable3;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Room Only")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_No='"+dbname.Text+"'", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    customsearchdg.DataSource = datatable4;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable5.Clear();
                    ds5.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests WHERE Name='"+dbname.Text+"'", conn);
                    adapter5.SelectCommand = cmd;
                    adapter5.Fill(datatable5);
                    customsearchdg.DataSource = datatable5;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check In Range")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable6.Clear();
                    ds6.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND Guest_Name='"+dbname.Text+"'", conn);
                    adapter6.SelectCommand = cmd;
                    adapter6.Fill(datatable6);
                    customsearchdg.DataSource = datatable6;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check Out Range")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable7.Clear();
                    ds7.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND Guest_Name='"+dbname.Text+"'", conn);
                    adapter7.SelectCommand = cmd;
                    adapter7.Fill(datatable7);
                    customsearchdg.DataSource = datatable7;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Reservation of guest")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable8.Clear();
                    ds8.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name='" + dbname.Text + "'", conn);
                    adapter8.SelectCommand = cmd;
                    adapter8.Fill(datatable8);
                    customsearchdg.DataSource = datatable8;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Checked in Guest")
            {
                conn.Open();
                cmd.Connection = conn;
                datatable9.Clear();
                ds9.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked in' AND Guest_Name='"+dbname.Text+"'", conn);
                adapter9.SelectCommand = cmd;
                adapter9.Fill(datatable9);
                customsearchdg.DataSource = datatable9;
                conn.Close();
            }
            else if (customsearch.Text == "Checked out Guest")
            {
                conn.Open();
                cmd.Connection = conn;
                datatable10.Clear();
                ds10.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked out' AND Guest_Name='" + dbname.Text + "'", conn);
                adapter10.SelectCommand = cmd;
                adapter10.Fill(datatable10);
                customsearchdg.DataSource = datatable10;
                conn.Close();
            }
            else if (customsearch.Text == "Room Type Availability")
            {
                conn.Open();
                cmd.Connection = conn;
                datatable11.Clear();
                ds11.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name='N/A' AND Room_No='"+dbname.Text+"'", conn);
                adapter11.SelectCommand = cmd;
                adapter11.Fill(datatable11);
                customsearchdg.DataSource = datatable11;
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if(customsearch.Text == "Room Availability Range")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in,Check_Out FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE NOT Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND NOT Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    customsearchdg.DataSource = datatable3;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text =="Room Only")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    customsearchdg.DataSource = datatable4;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text == "Guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable5.Clear();
                    ds5.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                    adapter5.SelectCommand = cmd;
                    adapter5.Fill(datatable5);
                    customsearchdg.DataSource = datatable5;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text == "Guest Check In Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable6.Clear();
                    ds6.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter6.SelectCommand = cmd;
                    adapter6.Fill(datatable6);
                    customsearchdg.DataSource = datatable6;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text == "Guest Check Out Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable7.Clear();
                    ds7.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter7.SelectCommand = cmd;
                    adapter7.Fill(datatable7);
                    customsearchdg.DataSource = datatable7;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text=="Reservation of guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable8.Clear();
                    ds8.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter8.SelectCommand = cmd;
                    adapter8.Fill(datatable8);
                    customsearchdg.DataSource = datatable8;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if(customsearch.Text =="Checked in Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable9.Clear();
                ds9.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked in'", conn);
                adapter9.SelectCommand = cmd;
                adapter9.Fill(datatable9);
                customsearchdg.DataSource = datatable9;
                conn.Close();
            }
            else if(customsearch.Text =="Checked out Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable10.Clear();
                ds10.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked out'", conn);
                adapter10.SelectCommand = cmd;
                adapter10.Fill(datatable10);
                customsearchdg.DataSource = datatable10;
                conn.Close();
            }
            else if(customsearch.Text =="Room Type Availability")
            {
                searchtext.Text = "Enter Room No";
                conn.Open();
                cmd.Connection = conn;
                datatable11.Clear();
                ds11.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name='N/A'", conn);
                adapter11.SelectCommand = cmd;
                adapter11.Fill(datatable11);
                customsearchdg.DataSource = datatable11;
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void dashboard_MinimumSizeChanged(object sender, EventArgs e)
        {
        }

        private void dashboard_MaximizedBoundsChanged(object sender, EventArgs e)
        {
        }

        private void dbfrom_CloseUp(object sender, EventArgs e)
        {
            
            if (customsearch.Text == "Room Availability Range")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in,Check_Out FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE NOT Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND NOT Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    customsearchdg.DataSource = datatable3;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Room Only")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    customsearchdg.DataSource = datatable4;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable5.Clear();
                    ds5.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                    adapter5.SelectCommand = cmd;
                    adapter5.Fill(datatable5);
                    customsearchdg.DataSource = datatable5;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check In Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable6.Clear();
                    ds6.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter6.SelectCommand = cmd;
                    adapter6.Fill(datatable6);
                    customsearchdg.DataSource = datatable6;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check Out Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable7.Clear();
                    ds7.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter7.SelectCommand = cmd;
                    adapter7.Fill(datatable7);
                    customsearchdg.DataSource = datatable7;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Reservation of guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable8.Clear();
                    ds8.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter8.SelectCommand = cmd;
                    adapter8.Fill(datatable8);
                    customsearchdg.DataSource = datatable8;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Checked in Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable9.Clear();
                ds9.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked in'", conn);
                adapter9.SelectCommand = cmd;
                adapter9.Fill(datatable9);
                customsearchdg.DataSource = datatable9;
                conn.Close();
            }
            else if (customsearch.Text == "Checked out Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable10.Clear();
                ds10.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked out'", conn);
                adapter10.SelectCommand = cmd;
                adapter10.Fill(datatable10);
                customsearchdg.DataSource = datatable10;
                conn.Close();
            }
            else if (customsearch.Text == "Room Type Availability")
            {
                searchtext.Text = "Enter Room No";
                conn.Open();
                cmd.Connection = conn;
                datatable11.Clear();
                ds11.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name='N/A'", conn);
                adapter11.SelectCommand = cmd;
                adapter11.Fill(datatable11);
                customsearchdg.DataSource = datatable11;
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void dbto_CloseUp(object sender, EventArgs e)
        {
            
            if (customsearch.Text == "Room Availability Range")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in,Check_Out FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE NOT Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "' AND NOT Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    customsearchdg.DataSource = datatable3;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Room Only")
            {
                searchtext.Text = "Enter Room No";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    customsearchdg.DataSource = datatable4;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable5.Clear();
                    ds5.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                    adapter5.SelectCommand = cmd;
                    adapter5.Fill(datatable5);
                    customsearchdg.DataSource = datatable5;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check In Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable6.Clear();
                    ds6.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter6.SelectCommand = cmd;
                    adapter6.Fill(datatable6);
                    customsearchdg.DataSource = datatable6;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Guest Check Out Range")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable7.Clear();
                    ds7.Clear();
                    cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Check_Out,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_Out between '" + dbfrom.Text + "' AND '" + dbto.Text + "'", conn);
                    adapter7.SelectCommand = cmd;
                    adapter7.Fill(datatable7);
                    customsearchdg.DataSource = datatable7;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Reservation of guest")
            {
                searchtext.Text = "Enter Guest Name";
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable8.Clear();
                    ds8.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter8.SelectCommand = cmd;
                    adapter8.Fill(datatable8);
                    customsearchdg.DataSource = datatable8;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else if (customsearch.Text == "Checked in Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable9.Clear();
                ds9.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked in'", conn);
                adapter9.SelectCommand = cmd;
                adapter9.Fill(datatable9);
                customsearchdg.DataSource = datatable9;
                conn.Close();
            }
            else if (customsearch.Text == "Checked out Guest")
            {
                searchtext.Text = "Enter Guest Name";
                conn.Open();
                cmd.Connection = conn;
                datatable10.Clear();
                ds10.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Status='Checked out'", conn);
                adapter10.SelectCommand = cmd;
                adapter10.Fill(datatable10);
                customsearchdg.DataSource = datatable10;
                conn.Close();
            }
            else if (customsearch.Text == "Room Type Availability")
            {
                searchtext.Text = "Enter Room No";
                conn.Open();
                cmd.Connection = conn;
                datatable11.Clear();
                ds11.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Name='N/A'", conn);
                adapter11.SelectCommand = cmd;
                adapter11.Fill(datatable11);
                customsearchdg.DataSource = datatable11;
                conn.Close();
            }
            else
            {
                return;
            }
        }
    }
}

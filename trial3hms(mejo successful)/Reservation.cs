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

namespace WindowsFormsApplication1
{
    public partial class Reservation : Form
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
        string allowstatus;
        public Reservation()
        {
            InitializeComponent();

        }
        private void Reservation_Load(object sender, EventArgs e)
        {
            if((this.Owner as reservationmenu).label3.Text == "User")
            {
                actioncb.Items.Add("Add");
                actioncb.Items.Add("Edit");
                actioncb.Items.Add("Refresh");
            }
            else
            {
                actioncb.Items.Add("Add");
                actioncb.Items.Add("Edit");
                actioncb.Items.Add("Delete");
                actioncb.Items.Add("Refresh");
            }
            arrowup.Visible = false;
            choices2.Text = "Select Guest Status";

            mainmenuform mm = new mainmenuform();
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
                if (allowstatus == "True")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
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
                    reservationdata3.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Notes2.Text = (reader["Notes"].ToString());
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
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                noteslistdg.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (choices2.Equals("Check in"))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name='" + guestname2tb.Text + "' AND Check_in between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
                    conn.Close();
                }
                else         
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name='" + guestname2tb.Text + "' AND Check_Out between '" + from2tb.Text + "' AND '" + to2tb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                conn.Close();
            }
        }

        private void to2tb_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (choices2.Equals("Check in from"))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Check_in between '" + from2tb.Text + "' AND '"+to2tb.Text+"'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
                    conn.Close();
                }
                else 
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Check_Out between '" + from2tb.Text + "' and '" + to2tb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
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
                reservationdata3.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void roomno2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notessection.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void btnote_Click_1(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            string userinforeservation = (this.Owner as mainmenuform).usernameee.Text;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes (Notes,date,time,[User]) VALUES ('" + Notes2.Text + "','" + datenote + "','" + datetimenote + "','" + userinforeservation + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                noteslistdg.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrowup_Click(object sender, EventArgs e)
        {
            notessection.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }
        private void actioncb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (actioncb.Text == "Add")
            {
                Addreservation ci = new Addreservation();
                ci.Owner = this;
                ci.checker = "reservation";
                label5.Text = (this.Owner as reservationmenu).label2.Text;
                ci.Show();
            }
            else if (actioncb.Text == "Edit")
            {
                update_reservation ure = new update_reservation();
                ure.ShowDialog();
                ure.BringToFront();
            }
            else if (actioncb.Text == "Delete")
            {
                delete_reservation dre = new delete_reservation();
                dre.ShowDialog();
                dre.BringToFront();
            }
            else if (actioncb.Text == "Refresh")
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
                    if (allowstatus == "True")
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationdata3.DataSource = datatable;
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
                        reservationdata3.DataSource = datatable;
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
            else
            {
                return;
            }
        }

        private void btnote_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void actioncb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservationdata2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < reservationdata3.Rows.Count; ++i)
            {
                if (Convert.ToString(reservationdata3.Rows[i].Cells[1].Value) == "Checked in"){
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
                else if(Convert.ToString(reservationdata3.Rows[i].Cells[1].Value) == "Reserved")
                {
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < reservationdata3.Rows.Count; ++i)
            {
                if (Convert.ToString(reservationdata3.Rows[i].Cells[1].Value) == "Checked in")
                {
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
                else if (Convert.ToString(reservationdata3.Rows[i].Cells[1].Value) == "Reserved")
                {
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    reservationdata3.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
        private void secretrefresh_Click_1(object sender, EventArgs e)
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
                if (allowstatus == "True")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationdata3.DataSource = datatable;
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
                    reservationdata3.DataSource = datatable;
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
    }
}

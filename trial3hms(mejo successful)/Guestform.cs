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
    public partial class Guestform : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader reader;
        DataTable datatable2 = new DataTable();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        public Guestform()
        {
            InitializeComponent();
        }
        private void Guestform_Load(object sender, EventArgs e)
        {
            if ((this.Owner as reservationmenu).label3.Text == "User")
            {
                actioncb.Items.Add("Add");
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
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                guestsdata.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes2", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notes3.Text = (reader["Notes2"].ToString());
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
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes2", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg2.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd = new SqlCommand("SELECT * from hm.guests WHERE Name = '" + namesearchtb.Text + "' AND Email = '" + emailsearchtb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                guestsdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                guestsdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void btnote_Click(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            string userinfoguests = (this.Owner as mainmenuform).usernameee.Text;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes2 (Notes2,date2,time2,[User2]) VALUES ('" + notes3.Text + "','" + datenote + "','" + datetimenote + "','" + userinfoguests + "')"; 
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes2", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg2.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void actioncb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (actioncb.Text == "Add")
            {
                Add_Guest ag = new Add_Guest();
                ag.ShowDialog();
            }
            else if (actioncb.Text == "Edit")
            {
                upgrade_guest ugr = new upgrade_guest();
                ugr.ShowDialog();
            }
            else if (actioncb.Text == "Delete")
            {
                delete_guests dlg = new delete_guests();
                dlg.ShowDialog();
            }
            else if (actioncb.Text == "Refresh")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    guestsdata.DataSource = datatable;
                    conn.Close();
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
    }
}

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
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class staffmanagement : Form
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
        public staffmanagement()
        {
            InitializeComponent();
        }

        private void staffmanagement_Load(object sender, EventArgs e)
        {
            staffuserlevel.Text = (this.Owner as reservationmenu).label3.Text;
            arrowup.Visible = false;
            actioncb.Items.Add("Add");
            actioncb.Items.Add("Edit");
            actioncb.Items.Add("Delete");
            actioncb.Items.Add("Refresh");
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.staffman ORDER BY Staff_ID ASC", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                staffdata.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT Notes6 FROM hm.reservationnotes6", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notes7.Text = (reader["Notes6"].ToString());
                }
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
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes6", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg6.DataSource = datatable2;
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
                cmd = new SqlCommand("SELECT * from hm.staffman WHERE Name = '" + staffnametb.Text + "' AND Email= '" + staffemailtb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                staffdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Userloginhistory ulh = new Userloginhistory();
            ulh.ShowDialog();
        }
        private void btnote_Click(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            string userinfostaffman = (this.Owner as mainmenuform).usernameee.Text;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes6 (Notes6,date6,time6,[User6]) VALUES ('" + notes7.Text + "','" + datenote + "','" + datetimenote + "','" + userinfostaffman + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes6", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg6.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string Encrypt(String passwords)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(passwords));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
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
                Add_staff asa = new Add_staff();
                asa.Owner = this; 
                asa.ShowDialog();
            }
            else if (actioncb.Text == "Edit")
            {
                update_staff ust = new update_staff();
                ust.Owner = this;
                ust.ShowDialog();
            }
            else if (actioncb.Text == "Delete")
            {
                try
                {
                    DialogResult dr2 = MessageBox.Show("Proceed to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("DELETE from hm.staffman WHERE Name = '" + staffnametb.Text + "' AND Email = '" + staffemailtb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        staffdata.DataSource = datatable;
                        conn.Close();
                        MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
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
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.staffman ORDER BY Staff_ID ASC", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    staffdata.DataSource = datatable;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
            }
            else if (actioncb.Text == "Refresh")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.staffman ORDER BY Staff_ID ASC", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    staffdata.DataSource = datatable;
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

        private void actioncb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

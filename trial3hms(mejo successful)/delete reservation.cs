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
    public partial class delete_reservation : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public delete_reservation()
        {
            InitializeComponent();
        }
        private void delete_reservation_Load(object sender, EventArgs e)
        {
            try
            {
                guestnamelisttb.Text = "Select Guest Name";
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnamelisttb.Items.Add(reader["Guest_Name"].ToString());
                    guestnamelisttb.ForeColor = Color.Black;
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
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationtb.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (roomnotb.Text == "") 
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
                        cmd = new SqlCommand("DELETE from hm.reservation WHERE Guest_Name = '" + guestnamelisttb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationtb.DataSource = datatable;
                        conn.Close();
                        MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = 'N/A' WHERE Room_No ='" + roomnotb.Text + "'", conn);
                        reader = cmd.ExecuteReader();
                        conn.Close();

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
                    this.Close();
                }
            }
            else
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
                        cmd = new SqlCommand("DELETE from hm.reservation WHERE Guest_Name = '" + guestnamelisttb.Text + "' AND Room_No = '" + roomnotb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationtb.DataSource = datatable;
                        conn.Close();
                        MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = 'N/A' WHERE Room_No ='" + roomnotb.Text + "'", conn);
                        reader = cmd.ExecuteReader();
                        conn.Close();

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
                    this.Close();
                }

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
                reservationtb.DataSource = datatable;
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
            if (roomnotb.Text == "")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name= '" + guestnamelisttb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
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
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name= '" + guestnamelisttb.Text + "' AND Room='"+roomnotb.Text+"'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed to Deleting All Records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("DELETE from hm.reservation", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
                    conn.Close();
                    MessageBox.Show("Successfully Deleted All Records", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = 'N/A'", conn);
                    reader = cmd.ExecuteReader();
                    conn.Close();
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
        }

        private void guestnamelisttb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                guestnamelisttb.Items.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnamelisttb.Items.Add(reader["Guest_Name"].ToString());
                    guestnamelisttb.ForeColor = Color.Black;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void delete_reservation_Leave(object sender, EventArgs e)
        {
            (this.Owner as Reservation).secretrefresh.PerformClick();
        }
    }
}

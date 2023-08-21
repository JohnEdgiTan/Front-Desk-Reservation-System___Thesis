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
    public partial class delete_roomtype : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public delete_roomtype()
        {
            InitializeComponent();
        }

        private void delete_roomtype_Load(object sender, EventArgs e)
        {
            try
            {
                roomtypetb.Text = "Select Room Type";
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomtypetb.Items.Add(reader["Name"].ToString());
                    roomtypetb.ForeColor = Color.Black;
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
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
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
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("DELETE from hm.roomtype WHERE Name = '" + roomtypetb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
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
                    cmd = new SqlCommand("DELETE from hm.roomtype", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
                    conn.Close();
                    MessageBox.Show("Successfully Deleted All Records", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

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
    public partial class Add_roomrate : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Add_roomrate()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed with Room rate details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    if (roomtypetb.Text == "Select Room Type")
                    {
                        MessageBox.Show("Pls Fill in every information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO hm.roomrate (Room_Type,Rate_per_Day) VALUES ('" + roomtypetb.Text + "','" + roomrate2tb.Text + "')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        this.Update();
                        MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_roomrate_Load(object sender, EventArgs e)
        {
            try
            {
                roomtypetb.Text = "Select Room Type";
                roomtypetb.ForeColor = Color.Gray;
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_Type FROM hm.roomrate", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomtypetb.Items.Add(reader["Room_Type"].ToString());
                    roomtypetb.ForeColor = Color.Black;
                }
                conn.Close();
                roomtypetb.AutoCompleteMode = AutoCompleteMode.Suggest;
                roomtypetb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
                getData(combData);
                roomtypetb.AutoCompleteCustomSource = combData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void getData(AutoCompleteStringCollection dataCollection)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Name FROM hm.roomtype", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(ds);
                adapter1.Dispose();
                cmd.Dispose();
                conn.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void roomrate2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void roomtypetb_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            roomtypetb.Items.Clear();
            cmd = new SqlCommand("SELECT Name FROM hm.roomtype", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                roomtypetb.Items.Add(reader["Name"].ToString());
                roomtypetb.ForeColor = Color.Black;
            }
            conn.Close();
        }
    }
}

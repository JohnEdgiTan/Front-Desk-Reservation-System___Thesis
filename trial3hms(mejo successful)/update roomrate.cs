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
    public partial class update_roomrate : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public update_roomrate()
        {
            InitializeComponent();
        }

        private void update_roomrate_Load(object sender, EventArgs e)
        {
            try
            {
                roomtype2tb.Text = "Select Room Type";
                roomtype2tb.ForeColor = Color.Gray;
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomtype2tb.Items.Add(reader["Name"].ToString());
                    roomtype2tb.ForeColor = Color.Black;
                }
                conn.Close();
                roomtype2tb.AutoCompleteMode = AutoCompleteMode.Suggest;
                roomtype2tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
                getData(combData);
                roomtype2tb.AutoCompleteCustomSource = combData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
          
                DialogResult dr2 = MessageBox.Show("Proceed with Room rate details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("UPDATE hm.roomrate SET Rate_per_Day ='" + roomratetb.Text + "'WHERE Room_Type = '" + roomtype2tb.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    conn.Close();
                    this.Update();
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

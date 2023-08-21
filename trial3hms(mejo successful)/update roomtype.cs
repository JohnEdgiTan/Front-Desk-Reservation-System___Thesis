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
    public partial class update_roomtype : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public update_roomtype()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed with Room Type details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("UPDATE hm.roomtype SET Max_Adult_No = '" + maxadultnotb.Text + "',Max_Child_No ='" + maxchildnotb.Text + "',Max_Infant_No ='" + maxinfantnotb.Text + "',Bed_Type= '" + bedtypetb.Text + "',Smoking_Allowed ='" + smokingallowedtb.Text + "' WHERE Name = '" + nametb.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    conn.Close();
                    this.Update();
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomtype WHERE Name= '" + nametb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxadultnotb.Text = (reader["Max Adult No"].ToString());
                    maxchildnotb.Text = (reader["Max Child No"].ToString());
                    codetb.Text = (reader["Roomtype_ID"].ToString());
                    maxinfantnotb.Text = (reader["Max Infant No"].ToString());
                    bedtypetb.Text = (reader["Bed Type"].ToString());
                    smokingallowedtb.Text = (reader["Smoking Allowed"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                this.Close();
            }
        }

        private void update_roomtype_Load(object sender, EventArgs e)
        {
            bedtypetb.Text = "Select Bed Type";
        }
    }
}

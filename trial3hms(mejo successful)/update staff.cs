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
    public partial class update_staff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public update_staff()
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
                DialogResult dr2 = MessageBox.Show("Proceed with Staff details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                   conn.Open();
                   cmd.Connection = conn;
                   cmd = new SqlCommand("UPDATE hm.staffman SET Department ='" + departmenttb.Text + "',Phone1='" + phone1tb.Text + "',Phone2 = '" + phone2tb.Text + "',Email ='" + email2tb.Text + "',Role= '" + role2tb.Text + "' WHERE Name = '" + name3tb.Text + "'", conn);
                   reader = cmd.ExecuteReader();
                   conn.Close();
                   MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        private void update_staff_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT * FROM hm.staffman WHERE Name= '" + name3tb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                departmenttb.Text = (reader["Department"].ToString());
                phone1tb.Text = (reader["Phone1"].ToString());
                phone2tb.Text = (reader["Phone2"].ToString());
                code3tb.Text = (reader["Staff_ID"].ToString());
                email2tb.Text = (reader["Email"].ToString());
                role2tb.Text = (reader["Role"].ToString());
            }
            conn.Close();
        }
    }
}

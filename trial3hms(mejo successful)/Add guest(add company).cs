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
    public partial class addcompanyguest : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public addcompanyguest()
        {
            InitializeComponent();
        }

        private void Add_guest_add_company__Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.addcompany", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                companylisttb.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed with Company details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO hm.addcompany (Company_Name,Date_Added) VALUES ('" + companyname2tb.Text + "','" + dateaddedtb.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    this.Update();
                    MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.addcompany", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                companylisttb.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

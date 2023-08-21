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
    public partial class Add_room_type : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int codes4;
        int finalcode3;
        string maxcode3;
        public Add_room_type()
        {
            InitializeComponent();
            bedtypetb.Text = "Select Bed Type";
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
                    cmd.CommandText = "INSERT INTO hm.roomtype (Code,Name,Max_Adult_No,Max_Child_No,Max_Infant_No,Bed_type,Smoking_Allowed) VALUES ('" + codetb.Text + "','" + nametb.Text + "','" + maxadultnotb.Text + "','" + maxchildnotb.Text + "','" + maxinfantnotb.Text + "','" + bedtypetb.Text + "','" + smokingallowedtb.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    this.Update();
                    MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Add_room_type_Load(object sender, EventArgs e)
        {
            try
            {
                smokingallowedtb.SelectedIndex = 0;
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT MAX(Code) as Code FROM hm.roomtype", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcode3 = (reader["Code"].ToString());
                }
                if (maxcode3 == "")
                {
                    finalcode3 = 1;
                }
                else
                {
                    codes4 = Convert.ToInt32(maxcode3);
                    finalcode3 = codes4 + 1;
                }
                codetb.Text = finalcode3.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void codetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}

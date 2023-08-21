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
    public partial class update_room : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public update_room()
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
                
                DialogResult dr2 = MessageBox.Show("Proceed with Room details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = '" + name2tb.Text + "',Room_Type='" + roomtype2tb.Text + "',Max_Adult_No = '" + maxadultno2tb.Text + "',Max_Child_No ='" + maxchildno2tb.Text + "',Max_Infant_No ='" + maxinfantno2tb.Text + "',Bed_Type= '" + bedtype2tb.Text + "',Smoking_Allowed ='" + smokingallowed2tb.Text + "',Room_Status ='" + roomstatustb2.Text + "' WHERE Room_No ='" + roomno2tb.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    this.Update();
                    conn.Close();
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
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_No= '" + roomno2tb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name2tb.Text = (reader["Name"].ToString());
                maxadultno2tb.Text = (reader["Max_Adult_No"].ToString());
                maxchildno2tb.Text = (reader["Max_Child_No"].ToString());
                code2tb.Text = (reader["Room_ID"].ToString());
                maxinfantno2tb.Text = (reader["Max_Infant_No"].ToString());
                bedtype2tb.Text = (reader["Bed_Type"].ToString());
                smokingallowed2tb.Text = (reader["Smoking_Allowed"].ToString());
                roomtype2tb.Text = (reader["Room_Type"].ToString());
                roomstatustb2.Text = (reader["Room_Status"].ToString());
            }
            conn.Close();
        }

        private void update_room_Load(object sender, EventArgs e)
        {
            roomstatustb2.SelectedIndex = 0;
            smokingallowed2tb.SelectedIndex = 0;
        }
    }
}

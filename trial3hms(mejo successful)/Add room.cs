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
    public partial class Add_room : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int CodeS;
        string maxcoderoom;
        int finalcoderoom;
        string roomcode;
        string roomacro;
        string roomno;
        int roomcodeinitial;
        int countroom;
        int additional = 1;
        public Add_room()
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
                DialogResult dr2 = MessageBox.Show("Proceed with Room/Bed details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    if (roomtype2tb.Text == "Select Room Type" || bedtype2tb.Text == "Select Bed Type")
                    {
                        MessageBox.Show("Pls Fill in every information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO hm.roomorbed (Room_ID,Name,Room_No,Room_Type,Max_Adult_No,Max_Child_No,Max_Infant_No,Bed_Type,Smoking_Allowed,Room_Status) VALUES ('" + code2tb.Text + "','" + name2tb.Text + "','" + roomno2tb.Text + "','" + roomtype2tb.Text + "','" + maxadultno2tb.Text + "','" + maxchildno2tb.Text + "','" + maxinfantno2tb.Text + "','" + bedtype2tb.Text + "','" + smokingallowed2tb.Text + "','Vacant Ready')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        MessageBox.Show("Successfully Reserved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Add_room_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT MAX(Room_ID) as Code FROM hm.roomorbed", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcoderoom = (reader["Code"].ToString());
                }
                if (maxcoderoom == "")
                {
                    finalcoderoom = 1;
                }
                else
                {
                    CodeS = Convert.ToInt32(maxcoderoom);
                    finalcoderoom = CodeS + 1;
                }
                code2tb.Text = finalcoderoom.ToString();
                conn.Close();
                smokingallowed2tb.SelectedIndex = 0;
                roomtype2tb.Text = "Select Room Type";
                bedtype2tb.Text = "Select Bed Type";

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
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomtype2tb.Items.Add(reader["Name"].ToString());
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.roomtype WHERE Name= '" + roomtype2tb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxadultno2tb.Text = (reader["Max_Adult_No"].ToString());
                    maxchildno2tb.Text = (reader["Max_Child_No"].ToString());
                    maxinfantno2tb.Text = (reader["Max_Infant_No"].ToString());
                    bedtype2tb.Text = (reader["Bed_Type"].ToString());
                    smokingallowed2tb.Text = (reader["Smoking_Allowed"].ToString());
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
        private void code2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void roomno2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void roomtype2tb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                roomtype2tb.Items.Clear();
                cmd = new SqlCommand("SELECT Name FROM hm.roomtype", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomtype2tb.Items.Add(reader["Name"].ToString());
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
                conn.Close();
                return;
            }
            try
            {
                if (roomtype2tb.Text == "Deluxe")
                {
                    roomacro = "DEL";
                }
                else if(roomtype2tb.Text == "Standard")
                {
                    roomacro = "STAN";
                }
                else
                {
                    roomacro = "SUI";
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
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Type ='"+roomtype2tb.Text+"'", conn);
                reader = cmd.ExecuteReader();
                countroom = 0;
                while (reader.Read())
                {
                    countroom++;
                }

                roomcodeinitial = countroom + additional;
                roomno = string.Format("{0:D4}", roomcodeinitial);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            roomcode = roomacro + roomno;
            roomno2tb.Text = roomcode;
        }

        private void roomtype2tb_Click(object sender, EventArgs e)
        {
        }

        private void bedtype2tb_Click(object sender, EventArgs e)
        {
            bedtype2tb.Text = "";
        }
    }
}

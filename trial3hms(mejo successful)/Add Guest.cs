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
    public partial class Add_Guest : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int codes2;
        int finalcode;
        string maxcode;
        public Add_Guest()
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
                DialogResult dr2 = MessageBox.Show("Proceed with Guest details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    if (companytb.Text == "Select Company" || gendertb.Text == "Select Gender" || identifiertb.Text == "Select Indentifier" || guaranteetb.Text == "Select Guarantee")
                    {
                        MessageBox.Show("Pls Fill in every information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO hm.guests (Name,Gender,Guest_ID,Email,Phone1,Phone2,Guest_Type,Identifier,Guarantee,Address,City,State,Country,Zip_Code,CarType,License_Plate,Drivers_License,Company,Company_Notes,VAT_No,Passport_No,Passport_Country,Passport_Expiration_Date) VALUES ('" + nametb.Text + "','" + gendertb.Text + "','" + codetb.Text + "','" + emailtb.Text + "','" + phone1tb.Text + "','" + phone2tb.Text + "','" + guesttypetb.Text + "','" + identifiertb.Text + "','" + guaranteetb.Text + "','" + addresstb.Text + "','" + citytb.Text + "','" + statetb.Text + "','" + countrytb.Text + "','" + zipcodetb.Text + "','" + cartypetb.Text + "','" + licenseplatetb.Text + "','" + driverslicensetb.Text + "','" + companytb.Text + "','" + companynotestb.Text + "','" + vatnotb.Text + "','" + passportnotb.Text + "','" + passportcountrytb.Text + "','" + passportexpirationdatetb.Text + "')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
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
        private void Add_Guest_Load(object sender, EventArgs e)
        {
            try
            {
                cartypetb.SelectedIndex = 0;
                guesttypetb.SelectedIndex = 0;
                passportcountrytb.SelectedIndex = 0;
                companytb.Text = "Select Company";
                gendertb.Text = "Select Gender";
                identifiertb.Text = "Select Indentifier";
                guaranteetb.Text = "Select Guarantee";
                companytb.Items.Clear();
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Company_Name FROM hm.addcompany", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    companytb.Items.Add(reader["Company_Name"].ToString());
                    companytb.ForeColor = Color.Black;
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
                cmd = new SqlCommand("SELECT MAX(Guest_ID) as Code FROM hm.guests", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcode = (reader["Code"].ToString());
                }
                if (maxcode == "")
                {
                    finalcode = 1;
                }
                else
                {
                    codes2 = Convert.ToInt32(maxcode);
                    finalcode = codes2 + 1;
                }
                codetb.Text = finalcode.ToString();
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
                statetb.Items.Clear();
                conn.Open();
                cmd.Connection = conn;
                companytb.Items.Clear();
                cmd = new SqlCommand("SELECT major_area FROM hm.zipcodes WHERE country='" + countrytb.Text + "' GROUP BY major_area ORDER BY major_area ASC", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    statetb.Items.Add(reader["major_area"].ToString());
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
        private void button2_Click(object sender, EventArgs e)
        {
            addcompanyguest agac = new addcompanyguest();
            agac.ShowDialog();
        }
        private void phone1tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void phone2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void postalcodetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void passportnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void codetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void vatnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void companytb_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            companytb.Items.Clear();
            cmd = new SqlCommand("SELECT Company_Name FROM hm.addcompany", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                companytb.Items.Add(reader["Company_Name"].ToString());
                companytb.ForeColor = Color.Black;
            }
            conn.Close();
        }

        private void countrytb_Click(object sender, EventArgs e)
        {

        }

        private void statetb_Click(object sender, EventArgs e)
        {
        }

        private void citytb_Click(object sender, EventArgs e)
        {
        }

        private void statetb_SelectedValueChanged(object sender, EventArgs e)
        {

            citytb.Items.Clear();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT city FROM hm.zipcodes WHERE major_area='" + statetb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                citytb.Items.Add(reader["city"].ToString());
            }
            conn.Close();
        }

        private void countrytb_SelectedValueChanged(object sender, EventArgs e)
        {
            statetb.Items.Clear();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT major_area FROM hm.zipcodes WHERE country='" + countrytb.Text + "' GROUP BY major_area ORDER BY major_area ASC", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statetb.Items.Add(reader["major_area"].ToString());
            }
            conn.Close();
        }

        private void citytb_SelectedValueChanged(object sender, EventArgs e)
        {

            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT zip_code FROM hm.zipcodes WHERE city='" + citytb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                zipcodetb.Text = (reader["zip_code"].ToString());
            }
            conn.Close();
        }
    }
}

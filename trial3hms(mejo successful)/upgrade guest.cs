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
    public partial class upgrade_guest : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public upgrade_guest()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult dr2 = MessageBox.Show("Proceed with Guest details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("UPDATE hm.guests SET Gender ='" + gendertb.Text + "',Code='" + codetb.Text + "',Email = '" + emailtb.Text + "',Phone1 ='" + phone1tb.Text + "',Phone2 ='" + phone2tb.Text + "',Guest_Type= '" + guesttypetb.Text + "',Identifier ='" + identifiertb.Text + "',Guarantee ='" + guaranteetb.Text + "',Address='" + addresstb.Text + "',City ='" + citytb.Text + "',State ='" + statetb.Text + "',Country ='" + countrytb.Text + "',Zip_Code ='" + zipcodetb.Text + "',Cartype ='" + cartypetb.Text + "',License_plate='" + licenseplatetb.Text + "',Drivers_license ='" + driverslicensetb.Text + "',Company ='" + companytb.Text + "',Company_notes ='" + companynotestb.Text + "',VAT_NO ='" + vatnotb.Text + "',Passport_No ='" + passportnotb.Text + "',Passport_Country ='" + passportcountrytb.Text + "',Passport_Expiration_Date ='" + passportexpirationdatetb.Text + "' WHERE Name = '" + nametb.Text + "'", conn);
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
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void upgrade_guest_Load(object sender, EventArgs e)
        {

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
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT Name FROM hm.guests", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nametb.Items.Add(reader["Name"].ToString());
                nametb.ForeColor = Color.Black;
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.guests WHERE Name= '" + nametb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    identifiertb.Text = (reader["Identifier"].ToString());
                    guaranteetb.Text = (reader["Guarantee"].ToString());
                    codetb.Text = (reader["Code"].ToString());
                    gendertb.Text = (reader["Gender"].ToString());
                    guesttypetb.Text = (reader["Guest_Type"].ToString());
                    phone1tb.Text = (reader["Phone1"].ToString());
                    phone2tb.Text = (reader["Phone2"].ToString());
                    emailtb.Text = (reader["Email"].ToString());
                    companytb.Text = (reader["Company"].ToString());
                    companynotestb.Text = (reader["Company_Notes"].ToString());
                    addresstb.Text = (reader["Address"].ToString());
                    citytb.Text = (reader["City"].ToString());
                    statetb.Text = (reader["State"].ToString());
                    countrytb.Text = (reader["Country"].ToString());
                    zipcodetb.Text = (reader["Zip_Code"].ToString());
                    vatnotb.Text = (reader["VAT_No"].ToString());
                    cartypetb.Text = (reader["CarType"].ToString());
                    licenseplatetb.Text = (reader["License_Plate"].ToString());
                    driverslicensetb.Text = (reader["Drivers_License"].ToString());
                    cartypetb.Text = (reader["CarType"].ToString());
                    passportnotb.Text = (reader["Passport_No"].ToString());
                    passportcountrytb.Text = (reader["Passport_Country"].ToString());
                    passportexpirationdatetb.Text = (reader["Passport_Expiration_Date"].ToString());
                }
                conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addcompanyguest agac = new addcompanyguest();
            agac.ShowDialog();
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

        private void citytb_Click(object sender, EventArgs e)
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

        private void statetb_Click(object sender, EventArgs e)
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
    }
}

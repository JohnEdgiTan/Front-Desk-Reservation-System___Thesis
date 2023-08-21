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
    public partial class Add_staff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int codesstaff;
        string maxcodestaff;
        int finalstaff;
        int countsa;
        public Add_staff()
        {
            InitializeComponent();
            departmenttb.SelectedIndex = 0;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if ((this.Owner as staffmanagement).staffuserlevel.Text == "Admin" && userlevel.Text == "Admin")
            {
                MessageBox.Show("You can't create an Admin with your user level.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if ((this.Owner as staffmanagement).staffuserlevel.Text == "Super Admin" || (this.Owner as staffmanagement).staffuserlevel.Text == "Admin" && userlevel.Text == "User") {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.users WHERE User_level='Super Admin'", conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        countsa++;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
                try
                {
                    if (countsa >= 1 && userlevel.Text == "Super Admin")
                    {
                        MessageBox.Show("You can only create 1 Super Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        DialogResult dr2 = MessageBox.Show("Proceed with Staff details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr2 == DialogResult.Yes)
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO hm.staffman (Name,Staff_ID,Department,Phone1,Phone2,Email,Role) VALUES ('" + name3tb.Text + "','" + code3tb.Text + "','" + departmenttb.Text + "','" + phone1tb.Text + "','" + phone2tb.Text + "','" + email2tb.Text + "','" + role2tb.Text + "')";
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            conn.Close();
                            MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string pass = Encrypt(staffpasswords.Text);
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO hm.users (User_Name,Password,Staff_Name,Passclue,User_level) VALUES ('" + usernamecopy.Text + "','" + pass + "','" + name3tb.Text + "','" + pbctb.Text + "','" + userlevel.Text + "')";
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            conn.Close();
                            MessageBox.Show("Successfully Created User Account", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        private void Add_staff_Load(object sender, EventArgs e)
        {
            try
            {
                role2tb.SelectedIndex = 0;
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT MAX(Staff_ID) as Code FROM hm.staffman", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcodestaff = (reader["Code"].ToString());
                }
                if (maxcodestaff == "")
                {
                    finalstaff = 1;
                }
                else
                {
                    codesstaff = Convert.ToInt32(maxcodestaff);
                    finalstaff = codesstaff + 1;
                }
                code3tb.Text = finalstaff.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void code3tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void phone1tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void phone2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        public string Encrypt(String passwords)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(passwords));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

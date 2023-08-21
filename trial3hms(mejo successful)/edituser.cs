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
    public partial class edituser : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string passwords;
        string queryString;
        string checkid;
        string checkpass;
        int countsa;
        public edituser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passclueedit.Text = "";
            passwordedit.Text = "";
            newpasswordedit.Text = "";
            confirmpasswordedit.Text = "";
            userleveledit.Text="";
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT * FROM hm.users WHERE Staff_Name= '" + staffname.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usernamedit.Text = (reader["User_Name"].ToString());
                userleveledit.Text = (reader["User_level"].ToString());
                passclueedit.Text = (reader["Passclue"].ToString());
            }
            conn.Close();
            restriction.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.Owner as accounts).accountsuserlevel.Text == "Admin" && userleveledit.Text == "Admin")
            {
                MessageBox.Show("You can't create an Admin with your user level.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if ((this.Owner as accounts).accountsuserlevel.Text == "Super Admin" || (this.Owner as accounts).accountsuserlevel.Text == "Admin" && userleveledit.Text == "User")
            {
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
                    if (countsa >= 1 && userleveledit.Text == "Super Admin")
                    {
                        MessageBox.Show("You can only have 1 Super Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        try
                        {
                            DialogResult dr2 = MessageBox.Show("Proceed with Staff details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr2 == DialogResult.Yes)
                            {
                                if (newpasswordedit.Text == confirmpasswordedit.Text)
                                {
                                    passwords = confirmpasswordedit.Text;
                                    string pass2 = Encrypt(passwords);
                                    conn.Open();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO hm.users (User_Name,User_level,Password,Passclue) VALUES ('" + usernamedit.Text + "','" + userleveledit.Text + "','" + pass2 + "','" + passclueedit.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    cmd.Dispose();
                                    conn.Close();
                                    MessageBox.Show("Successfully Edited", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    (this.Owner as accounts).accountssecretrefresh.PerformClick();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please enter the same password in new password and confirm password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
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

        private void edituser_Load(object sender, EventArgs e)
        {

        }

        private void passwordedit_TextChanged(object sender, EventArgs e)
        {
            restriction.Visible = false;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                newpasswordedit.PasswordChar = '*';
            }
            else
            {
                newpasswordedit.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                confirmpasswordedit.PasswordChar = '*';
            }
            else
            {
                confirmpasswordedit.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passwords = passwordedit.Text;
            string pass = Encrypt(passwords);
            conn.Open();
            cmd.Connection = conn;
            queryString = "SELECT User_Name,Password FROM hm.users WHERE User_Name = '" + usernamedit.Text + "'AND Password = '" + pass + "'";
            SqlCommand query;
            query = new SqlCommand(queryString, conn);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                checkid = reader["User_Name"].ToString();
                checkpass = reader["Password"].ToString();
            }
            conn.Close();
            if (usernamedit.Text.Equals(checkid) && pass.Equals(checkpass))
            {
                MessageBox.Show("Correct Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newpasswordedit.Enabled = true;
                confirmpasswordedit.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using Tulpep.NotificationWindow;


namespace WindowsFormsApplication1
{
    public partial class UserLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        string checkid;
        string checkpass;
        string queryString;
        string username;
        string datetime1;
        string datetime2;
        string passwords;
        string userlevel;
        string passclue;
        string staffnames;
 
        public UserLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                passwords = passwordtextbox.Text;
                DateTime date = DateTime.Now;
                DateTime date2 = DateTime.Now;
                datetime1 = date.ToString("yyyy-MM-dd");
                datetime2 = date.ToString("H-mm-ss");
                string pass = Encrypt(passwords);
                conn.Open();
                cmd.Connection = conn;
                queryString = "SELECT User_Name,Password FROM hm.users WHERE User_Name = '"+usertextbox.Text+"'AND Password = '"+pass+"'";
                SqlCommand query;
                query = new SqlCommand(queryString, conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    checkid = reader["User_Name"].ToString();
                    checkpass = reader["Password"].ToString();
                }
                conn.Close();
                if (usertextbox.Text.Equals(checkid) && pass.Equals(checkpass))
                {
                    MessageBox.Show("Successfully Logged In", "User Log-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT User_Name,User_level,Staff_Name FROM hm.users WHERE User_Name = '"+usertextbox.Text+"'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        username = reader["User_Name"].ToString();
                        userlevel = reader["User_level"].ToString();
                        staffnames = reader["Staff_Name"].ToString();
                    }
                    conn.Close();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO hm.loginhistory (User_Name, DateLoggedIn,TimeLoggedIn) VALUES ('"+usertextbox.Text+"','"+datetime1+"','"+datetime2+"')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Hide();
                    reservationmenu rvm = new reservationmenu();
                    rvm.label2.Text = username;
                    rvm.label3.Text = userlevel;
                    rvm.staffnametext.Text = staffnames;
                    rvm.userleveltext.Text = userlevel;
                    rvm.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("Please enter the correct UserID/Password", "UserID or Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            this.Close();
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Dispose();
            Environment.Exit(0);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

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
        private void UserLogin_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usertextbox.Text == "")
            {
                MessageBox.Show("Please input a username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                label3.Visible= true;
                conn.Open();
                cmd.Connection = conn;
                queryString = "SELECT Passclue FROM hm.users WHERE User_Name = '" + usertextbox.Text + "'";
                SqlCommand query;
                query = new SqlCommand(queryString, conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    passclue = reader["Passclue"].ToString();
                }
                conn.Close();
                label3.Text = passclue;
            }

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                passwordtextbox.PasswordChar = '*';
            }
            else
            {
                passwordtextbox.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

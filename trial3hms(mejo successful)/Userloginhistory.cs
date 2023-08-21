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
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Userloginhistory : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int days;
        string days2;
        public Userloginhistory()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.loginhistory WHERE User_Name='"+userlistbt.Text+"'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                loginhistory.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void Userloginhistory_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.loginhistory", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                loginhistory.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void to3tb_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(from3tb.Text);
            DateTime todate = Convert.ToDateTime(to3tb.Text);
            if (fromdate <= todate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
                days = Convert.ToInt16(ts.Days);
                days2 = days.ToString();

            }
            else
            {
                MessageBox.Show("Error");
                return;
            }
            conn.Open();
            cmd.Connection = conn;
            datatable.Clear();
            ds.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.loginhistory WHERE DateLoggedIn between '" + from3tb.Text + "' AND '" + to3tb.Text + "'", conn);
            adapter1.SelectCommand = cmd;
            adapter1.Fill(datatable);
            loginhistory.DataSource = datatable;
            conn.Close();

        }
    }
}

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
using System.Diagnostics;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class accounts : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable datatable2 = new DataTable();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        DataTable datatable3 = new DataTable();
        SqlDataAdapter adapter3 = new SqlDataAdapter();
        DataSet ds3 = new DataSet();
        DataTable datatable4 = new DataTable();
        SqlDataAdapter adapter4 = new SqlDataAdapter();
        DataSet ds4 = new DataSet();
        DataTable datatable5 = new DataTable();
        SqlDataAdapter adapter5 = new SqlDataAdapter();
        DataSet ds5 = new DataSet();
        public accounts()
        {
            InitializeComponent();
        }
        private void accounts_Load(object sender, EventArgs e)
        {
            accountsuserlevel.Text = (this.Owner as reservationmenu).label3.Text;
            actioncb.Items.Add("Edit User");
            actioncb.Items.Add("Refresh");
            userlist.BackColor = Color.PaleGreen;
            loginhistory.BackColor = Color.MediumAquamarine;
            paymenttb.BackColor = Color.MediumAquamarine;
            servicesttb.BackColor = Color.MediumAquamarine;
            arrowup.Visible = false;
            conn.Open();
            cmd.Connection = conn;
            datatable.Clear();
            ds.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.users", conn);
            adapter1.SelectCommand = cmd;
            adapter1.Fill(datatable);
            userdt.DataSource = datatable;
            conn.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            servicestrans.Visible = false;
            servicenametrans.Visible = false;

            actioncb.Items.Clear();
            actioncb.Items.Add("Edit User");
            actioncb.Items.Add("Refresh");
            userlist.BackColor = Color.PaleGreen;
            loginhistory.BackColor = Color.MediumAquamarine;
            paymenttb.BackColor = Color.MediumAquamarine;
            servicesttb.BackColor = Color.MediumAquamarine;
            arrowup.Visible = false;
            conn.Open();
            cmd.Connection = conn;
            datatable.Clear();
            ds.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.users", conn);
            adapter1.SelectCommand = cmd;
            adapter1.Fill(datatable);
            userdt.DataSource = datatable;
            conn.Close();
        }

        private void arrowdown_Click_2(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup_Click_2(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            datatable.Clear();
            ds.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.users WHERE Name='" + guestname2tb.Text + "'", conn);
            adapter1.SelectCommand = cmd;
            adapter1.Fill(datatable);
            userdt.DataSource = datatable;
            conn.Close();
        }

        private void loginhistory_Click(object sender, EventArgs e)
        {
            servicestrans.Visible = false;
            servicenametrans.Visible = false;
            actioncb.Items.Clear();
            actioncb.Items.Add("Refresh");
            userlist.BackColor = Color.MediumAquamarine;
            loginhistory.BackColor = Color.PaleGreen;
            paymenttb.BackColor = Color.MediumAquamarine;
            servicesttb.BackColor = Color.MediumAquamarine;
            try
            {
                arrowup.Visible = false;
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.loginhistory", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                userdt.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void paymenttb_Click(object sender, EventArgs e)
        {
            servicestrans.Visible = false;
            servicenametrans.Visible = false;
            actioncb.Items.Clear();
            actioncb.Items.Add("Refresh");
            userlist.BackColor = Color.MediumAquamarine;
            loginhistory.BackColor = Color.MediumAquamarine;
            paymenttb.BackColor = Color.PaleGreen;
            servicesttb.BackColor = Color.MediumAquamarine;
            try
            {
                arrowup.Visible = false;
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                userdt.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void servicesttb_Click(object sender, EventArgs e)
        {
            servicestrans.Visible = true;
            servicenametrans.Visible = true;
            servicestrans.BackColor = Color.PaleGreen;
            actioncb.Items.Clear();
            actioncb.Items.Add("Add Service Name");
            actioncb.Items.Add("Refresh");
            userlist.BackColor = Color.MediumAquamarine;
            loginhistory.BackColor = Color.MediumAquamarine;
            paymenttb.BackColor = Color.MediumAquamarine;
            servicesttb.BackColor = Color.PaleGreen;

            try
            {
                arrowup.Visible = false;
                conn.Open();
                cmd.Connection = conn;
                datatable4.Clear();
                ds4.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                userdt.DataSource = datatable4;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void actioncb_SelectedValueChanged(object sender, EventArgs e)
        {
            if(userlist.BackColor == Color.PaleGreen)
            {
                if(actioncb.Text =="Edit User")
                {
                    edituser eu = new edituser();
                    eu.Owner = this;
                    eu.ShowDialog();
                }
                else if(actioncb.Text =="Refresh")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.users", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    userdt.DataSource = datatable;
                    conn.Close();
                }
                else
                {
                    return;
                }
            }
            else if(loginhistory.BackColor == Color.PaleGreen)
            {
                if(actioncb.Text == "Refresh")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable2.Clear();
                    ds2.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.loginhistory", conn);
                    adapter2.SelectCommand = cmd;
                    adapter2.Fill(datatable2);
                    userdt.DataSource = datatable2;
                    conn.Close();
                }
                else
                {
                    return;
                }
            }
            else if(paymenttb.BackColor == Color.PaleGreen)
            {
                if (actioncb.Text == "Refresh")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    userdt.DataSource = datatable3;
                    conn.Close();
                }
                else
                {
                    return;
                }
            }
            else if(servicesttb.BackColor == Color.PaleGreen)
            {
                if (actioncb.Text == "Refresh")
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    userdt.DataSource = datatable4;
                    conn.Close();
                }
                else if(actioncb.Text =="Add Service Name")
                {
                    addservicename asc = new addservicename();
                    asc.Owner = this;
                    asc.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {

            }
        }

        private void accountssecretrefresh_Click(object sender, EventArgs e)
        {
            if (userlist.BackColor == Color.PaleGreen)
            {
               conn.Open();
               cmd.Connection = conn;
               datatable.Clear();
               ds.Clear();
               cmd = new SqlCommand("SELECT * FROM hm.users", conn);
               adapter1.SelectCommand = cmd;
               adapter1.Fill(datatable);
               userdt.DataSource = datatable;
               conn.Close();
            }
            else if (loginhistory.BackColor == Color.PaleGreen)
            {
               conn.Open();
               cmd.Connection = conn;
               datatable2.Clear();
               ds2.Clear();
               cmd = new SqlCommand("SELECT * FROM hm.loginhistory", conn);
               adapter2.SelectCommand = cmd;
               adapter2.Fill(datatable2);
               userdt.DataSource = datatable2;
               conn.Close();
            }
            else if (paymenttb.BackColor == Color.PaleGreen)
            {
               conn.Open();
               cmd.Connection = conn;
               datatable3.Clear();
               ds3.Clear();
               cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
               adapter3.SelectCommand = cmd;
               adapter3.Fill(datatable3);
               userdt.DataSource = datatable3;
               conn.Close();
            }
            else if (servicesttb.BackColor == Color.PaleGreen)
            {
               conn.Open();
               cmd.Connection = conn;
               datatable4.Clear();
               ds4.Clear();
               cmd = new SqlCommand("SELECT * FROM hm.services", conn);
               adapter4.SelectCommand = cmd;
               adapter4.Fill(datatable4);
               userdt.DataSource = datatable4;
               conn.Close();
            }
            else
            {

            }
        }

        private void servicestrans_Click(object sender, EventArgs e)
        {
            servicestrans.BackColor = Color.PaleGreen;
            servicenametrans.BackColor = Color.MediumAquamarine;
            conn.Open();
            cmd.Connection = conn;
            datatable4.Clear();
            ds4.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.services", conn);
            adapter4.SelectCommand = cmd;
            adapter4.Fill(datatable4);
            userdt.DataSource = datatable4;
            conn.Close();
        }

        private void servicenametrans_Click(object sender, EventArgs e)
        {
            servicestrans.BackColor = Color.MediumAquamarine;
            servicenametrans.BackColor = Color.PaleGreen;
            conn.Open();
            cmd.Connection = conn;
            datatable5.Clear();
            ds5.Clear();
            cmd = new SqlCommand("SELECT * FROM hm.servicename", conn);
            adapter5.SelectCommand = cmd;
            adapter5.Fill(datatable5);
            userdt.DataSource = datatable5;
            conn.Close();
        }
    }
}

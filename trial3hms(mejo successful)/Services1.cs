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
    public partial class Services1 : Form
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
        SqlDataReader reader;
        public Services1()
        {
            InitializeComponent();
        }
        private void Services1_Load(object sender, EventArgs e)
        {
            if ((this.Owner as reservationmenu).label3.Text == "User")
            {
                actioncb.Items.Add("Refresh");
            }
            else
            {

                actioncb.Items.Add("Add");
                actioncb.Items.Add("Edit");
                actioncb.Items.Add("Delete");
                actioncb.Items.Add("Refresh");
            }
            arrowup.Visible = false;
            try
            {
                services.BackColor = Color.PaleGreen;
                servicenames.BackColor = Color.MediumAquamarine;
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                servicesdata.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes5", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notes6.Text = (reader["Notes5"].ToString());
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
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes5", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg5.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * from hm.services WHERE Service_Name = '" + servicessearchtb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                servicesdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        private void btnote_Click(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            string userinfoservices = (this.Owner as mainmenuform).usernameee.Text;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes5 (Notes5,date5,time5,[User5]) VALUES ('" + notes6.Text + "','" + datenote + "','" + datetimenote + "','" + userinfoservices + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes5", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                noteslistdg5.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrowdown_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void actioncb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (actioncb.Text == "Add")
            {
                Add_service ase = new Add_service();
                ase.Owner = this;
                ase.checker2 = "Services";
                ase.ShowDialog();
            }
            else if (actioncb.Text == "Edit")
            {
                update_service use = new update_service();
                use.Owner = this;
                use.checker3 = "Services";
                use.ShowDialog();
            }
            else if (actioncb.Text == "Delete")
            {
                try
                {
                    DialogResult dr2 = MessageBox.Show("Proceed to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("DELETE from hm.services WHERE Service_Name = '" + servicessearchtb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        servicesdata.DataSource = datatable;
                        conn.Close();
                        MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    servicesdata.DataSource = datatable;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

            }
            else if (actioncb.Text == "Refresh")
            {
                if (servicenames.BackColor == Color.PaleGreen)
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable3.Clear();
                        ds3.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.servicename", conn);
                        adapter3.SelectCommand = cmd;
                        adapter3.Fill(datatable3);
                        servicesdata.DataSource = datatable3;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        servicesdata.DataSource = datatable;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                }


            }
            else
            {
                return;
            }
        }

        private void servicessearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void services_Click(object sender, EventArgs e)
        {
            try
            {
                services.BackColor = Color.PaleGreen;
                servicenames.BackColor = Color.MediumAquamarine;
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                servicesdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

        }

        private void servicenames_Click(object sender, EventArgs e)
        {
            try
            {
                services.BackColor = Color.MediumAquamarine;
                servicenames.BackColor = Color.PaleGreen;
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.servicename", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicesdata.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

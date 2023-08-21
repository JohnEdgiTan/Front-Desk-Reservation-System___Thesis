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
    public partial class Add_service : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int codesservices;
        int subtotal;
        int rate;
        int quant;
        string maxcodeservices;
        int finalservices;
        string servicerate;
        public string checker2;
        public Add_service()
        {
            InitializeComponent();
        }
        private void Add_service_Load(object sender, EventArgs e)
        {
            if (checker2 == "checkin")
            {
                guestname2tb.Text = (this.Owner as Addreservation).guestnametb.Text;
            }
            else if (checker2 == "edit")
            {
                guestname2tb.Text = (this.Owner as update_reservation).guestname3tb.Text;
            }
            else
            {
                guestname2tb.Text = "";
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT MAX(SN_ID) as Code FROM hm.services", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcodeservices = (reader["Code"].ToString());
                }
                if (maxcodeservices=="")
                {
                    finalservices = 1;
                }
                else
                {
                    codesservices = Convert.ToInt32(maxcodeservices);
                    finalservices = codesservices + 1;
                }
                code4tb.Text = finalservices.ToString();
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
                typetb.Text = "Select Type";
                conn.Open();
                cmd.Connection = conn;
                typetb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Type FROM hm.servicename GROUP BY Service_Type", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    typetb.Items.Add(reader["Service_Type"].ToString());
                    typetb.ForeColor = Color.Black;
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
                servicenametb.Text = "Select Service Name";
                conn.Open();
                cmd.Connection = conn;
                servicenametb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Name FROM hm.servicename", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicenametb.Items.Add(reader["Service_Name"].ToString());
                    servicenametb.ForeColor = Color.Black;
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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed with Services details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    if (typetb.Text == "Select Type")
                    {
                        MessageBox.Show("Pls Fill in every information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO hm.services (Service_Name,SN_ID, Type, Rate,Quantity, Subtotal,GuestName,Date_Recorded) VALUES ('" + servicenametb.Text + "','" + code4tb.Text + "','" + typetb.Text + "','" + ratetb.Text + "','" + quantitytb.Text + "','" + subtotaltb.Text + "','" + guestname2tb.Text + "','" + servicedatarecordedtb.Text + "')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (checker2 == "checkin")
                        {
                            (this.Owner as Addreservation).addservicerefresh.PerformClick();
                        }
                        else
                        {
                            (this.Owner as update_reservation).editservicerefresh.PerformClick();
                        }
                        this.Close();

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
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void code4tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void ratetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void subtotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void servicenametb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                servicenametb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Name,Service_Rate FROM hm.servicename WHERE Service_Type='"+typetb.Text+"'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicenametb.Items.Add(reader["Service_Name"].ToString());
                    servicerate = reader["Service_Rate"].ToString();
                    servicenametb.ForeColor = Color.Black;
                }
                conn.Close();
                ratetb.Text = servicerate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void servicenametb_SelectedValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT Service_Rate FROM hm.servicename WHERE Service_Name='" + servicenametb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ratetb.Text = (reader["Service_Rate"].ToString());
            }
            conn.Close();
        }

        private void quantitytb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantitytb_Click(object sender, EventArgs e)
        {
            quant = Convert.ToInt32(quantitytb.Text);
            rate = Convert.ToInt32(ratetb.Text);
            subtotal = quant * rate;
            subtotaltb.Text = subtotal.ToString();
        }

        private void typetb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                typetb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Type FROM hm.servicename GROUP BY Service_Type", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    typetb.Items.Add(reader["Service_Type"].ToString());
                    typetb.ForeColor = Color.Black;
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
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void typetb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ratetb_TextChanged(object sender, EventArgs e)
        {
            quant = Convert.ToInt32(quantitytb.Text);
            rate = Convert.ToInt32(ratetb.Text);
            subtotal = quant * rate;
            subtotaltb.Text = subtotal.ToString();
        }
    }
}

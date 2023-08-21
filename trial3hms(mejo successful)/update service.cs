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
    public partial class update_service : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public string checker3;
        int subtotal;
        int rate;
        int quant;
        public update_service()
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
                DialogResult dr2 = MessageBox.Show("Proceed with Service details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("UPDATE hm.services SET Type ='" + typetb.Text + "',Rate='" + ratetb.Text + "',Quantity ='" + quantitytb.Text + "',Subtotal='" + subtotaltb.Text + "',GuestName='" + guestname2tb.Text + "',Service_Name = '" + servicenametb.Text + "' WHERE SN_ID='" +code4tb.Text +"'", conn);
                    reader = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checker3 == "checkin")
                    {
                        (this.Owner as Addreservation).addservicerefresh.PerformClick();
                    }
                    else
                    {
                        (this.Owner as update_reservation).editservicerefresh.PerformClick();
                    }
                    this.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE SN_ID= '" + code4tb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    typetb.Text = (reader["Type"].ToString());
                    servicenametb.Text = (reader["Service_Name"].ToString());
                    ratetb.Text = (reader["Rate"].ToString());
                    quantitytb.Text = (reader["Quantity"].ToString());
                    subtotaltb.Text = (reader["Subtotal"].ToString());
                    guestname2tb.Text = (reader["GuestName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            addservicename asc = new addservicename();
            asc.Owner = this;
            asc.ShowDialog();
        }
        private void update_service_Load(object sender, EventArgs e)
        {
            if (checker3 == "checkin")
            {
                guestname2tb.Text = (this.Owner as Addreservation).guestnametb.Text;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    code4tb.Items.Clear();
                    cmd = new SqlCommand("SELECT SN_ID FROM hm.services WHERE GuestName ='" + (this.Owner as Addreservation).guestnametb.Text + "' AND Date_Recorded='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code4tb.Items.Add(reader["SN_ID"].ToString());
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
            else if (checker3 == "edit")
            {
                guestname2tb.Text = (this.Owner as update_reservation).guestname3tb.Text;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    code4tb.Items.Clear();
                    cmd = new SqlCommand("SELECT SN_ID FROM hm.services WHERE GuestName ='" + (this.Owner as update_reservation).guestname3tb.Text + "' AND Date_Recorded='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code4tb.Items.Add(reader["SN_ID"].ToString());
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();

                }
            }
            else
            {
                guestname2tb.Text = "";
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

        }
        private void servicenametb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                servicenametb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Name FROM hm.servicename WHERE Service_Type='" + typetb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicenametb.Items.Add(reader["Service_Name"].ToString());
                    servicenametb.ForeColor = Color.Black;
                }
                conn.Close();
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Service_Rate FROM hm.servicename WHERE Service_Name='" + servicenametb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ratetb.Text = reader["Service_Rate"].ToString();
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

        private void code4tb_Click(object sender, EventArgs e)
        {
            if (checker3 == "checkin")
            {
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    code4tb.Items.Clear();
                    cmd = new SqlCommand("SELECT SN_ID FROM hm.services WHERE GuestName ='" + (this.Owner as Addreservation).guestnametb.Text + "' AND Date_Recorded='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code4tb.Items.Add(reader["SN_ID"].ToString());
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
            else if (checker3 == "edit")
            {
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    code4tb.Items.Clear();
                    cmd = new SqlCommand("SELECT SN_ID FROM hm.services WHERE GuestName ='" + (this.Owner as update_reservation).guestname3tb.Text + "' AND Date_Recorded='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code4tb.Items.Add(reader["SN_ID"].ToString());
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();

                }
            }
            else
            { 
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    code4tb.Items.Clear();
                    cmd = new SqlCommand("SELECT SN_ID FROM hm.services", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        code4tb.Items.Add(reader["SN_ID"].ToString());
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
        }

        private void typetb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                servicenametb.Items.Clear();
                cmd = new SqlCommand("SELECT Service_Name FROM hm.servicename WHERE Service_Type='" + typetb.Text + "'", conn);
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

        private void ratetb_TextChanged(object sender, EventArgs e)
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
        private void quantitytb_Click(object sender, EventArgs e)
        {
            quant = Convert.ToInt32(quantitytb.Text);
            rate = Convert.ToInt32(ratetb.Text);
            subtotal = quant * rate;
            subtotaltb.Text = subtotal.ToString();
        }
        private void servicenametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void typetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void servicenametb_TextUpdate(object sender, EventArgs e)
        {
           
            {

            }
        }
    }
}

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
    public partial class update_payment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public string checkereditres;
        public update_payment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE Ref_No= '" + refnotb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paymentdatetb.Text = (reader["Payment_Date"].ToString());
                    paymenttimetb.Text = (reader["Payment_Time"].ToString());
                    paymenttotaltb.Text = (reader["Payment_Total"].ToString());
                    notestb.Text = (reader["Payment_Notes"].ToString());
                    paymenttypetb.Text = (reader["Payment_Type"].ToString());
                    paymentguestnametb.Text = (reader["GuestNa"].ToString());
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
            this.Close();
        }

        private void update_payment_Load(object sender, EventArgs e)
        {
            if (checkereditres == "checkin")
            {
                paymentguestnametb.Text = (this.Owner as Addreservation).guestnametb.Text;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    refnotb.Items.Clear();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + (this.Owner as Addreservation).guestnametb.Text + "' AND Payment_Date='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        refnotb.Items.Add(reader["Ref_No"].ToString());
                        refnotb.ForeColor = Color.Black;
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
            else
            {
                paymentguestnametb.Text = (this.Owner as update_reservation).guestname3tb.Text;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    refnotb.Items.Clear();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + (this.Owner as update_reservation).guestname3tb.Text + "' AND Payment_Date='" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        refnotb.Items.Add(reader["Ref_No"].ToString());
                        refnotb.ForeColor = Color.Black;
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
            refnotb.Text = "Select Ref No";

        }

        private void refnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void paymenttotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Proceed with Room details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr2 == DialogResult.Yes)
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("UPDATE hm.paymentss SET GuestNa = '" + paymentguestnametb.Text + "',Payment_Type ='" + paymenttypetb.Text + "',Payment_Total = '" + paymenttotaltb.Text + "',Payment_Notes = '" + notestb.Text + "' WHERE Ref_No='" + refnotb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkereditres == "checkin")
                {
                    (this.Owner as Addreservation).addrefresh.PerformClick();
                }
                else
                {
                    (this.Owner as update_reservation).editrefresh.PerformClick();
                }
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void refnotb_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (checkereditres == "checkin")
                {
                    refnotb.Text = "";
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    refnotb.Items.Clear();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT Ref_No FROM hm.paymentss WHERE GuestNa ='" + (this.Owner as Addreservation).guestnametb.Text + "' AND Payment_Date= '" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        refnotb.Items.Add(reader["Ref_No"].ToString());
                        refnotb.ForeColor = Color.Black;
                    }
                    conn.Close();
                }
                else
                {
                    refnotb.Text = "";
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    refnotb.Items.Clear();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("SELECT Ref_No FROM hm.paymentss WHERE GuestNa ='" + (this.Owner as update_reservation).guestname3tb.Text + "' AND Payment_Date= '" + nows + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        refnotb.Items.Add(reader["Ref_No"].ToString());
                        refnotb.ForeColor = Color.Black;
                    }
                    conn.Close();
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
}

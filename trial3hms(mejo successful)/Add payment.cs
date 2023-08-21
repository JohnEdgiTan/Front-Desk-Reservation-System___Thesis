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
    public partial class Add_payment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int references1;
        string maxcode2;
        int codes3;
        public string paymentname;
        public string checkerpayment;
        public Add_payment()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymenttypetb.Text == "Select Payment Type")
                {
                    MessageBox.Show("Please select a payment type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult dr2 = MessageBox.Show("Proceed with Payment details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO hm.paymentss (GuestNa,Payment_Date,Payment_Time,Payment_Type,Payment_Total,Ref_No,Payment_Notes) VALUES ('" + paymentguestnametb.Text + "','" + paymentdatetb.Text + "','" + paymenttimetb.Text + "','" + paymenttypetb.Text + "','" + paymenttotaltb.Text + "','" + refnotb.Text + "','" + notestb.Text + "')";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        MessageBox.Show("Successfully Recorded", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (checkerpayment == "checkin")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void Add_payment_Load(object sender, EventArgs e)
        {
            if (checkerpayment == "checkin")
            {
                paymentguestnametb.Text = (this.Owner as Addreservation).guestnametb.Text;
            }
            else
            {
                paymentguestnametb.Text = (this.Owner as update_reservation).guestname3tb.Text;
            }
            paymenttypetb.Text = "Select Payment Type";
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT MAX(Ref_No) as Ref_No FROM hm.paymentss", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcode2 = (reader["Ref_No"].ToString());
                }
                if (maxcode2 == "")
                {
                    references1 = 1;
                }
                else
                {
                    codes3 = Convert.ToInt32(maxcode2);
                    references1 = codes3+1;
                    
                }
                paymentname = paymentguestnametb.Text;
                refnotb.Text = references1.ToString();
                conn.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void paymenttotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void refnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void paymenttypetb_Click(object sender, EventArgs e)
        {
            paymenttypetb.Text = "";
        }
    }
}

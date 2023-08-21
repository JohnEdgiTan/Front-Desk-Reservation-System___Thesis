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
    public partial class delete_payment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public delete_payment()
        {
            InitializeComponent();
        }
        private void delete_payment_Load(object sender, EventArgs e)
        {
            refnodeletetb.Enabled = false;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                paymentlisttb.DataSource = datatable;
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
                guestnamedeletetb.ResetText();
                guestnamedeletetb.Items.Clear();
                cmd = new SqlCommand("SELECT GuestNa FROM hm.paymentss", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnamedeletetb.Items.Add(reader["GuestNa"].ToString());
                    guestnamedeletetb.ForeColor = Color.Black;
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            guestnamedeletetb.Text = "Select Guest Name";
            refnodeletetb.Text = "Select Reference No.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (allowsearchrefnotb.Checked == true)
            {
                try
                {
                    if (guestnamedeletetb.Text == "Select Guest Name" || refnodeletetb.Text == "Select Reference No.")
                    {
                        MessageBox.Show("Please Fill in all the information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + guestnamedeletetb.Text + "' AND Ref_No='" + refnodeletetb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        paymentlisttb.DataSource = datatable;
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
            else
            {
                try
                {
                    if (guestnamedeletetb.Text == "Select Guest Name")
                    {
                        MessageBox.Show("Please Fill in all the information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + guestnamedeletetb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        paymentlisttb.DataSource = datatable;
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (allowsearchrefnotb.Checked == false)
            {
                try
                {
                    if (guestnamedeletetb.Text == "Select Guest Name")
                    {
                        MessageBox.Show("Please Fill in all the information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        DialogResult dr2 = MessageBox.Show("Proceed to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr2 == DialogResult.Yes)
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            datatable.Clear();
                            ds.Clear();
                            cmd = new SqlCommand("DELETE from hm.paymentss WHERE GuestNa = '" + guestnamedeletetb.Text + "'", conn);
                            adapter1.SelectCommand = cmd;
                            adapter1.Fill(datatable);
                            paymentlisttb.DataSource = datatable;
                            conn.Close();
                            MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else {
                try
                {
                    if (guestnamedeletetb.Text == "Select Guest Name" || refnodeletetb.Text == "Select Reference No.")
                    {
                        MessageBox.Show("Please Fill in all the information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        DialogResult dr2 = MessageBox.Show("Proceed to Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr2 == DialogResult.Yes)
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            datatable.Clear();
                            ds.Clear();
                            cmd = new SqlCommand("DELETE from hm.paymentss WHERE GuestNa = '" + guestnamedeletetb.Text + "' AND Ref_No='" + refnodeletetb.Text + "'", conn);
                            adapter1.SelectCommand = cmd;
                            adapter1.Fill(datatable);
                            paymentlisttb.DataSource = datatable;
                            conn.Close();
                            MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void guestnamedeletetb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                guestnamedeletetb.ResetText();
                guestnamedeletetb.Items.Clear();
                cmd = new SqlCommand("SELECT GuestNa FROM hm.paymentss GROUP BY GuestNa", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnamedeletetb.Items.Add(reader["GuestNa"].ToString());
                    guestnamedeletetb.ForeColor = Color.Black;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void refnodeletetb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                refnodeletetb.Items.Clear();
                cmd = new SqlCommand("SELECT Ref_No FROM hm.paymentss WHERE GuestNa='" + guestnamedeletetb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    refnodeletetb.Items.Add(reader["Ref_No"].ToString());
                    refnodeletetb.ForeColor = Color.Black;
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (allowsearchrefnotb.Checked == true)
            {
                refnodeletetb.Enabled = true;
            }
            else {
                refnodeletetb.ResetText();
                refnodeletetb.Enabled = false;
            }
        }

        private void guestnamedeletetb_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class setting : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string generatedcode;
        string first;
        string second;
        string third;
        string status;
        public setting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkintimevalue.Text = Convert.ToDateTime(reader["Checkinstart"]).ToString("HH:mm:ss");
                    endcheckintimevalue.Text = Convert.ToDateTime(reader["Checkinend"]).ToString("HH:mm:ss");
                    checkouttimedeadline.Text = Convert.ToDateTime(reader["Checkouttime"]).ToString("HH:mm:ss");
                    currency.Text = (reader["CurrencySymbol"].ToString());
                    status = (reader["AllowCheckOutStatus"].ToString());
                }
                conn.Close();
                if (status == "True")
                {
                    statussetting.Checked = true;
                }
                else
                {
                    statussetting.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            firsttb.SelectedIndex = 0;
            secondtb.SelectedIndex = 0;
            thirdtb.SelectedIndex = 0;
            codegensettings.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Proceed to change in Settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr2 == DialogResult.Yes)
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO hm.checkincheckoutdatedeadline (Checkinstart, Checkinend, Checkouttime,CurrencySymbol,AllowCheckOutStatus) VALUES ('" + checkintimevalue.Value.ToString("HH:mm:ss") + "','" + endcheckintimevalue.Value.ToString("HH:mm:ss") + "','" + checkouttimedeadline.Value.ToString("HH:mm:ss") + "','" + currency.Text + "','" + statussetting.Checked.ToString() + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Successfully Changed", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void firsttb_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            if (firsttb.Text == "yy")
            {
                firsttb.Text = Datenow.ToString("yy");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "yymm")
            {
                firsttb.Text = Datenow.ToString("yyMM");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "yymmdd")
            {
                firsttb.Text = Datenow.ToString("yyMMdd");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "yyyy")
            {
                firsttb.Text = Datenow.ToString("yyyy");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "yyyymm")
            {
                firsttb.Text = Datenow.ToString("yyyyMM");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "yyyymmdd")
            {
                firsttb.Text = Datenow.ToString("yyyyMMdd");
                first = firsttb.Text;
            }
            else if (firsttb.Text == "Sequence No. 1dg")
            {
                firsttb.Text = string.Format("{0:D1}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 2D(00)")
            {
                firsttb.Text = string.Format("{0:D2}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 3D(000)")
            {
                firsttb.Text = string.Format("{0:D3}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 4D(0000)")
            {
                firsttb.Text = string.Format("{0:D4}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 5D(00000)")
            {
                firsttb.Text = string.Format("{0:D5}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 6D(000000)")
            {
                firsttb.Text = string.Format("{0:D6}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 7D(0000000)")
            {
                firsttb.Text = string.Format("{0:D7}", 1);
                first = firsttb.Text;
            }
            else if (firsttb.Text == "SN 8D(00000000)")
            {
                firsttb.Text = string.Format("{0:D8}", 1);
                first = firsttb.Text;
            }
            else
            {
                return;
            }
            generatedcode = first + second + third;
            finalgeneratedcode.Text = generatedcode;
        }

        private void secondtb_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            if (secondtb.Text == "yy")
            {
                secondtb.Text = Datenow.ToString("yy");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "yymm")
            {
                secondtb.Text = Datenow.ToString("yyMM");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "yymmdd")
            {
                secondtb.Text = Datenow.ToString("yyMMdd");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "yyyy")
            {
                secondtb.Text = Datenow.ToString("yyyy");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "yyyymm")
            {
                secondtb.Text = Datenow.ToString("yyyyMM");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "yyyymmdd")
            {
                secondtb.Text = Datenow.ToString("yyyyMMdd");
                second = secondtb.Text;
            }
            else if (secondtb.Text == "Sequence No. 1dg")
            {
                secondtb.Text = string.Format("{0:D1}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 2D(00)")
            {
                secondtb.Text = string.Format("{0:D2}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 3D(000)")
            {
                secondtb.Text = string.Format("{0:D3}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 4D(0000)")
            {
                secondtb.Text = string.Format("{0:D4}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 5D(00000)")
            {
                secondtb.Text = string.Format("{0:D5}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 6D(000000)")
            {
                secondtb.Text = string.Format("{0:D6}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 7D(0000000)")
            {
                secondtb.Text = string.Format("{0:D7}", 1);
                second = secondtb.Text;
            }
            else if (secondtb.Text == "SN 8D(00000000)")
            {
                secondtb.Text = string.Format("{0:D8}", 1);
                second = secondtb.Text;
            }
            else
            {
                return;
            }
            generatedcode = first + second + third;
            finalgeneratedcode.Text = generatedcode;
        }

        private void thirdtb_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            if (thirdtb.Text == "yy")
            {
                thirdtb.Text = Datenow.ToString("yy");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "yymm")
            {
                thirdtb.Text = Datenow.ToString("yyMM");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "yymmdd")
            {
                thirdtb.Text = Datenow.ToString("yyMMdd");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "yyyy")
            {
                thirdtb.Text = Datenow.ToString("yyyy");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "yyyymm")
            {
                thirdtb.Text = Datenow.ToString("yyyyMM");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "yyyymmdd")
            {
                thirdtb.Text = Datenow.ToString("yyyyMMdd");
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "Sequence No. 1dg")
            {
                thirdtb.Text = string.Format("{0:D1}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 2D(00)")
            {
                thirdtb.Text = string.Format("{0:D2}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 3D(000)")
            {
                thirdtb.Text = string.Format("{0:D3}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 4D(0000)")
            {
                thirdtb.Text = string.Format("{0:D4}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 5D(00000)")
            {
                thirdtb.Text = string.Format("{0:D5}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 6D(000000)")
            {
                thirdtb.Text = string.Format("{0:D6}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 7D(0000000)")
            {
                thirdtb.Text = string.Format("{0:D7}", 1);
                third = thirdtb.Text;
            }
            else if (thirdtb.Text == "SN 8D(00000000)")
            {
                thirdtb.Text = string.Format("{0:D8}", 1);
                third = thirdtb.Text;
            }
            else
            {
                return;
            }
            generatedcode = first + second + third;
            finalgeneratedcode.Text = generatedcode;
        }

        private void codegensettings_SelectedValueChanged(object sender, EventArgs e)
        {
            if (codegensettings.Text == "Can Edit")
            {
                finalgeneratedcode.Enabled = true;
            }
            else
            {
                finalgeneratedcode.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

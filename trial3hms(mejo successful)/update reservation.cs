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
    public partial class update_reservation : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
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
        string queryString;
        string statusget2;
        int paymentotal;
        int paymentotal2;
        int finaltotal;
        int totalbalance;
        int totalfinalprice1;
        int roomprice;
        string roomp;
        string roomp2;
        int finalprice;
        int days;
        string days2;
        int sum2;
        int sum;
        string checkroom;
        string timespanend;
        string guestname;
        string codex;
        string cs2;


        public update_reservation()
        {
            InitializeComponent();
        }
        public void Alert(string msg, FormAlertYellow.enmType type)
        {
            FormAlertYellow frt = new FormAlertYellow();
            frt.showAlert(msg, type);
        }
        private void update_reservation_Load(object sender, EventArgs e)
        {
 
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomrate", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                roomratetb.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT Guest_Name FROM hm.reservation WHERE NOT Status='Checked out'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestname3tb.Items.Add(reader["Guest_Name"].ToString());
                    guestname3tb.ForeColor = Color.Black;
                }
                cmd.Dispose();
                conn.Close();
                guestname3tb.Text = "Select Guest Name";
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
                cmd = new SqlCommand("SELECT Checkouttime FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    timespanend = Convert.ToDateTime(reader["Checkouttime"]).ToString("HH:mm:ss");
                }
                conn.Close();
                DateTime dt1 = Convert.ToDateTime(timespanend);
                TimeSpan cot = new TimeSpan(dt1.Hour, dt1.Minute, dt1.Second);
                TimeSpan end = new TimeSpan(0, 0, 0);
                TimeSpan now = DateTime.Now.TimeOfDay;
                if ((now >end ) && (now < cot))
                {
                    statustb.Text = "Select Status";
                    statustb.Items.Add("Checked out");
                    statustb.Items.Add("Checked in");
                    statustb.Items.Add("Reserved");
                    statustb.Items.Add("Reserved-Cancelled");
                }
                else
                {
                    statustb.Text = "Select Status";
                    statustb.Items.Add("Checked in");
                    statustb.Items.Add("Reserved");
                    statustb.Items.Add("Reserved-Cancelled");
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
                cmd = new SqlCommand("SELECT CurrencySymbol FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cs2 = (reader["CurrencySymbol"].ToString());
                }
                conn.Close();
                string valueToConvert = roomtotaltb.Text.Replace(cs2, "");
                double newVal = Convert.ToDouble(valueToConvert);
                roomtotaltb.Text = cs2 + Convert.ToString(newVal);
                string valueToConvert2 = servicetotaltb.Text.Replace(cs2, "");
                double newVal2 = Convert.ToDouble(valueToConvert2);
                servicetotaltb.Text = cs2 + Convert.ToString(newVal2);
                string valueToConvert3 = nettotaltb.Text.Replace(cs2, "");
                double newVal3 = Convert.ToDouble(valueToConvert3);
                nettotaltb.Text = cs2 + Convert.ToString(newVal3);
                string valueToConvert4 = totaltb.Text.Replace(cs2, "");
                double newVal4 = Convert.ToDouble(valueToConvert4);
                totaltb.Text = cs2 + Convert.ToString(newVal4);
                string valueToConvert5 = paid2tb.Text.Replace(cs2, "");
                double newVal5 = Convert.ToDouble(valueToConvert5);
                paid2tb.Text = cs2 + Convert.ToString(newVal5);
                string valueToConvert6 = balancetb.Text.Replace(cs2, "");
                double newVal6 = Convert.ToDouble(valueToConvert6);
                balancetb.Text = cs2 + Convert.ToString(newVal6);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            statustb.Enabled = false;
            codetb.Enabled = false;
            roomtb.Enabled = false;
            guestemailtb.Enabled = false;
            guestphonetb.Enabled = false;
            guestcompanytb.Enabled = false;
            checkintb.Enabled = false;
            checkouttb.Enabled = false;
            adultnotb.Enabled = false;
            childnotb.Enabled = false;
            infantnotb.Enabled = false;
            addresstb.Enabled = false;
            citytb.Enabled = false;
            statetb.Enabled = false;
            countrytb.Enabled = false;
            zipcodetb.Enabled = false;
            nettotaltb.Enabled = false;
            roomtotaltb.Enabled = false;
            servicetotaltb.Enabled = false;
            taxtotaltb.Enabled = false;
            discounttb.Enabled = false;
            taxtb.Enabled = false;
            totaltb.Enabled = false;
            paid2tb.Enabled = false;
            balancetb.Enabled = false;
            specialreqtb.Enabled = false;
            usertb.Enabled = false;
            toolStrip1.Enabled = false;
            toolStrip2.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_No FROM hm.roomorbed WHERE Name='"+guestname3tb.Text+"'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkroom = reader["Room_No"].ToString();
                }
                cmd.Dispose();
                conn.Close();
                if (checkroom != roomtb.Text)
                {
                    DialogResult dr3 = MessageBox.Show("Confirm to proceed room changing?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr3 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = 'N/A' WHERE Room_No ='" + checkroom + "'", conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        return;
                    }
                }

                DialogResult dr2 = MessageBox.Show("Proceed with Reservation details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd = new SqlCommand("UPDATE hm.reservation SET Status =@status,Room =@room, Guest_Name =@guestname,Guest_Email=@guestemail, Guest_Phone =@guestphone, Guest_Company=@guestcompany, Check_in =@checkin, Check_out =@checkout, Adult_No =@adultno, Child_No =@childno, Infant_No =@infantno, Net_Total =@nettotal, Room_Total =@roomtotal, Service_Total =@servicetotal, Tax_total =@taxtotal, Discount =@discount, Tax =@tax, Total =@total, Paid = @paid, Balance =@balance, Special_Req=@specialreq,[User]=@user, Address =@address, City =@city, State =@state, Country =@country, Zip_Code =@postalcode WHERE Guest_Name =@guest_name", conn);
                    cmd.Parameters.AddWithValue("@status", statustb.Text);
                    cmd.Parameters.AddWithValue("@room",roomtb.Text);
                    cmd.Parameters.AddWithValue("@guestname", guestname3tb.Text);
                    cmd.Parameters.AddWithValue("@guestemail", guestemailtb.Text);
                    cmd.Parameters.AddWithValue("@guestphone", guestphonetb.Text);  
                    cmd.Parameters.AddWithValue("@guestcompany", guestcompanytb.Text);
                    cmd.Parameters.AddWithValue("@checkin", checkintb.Text);
                    cmd.Parameters.AddWithValue("@checkout", checkouttb.Text);
                    cmd.Parameters.AddWithValue("@adultno", adultnotb.Text);
                    cmd.Parameters.AddWithValue("@childno", childnotb.Text);
                    cmd.Parameters.AddWithValue("@infantno", infantnotb.Text);
                    cmd.Parameters.AddWithValue("@nettotal", nettotaltb.Text);
                    cmd.Parameters.AddWithValue("@roomtotal", roomtotaltb.Text);
                    cmd.Parameters.AddWithValue("@servicetotal", servicetotaltb.Text);
                    cmd.Parameters.AddWithValue("@taxtotal", taxtotaltb.Text);
                    cmd.Parameters.AddWithValue("@discount", discounttb.Text);
                    cmd.Parameters.AddWithValue("@tax", taxtb.Text);
                    cmd.Parameters.AddWithValue("@total", totaltb.Text);
                    cmd.Parameters.AddWithValue("@paid", paid2tb.Text);
                    cmd.Parameters.AddWithValue("@balance", balancetb.Text);
                    cmd.Parameters.AddWithValue("@specialreq", specialreqtb.Text);
                    cmd.Parameters.AddWithValue("@user", usertb.Text);
                    cmd.Parameters.AddWithValue("@address", addresstb.Text);
                    cmd.Parameters.AddWithValue("@city", citytb.Text);
                    cmd.Parameters.AddWithValue("@state", statetb.Text);
                    cmd.Parameters.AddWithValue("@country", countrytb.Text);
                    cmd.Parameters.AddWithValue("@postalcode", zipcodetb.Text);
                    cmd.Parameters.AddWithValue("@guest_name", guestname3tb.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (statustb.Text.Equals("Checked out"))
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = 'N/A',Room_Status='Vacant Dirty' WHERE Room_No ='" + roomtb.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose(); ;
                        conn.Close();
                    }
                    else if (statustb.Text.Equals("Checked in"))
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = '" + guestname3tb.Text + "' WHERE Room_No ='" + roomtb.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        queryString = "SELECT Status FROM hm.reservation WHERE Guest_Name = '" + guestname3tb.Text + "'AND Guest_Email = '" + guestemailtb.Text + "'";
                        SqlCommand query;
                        query = new SqlCommand(queryString, conn);
                        reader = query.ExecuteReader();
                        while (reader.Read())
                        {
                            statusget2 = reader["Status"].ToString();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                    if (statusget2 == "Reserved")
                    {
                        this.Alert("You have successfully recorded the reservation of " + guestname3tb.Text + " ", FormAlertYellow.enmType.Reservation);
                    }
                    else if(statusget2 =="Checked out")
                    {
                        this.Alert("You have successfully recorded the Check out of " + guestname3tb.Text + " ", FormAlertYellow.enmType.Checkedout);
                    }
                    else if(statusget2 =="Checked in")
                    {
                        this.Alert("You have successfully recorded the Check in of " + guestname3tb.Text + " ", FormAlertYellow.enmType.Checkedin);
                    }
                    else
                    {
                        this.Alert("You have successfully Cancelled the Reservation of " + guestname3tb.Text + " ", FormAlertYellow.enmType.Cancelled);
                    }
                    (this.Owner as Reservation).secretrefresh.PerformClick();
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
                conn.Close();
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
  
            if (guestname == guestname3tb.Text)
            {
                return;
            }
            if (codetb.Text == "")
            {
                return;
            }
            else
            {
               
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable4.Clear();
                    ds4.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE NOT Status='Checked out' AND Guest_Name= '" + guestname3tb.Text + "' AND Res_ID='" + codetb.Text + "'", conn);
                    adapter4.SelectCommand = cmd;
                    adapter4.Fill(datatable4);
                    guestnamedatatb.DataSource = datatable4;
                    reader=cmd.ExecuteReader();
                    if (reader.HasRows == false) {
                        MessageBox.Show("Record Not Found", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        return; 
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
                    cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE Guest_Name= '" + guestname3tb.Text + "' AND Res_ID='" + codetb.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        codetb.Text = (reader["Res_ID"].ToString());
                        statustb.Text = (reader["Status"].ToString());
                        roomtb.Text = (reader["Room"].ToString());
                        guestemailtb.Text = (reader["Guest_Email"].ToString());
                        guestphonetb.Text = (reader["Guest_Phone"].ToString());
                        guestcompanytb.Text = (reader["Guest_Company"].ToString());
                        checkintb.Text = (reader["Check_in"].ToString());
                        checkouttb.Text = (reader["Check_Out"].ToString());
                        adultnotb.Text = (reader["Adult_No"].ToString());
                        childnotb.Text = (reader["Child_No"].ToString());
                        infantnotb.Text = (reader["Infant_No"].ToString());
                        addresstb.Text = (reader["Address"].ToString());
                        citytb.Text = (reader["City"].ToString());
                        statetb.Text = (reader["State"].ToString());
                        countrytb.Text = (reader["Country"].ToString());
                        zipcodetb.Text = (reader["Zip_Code"].ToString());
                        nettotaltb.Text = (reader["Net_Total"].ToString());
                        roomtotaltb.Text = (reader["Room_Total"].ToString());
                        servicetotaltb.Text = (reader["Service_Total"].ToString());
                        taxtotaltb.Text = (reader["Tax_Total"].ToString());
                        discounttb.Text = (reader["Discount"].ToString());
                        taxtb.Text = (reader["Tax"].ToString());
                        totaltb.Text = (reader["Total"].ToString());
                        paid2tb.Text = (reader["Paid"].ToString());
                        balancetb.Text = (reader["Balance"].ToString());
                        specialreqtb.Text = (reader["Special_Req"].ToString());
                        usertb.Text = (reader["User"].ToString());
                    }
                    DateTime fromdate = Convert.ToDateTime(checkintb.Text);
                    DateTime todate = Convert.ToDateTime(checkouttb.Text);
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
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                statustb.Enabled = true;
                guestemailtb.Enabled = true;
                guestphonetb.Enabled = true;
                guestcompanytb.Enabled = true;
                checkintb.Enabled = true;
                adultnotb.Enabled = true;
                childnotb.Enabled = true;
                infantnotb.Enabled = true;
                addresstb.Enabled = true;
                citytb.Enabled = true;
                statetb.Enabled = true;
                countrytb.Enabled = true;
                zipcodetb.Enabled = true;
                nettotaltb.Enabled = true;
                roomtotaltb.Enabled = true;
                servicetotaltb.Enabled = true;
                taxtotaltb.Enabled = true;
                discounttb.Enabled = true;
                taxtb.Enabled = true;
                totaltb.Enabled = true;
                paid2tb.Enabled = true;
                balancetb.Enabled = true;
                specialreqtb.Enabled = true;
                usertb.Enabled = true;
                toolStrip1.Enabled = true;
                toolStrip2.Enabled = true;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    datatable2.Clear();
                    ds2.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa= '" + guestname3tb.Text + "' AND Payment_Date between '" + checkintb.Text + "' AND '" + nows + "'", conn);
                    adapter2.SelectCommand = cmd;
                    adapter2.Fill(datatable2);
                    paymentb2.DataSource = datatable2;
                    conn.Close();
                    for (int i = 0; i < paymentb2.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(paymentb2.Rows[i].Cells[5].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                paymentotal = sum;
                try
                {
                    DateTime now = DateTime.Now;
                    string nows = now.ToString("yyyy/MM/dd");
                    conn.Open();
                    cmd.Connection = conn;
                    datatable3.Clear();
                    ds3.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName= '" + guestname3tb.Text + "' AND Date_Recorded between'" + checkintb.Text + "' AND '" + nows + "'", conn);
                    adapter3.SelectCommand = cmd;
                    adapter3.Fill(datatable3);
                    servicetb2.DataSource = datatable3;
                    conn.Close();
                    for (int i = 0; i < servicetb2.Rows.Count; ++i)
                    {
                        sum2 += Convert.ToInt32(servicetb2.Rows[i].Cells[5].Value);
                    }
                    paymentotal2 = sum2;
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
                    roomtb.Items.Clear();
                    cmd = new SqlCommand("SELECT Room_No FROM hm.roomorbed WHERE Name ='N/A' OR Name='" + guestname3tb.Text + "' AND NOT Room_Status='Out of Order'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roomtb.Items.Add(reader["Room_No"].ToString());
                        roomtb.ForeColor = Color.Black;
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
                    cmd = new SqlCommand("SELECT Room_Type FROM hm.roomorbed WHERE Room_No = '" + roomtb.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roomp = reader["Room_Type"].ToString();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                
                codetb.Enabled = false;
                guestname = guestname3tb.Text;
           
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Add_service aser = new Add_service();
            aser.Owner = this;
            aser.checker2 = "edit";
            aser.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Add_payment apay = new Add_payment();
            apay.Owner = this;
            apay.checkerpayment = "edit";
            apay.ShowDialog();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                string nows = now.ToString("yyyy/MM/dd");
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + guestname3tb.Text + "' AND Payment_Date between '" + checkintb.Text + "' AND '" + checkouttb + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                paymentb2.DataSource = datatable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            int sum = 0;
            for(int i=0;i < paymentb2.Rows.Count;++i){
                sum += Convert.ToInt32(paymentb2.Rows[i].Cells[5].Value);
            }
            paymentotal = sum;
            totaltb.Text = totalfinalprice1.ToString();
            finaltotal = paymentotal - totalfinalprice1;
            totalbalance = totalfinalprice1 - paymentotal;
            paid2tb.Text = paymentotal.ToString();
            balancetb.Text = totalbalance.ToString();
            totaltb.Text = totalfinalprice1.ToString();
            servicetotaltb.Text = sum2.ToString();
            nettotaltb.Text = sum2.ToString();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                string nows = now.ToString("yyyy/MM/dd");
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName= '" + guestname3tb.Text + "' AND Date_Recorded between'" + checkintb.Text + "' AND '" + checkouttb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicetb2.DataSource = datatable3;
                conn.Close();
            int sum2 = 0;
            for (int i = 0; i < servicetb2.Rows.Count; ++i)
            {
                sum2 += Convert.ToInt32(servicetb2.Rows[i].Cells[5].Value);
            }
            paymentotal2 = sum2;
            totaltb.Text = totalfinalprice1.ToString();
            finaltotal = paymentotal - totalfinalprice1;
            totalbalance = totalfinalprice1 - paymentotal;
            paid2tb.Text = paymentotal.ToString();
            balancetb.Text = totalbalance.ToString();
            totaltb.Text = totalfinalprice1.ToString();
            servicetotaltb.Text = sum2.ToString();
            nettotaltb.Text = sum2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void servicetb2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            update_service use = new update_service();
            use.Owner = this;
            use.checker3 = "edit";
            use.ShowDialog();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            update_payment upay = new update_payment();
            upay.checkereditres = "edit";
            upay.Owner = this;
            upay.ShowDialog();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            delete_services dse = new delete_services();

            dse.ShowDialog();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            delete_payment dpa = new delete_payment();
            dpa.ShowDialog();
        }

        private void guestname3tb_SelectedValueChanged(object sender, EventArgs e)
        {
            codetb.Enabled = true;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable4.Clear();
                ds4.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation WHERE NOT Status='Checked out' AND Guest_Name= '" + guestname3tb.Text + "'", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                guestnamedatatb.DataSource = datatable4;
                conn.Close();
               
                codex = codetb.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            codetb.Clear();
            
            if (guestname == guestname3tb.Text)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void roomtb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_Type FROM hm.roomorbed WHERE Room_No = '" + roomtb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomp = reader["Room_Type"].ToString();
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
                cmd = new SqlCommand("SELECT Rate_per_Day FROM hm.roomrate WHERE Room_Type= '" + roomp + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomp2 = reader["Rate_per_Day"].ToString();
                    roomprice = Convert.ToInt32(roomp2);
                }
                finalprice = (roomprice * days);
                if (days == 0)
                {
                    roomtotaltb.Text = roomprice.ToString();
                    totalfinalprice1 = paymentotal2 + roomprice;
                }
                else
                {
                    roomtotaltb.Text = finalprice.ToString();
                    totalfinalprice1 = paymentotal2 + finalprice;
                }

                totalbalance = totalfinalprice1 - paymentotal;
                totaltb.Text = totalfinalprice1.ToString();
                paid2tb.Text = paymentotal.ToString();
                balancetb.Text = totalbalance.ToString();
                totaltb.Text = totalfinalprice1.ToString();
                servicetotaltb.Text = sum2.ToString();
                nettotaltb.Text = sum2.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void totaltb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert4 = totaltb.Text.Replace(cs2, "");
                double newVal4 = Convert.ToDouble(valueToConvert4);
                totaltb.Text = cs2 + Convert.ToString(newVal4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void checkouttb_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(checkintb.Text);
            DateTime todate = Convert.ToDateTime(checkouttb.Text);
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
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_Type FROM hm.roomorbed WHERE Room_No = '" + roomtb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomp = reader["Room_Type"].ToString();
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
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa= '" + guestname3tb.Text + "' AND Payment_Date between '" + checkintb.Text + "' AND '" + checkouttb.Text + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                paymentb2.DataSource = datatable2;
                conn.Close();
                for (int i = 0; i < paymentb2.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(paymentb2.Rows[i].Cells[5].Value);
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
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName= '" + guestname3tb.Text + "' AND Date_Recorded between'" + checkintb.Text + "' AND '" + checkouttb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicetb2.DataSource = datatable3;
                conn.Close();
                for (int i = 0; i < servicetb2.Rows.Count; ++i)
                {
                    sum2 += Convert.ToInt32(servicetb2.Rows[i].Cells[4].Value);
                }
                paymentotal2 = sum2;
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
                cmd = new SqlCommand("SELECT Rate_per_Day FROM hm.roomrate WHERE Room_Type= '" + roomp + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomp2 = reader["Rate_per_Day"].ToString();

                }
                roomprice = Convert.ToInt32(roomp2);
                finalprice = (roomprice * days);
                if (days == 0)
                {
                    roomtotaltb.Text = roomprice.ToString();
                    totalfinalprice1 = paymentotal2 + roomprice;
                }
                else
                {
                    roomtotaltb.Text = finalprice.ToString();
                    totalfinalprice1 = paymentotal2 + finalprice;
                }
                conn.Close();
                totalbalance = totalfinalprice1 - paymentotal;
                totaltb.Text = totalfinalprice1.ToString();
                paid2tb.Text = paymentotal.ToString();
                balancetb.Text = totalbalance.ToString();
                totaltb.Text = totalfinalprice1.ToString();
                servicetotaltb.Text = sum2.ToString();
                nettotaltb.Text = sum2.ToString();

                checkintb.Enabled = true;
                checkouttb.Enabled = false;
                roomtb.Enabled = true;
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
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa= '" + guestname3tb.Text + "' AND Payment_Date between '" + checkintb.Text + "' AND '" + checkouttb.Text + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                paymentb2.DataSource = datatable2;
                conn.Close();
                int sum = 0;
                for (int i = 0; i < paymentb2.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(paymentb2.Rows[i].Cells[5].Value);
                }
                paymentotal = sum;
                totaltb.Text = totalfinalprice1.ToString();
                finaltotal = paymentotal - totalfinalprice1;
                totalbalance = totalfinalprice1 - paymentotal;
                paid2tb.Text = paymentotal.ToString();
                balancetb.Text = totalbalance.ToString();
                totaltb.Text = totalfinalprice1.ToString();
                servicetotaltb.Text = sum2.ToString();
                nettotaltb.Text = sum2.ToString();
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
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName= '" + guestname3tb.Text + "' AND Date_Recorded between'" + checkintb.Text + "' AND '" + checkouttb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicetb2.DataSource = datatable3;
                conn.Close();
                int sum2 = 0;
                for (int i = 0; i < servicetb2.Rows.Count; ++i)
                {
                    sum2 += Convert.ToInt32(servicetb2.Rows[i].Cells[4].Value);
                }
                paymentotal2 = sum2;
                totaltb.Text = totalfinalprice1.ToString();
                finaltotal = paymentotal - totalfinalprice1;
                totalbalance = totalfinalprice1 - paymentotal;
                paid2tb.Text = paymentotal.ToString();
                balancetb.Text = totalbalance.ToString();
                totaltb.Text = totalfinalprice1.ToString();
                servicetotaltb.Text = sum2.ToString();
                nettotaltb.Text = sum2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void restrictiontb_CheckedChanged(object sender, EventArgs e)
        {
        
            
        }
        private void guestname3tb_Click(object sender, EventArgs e)
        {
            if (restrictiontb.Checked == true)
            {
                conn.Open();
                cmd.Connection = conn;
                guestname3tb.Items.Clear();
                cmd = new SqlCommand("SELECT Guest_Name FROM hm.reservation", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestname3tb.Items.Add(reader["Guest_Name"].ToString());
                    guestname3tb.ForeColor = Color.Black;
                }
                cmd.Dispose();
                conn.Close();
                guestname3tb.Text = "Select Guest Name";
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                guestname3tb.Items.Clear();
                cmd = new SqlCommand("SELECT Guest_Name FROM hm.reservation WHERE NOT Status='Checked out'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestname3tb.Items.Add(reader["Guest_Name"].ToString());
                    guestname3tb.ForeColor = Color.Black;
                }
                cmd.Dispose();
                conn.Close();
                guestname3tb.Text = "Select Guest Name";
                
            }
          
        }
        private void checkintb_CloseUp(object sender, EventArgs e)
        {
            checkouttb.Enabled = true;
            checkintb.Enabled = false;
            roomtb.Enabled = false;

        }

        private void codetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomtotaltb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert = roomtotaltb.Text.Replace(cs2, "");
                double newVal = Convert.ToDouble(valueToConvert);
                roomtotaltb.Text = cs2 + Convert.ToString(newVal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void servicetotaltb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert2 = servicetotaltb.Text.Replace(cs2, "");
                double newVal2 = Convert.ToDouble(valueToConvert2);
                servicetotaltb.Text = cs2 + Convert.ToString(newVal2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void nettotaltb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert3 = nettotaltb.Text.Replace(cs2, "");
                double newVal3 = Convert.ToDouble(valueToConvert3);
                nettotaltb.Text = cs2 + Convert.ToString(newVal3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void paid2tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert5 = paid2tb.Text.Replace(cs2, "");
                double newVal5 = Convert.ToDouble(valueToConvert5);
                paid2tb.Text = cs2 + Convert.ToString(newVal5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void balancetb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert6 = balancetb.Text.Replace(cs2, "");
                double newVal6 = Convert.ToDouble(valueToConvert6);
                balancetb.Text = cs2 + Convert.ToString(newVal6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void checkouttb_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void countrytb_SelectedValueChanged(object sender, EventArgs e)
        {
            statetb.Items.Clear();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT major_area FROM hm.zipcodes WHERE country='" + countrytb.Text + "' GROUP BY major_area ORDER BY major_area ASC", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statetb.Items.Add(reader["major_area"].ToString());
            }
            conn.Close();
        }

        private void statetb_SelectedValueChanged(object sender, EventArgs e)
        {
            citytb.Items.Clear();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT city FROM hm.zipcodes WHERE major_area='" + statetb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                citytb.Items.Add(reader["city"].ToString());
            }
            conn.Close();
        }

        private void citytb_SelectedValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT zip_code FROM hm.zipcodes WHERE city='" + citytb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                zipcodetb.Text = (reader["zip_code"].ToString());
            }
            conn.Close();
        }

        private void guestname3tb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkouttb_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

    
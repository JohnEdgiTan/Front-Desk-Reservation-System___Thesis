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
    public partial class Addreservation : Form
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
        int codescheckin;
        int paymentotal;
        int paymentotal2;
        int totalbalance;
        int totalfinalprice1;
        int roomprice;
        string roomp;
        string roomp2;
        int finalprice;
        int days;
        string days2;
        int sum2 = 0;
        string timespan1;
        string timespan2;
        string cs;
        string maxcodecheckin;
        int finalcheckin;
        string roomstatus;
        int sum = 0;
        int x = 0;
        int y = 0;
        string insert;
        public string checker;
        int counter;
        int counter2;
        string queryString;
        string statusget;
        public Addreservation()
        {
            InitializeComponent();
        }
        public void Alert(string msg, FormAlertYellow.enmType type)
        {
            FormAlertYellow frt = new FormAlertYellow();
            frt.showAlert(msg, type);
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {

            toolStrip1.Enabled = false;
            toolStrip2.Enabled = false;
            guestnametb.Text = "Select Guest";
            roomtb.Text = "Select Room";
            countrytb.Text = "Select a Country";
            statetb.Text = "Select a Province";
            citytb.Text = "Select a City";
            checkintb.MinDate = System.DateTime.Now;

            if (checker == "reservation")
            {
                usertttb.Text = (this.Owner as Reservation).label5.Text;
            }
            else
            {
                usertttb.Text = (this.Owner as mainmenuform).usernameee.Text;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomrate", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                roomratetttb.DataSource = datatable;
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
            guestnametb.Items.Clear();
            cmd = new SqlCommand("SELECT Name FROM hm.guests", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guestnametb.Items.Add(reader["Name"].ToString());
                guestnametb.ForeColor = Color.Black;
            }
            conn.Close();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT hm.reservation.Guest_Name FROM hm.reservation INNER JOIN hm.guests ON hm.reservation.Guest_Name=hm.guests.Name WHERE hm.reservation.Status='Checked in' OR hm.reservation.Status='Reserved'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guestnametb.Items.Remove(reader["Guest_Name"].ToString());
            }
            conn.Close();;
                guestnametb.AutoCompleteMode = AutoCompleteMode.Suggest;
                guestnametb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
                getData(combData);
                guestnametb.AutoCompleteCustomSource = combData;
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
                cmd = new SqlCommand("SELECT MAX(Res_ID) AS Code FROM hm.reservation", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxcodecheckin = (reader["Code"].ToString());
                }
                if (maxcodecheckin == "")
                {
                    finalcheckin = 1;
                }
                else
                {
                    codescheckin = Convert.ToInt32(maxcodecheckin);
                    finalcheckin = codescheckin + 1;
                }
                codetb.Text = finalcheckin.ToString();
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
                cmd = new SqlCommand("SELECT Room_No FROM hm.roomorbed WHERE Name ='N/A' AND NOT Room_Status='Out of Order'", conn);
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
            checkouttb.Enabled = false;
            roomtb.Enabled = false;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    timespan1 = Convert.ToDateTime(reader["Checkinstart"]).ToString("HH:mm:ss");
                    timespan2 = Convert.ToDateTime(reader["Checkinend"]).ToString("HH:mm:ss");
                }
                conn.Close();
                DateTime dt1 = Convert.ToDateTime(timespan1);
                DateTime dt2 = Convert.ToDateTime(timespan2);
                TimeSpan cit = new TimeSpan(dt1.Hour, dt1.Minute, dt1.Second);
                TimeSpan ciet = new TimeSpan(dt2.Hour, dt2.Minute, dt2.Second);
                TimeSpan now = DateTime.Now.TimeOfDay;
                if ((now > cit) && (now < ciet))
                {
                    statustb.Text = "Select Status";
                    statustb.Items.Add("Checked in");
                    statustb.Items.Add("Reserved");
                }
                else
                {
                    statustb.Text = "Select Status";
                    statustb.Items.Add("Reserved");
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
                cmd = new SqlCommand("SELECT * FROM hm.checkincheckoutdatedeadline", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cs = (reader["CurrencySymbol"].ToString());
                }
                conn.Close();
                string valueToConvert = roomtotaltb.Text.Replace(cs, "");
                double newVal = Convert.ToDouble(valueToConvert);
                roomtotaltb.Text = cs + Convert.ToString(newVal);
                string valueToConvert2 = servicetotaltb.Text.Replace(cs, "");
                double newVal2 = Convert.ToDouble(valueToConvert2);
                servicetotaltb.Text = cs + Convert.ToString(newVal2);
                string valueToConvert3 = nettotaltb.Text.Replace(cs, "");
                double newVal3 = Convert.ToDouble(valueToConvert3);
                nettotaltb.Text = cs + Convert.ToString(newVal3);
                string valueToConvert4 = totaltb.Text.Replace(cs, "");
                double newVal4 = Convert.ToDouble(valueToConvert4);
                totaltb.Text = cs + Convert.ToString(newVal4);
                string valueToConvert5 = paidtb.Text.Replace(cs, "");
                double newVal5 = Convert.ToDouble(valueToConvert5);
                paidtb.Text = cs + Convert.ToString(newVal5);
                string valueToConvert6 = balancetb.Text.Replace(cs, "");
                double newVal6 = Convert.ToDouble(valueToConvert6);
                balancetb.Text = cs + Convert.ToString(newVal6);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            try
            {
                DateTime now = DateTime.Now;
                string nows = now.ToString("yyyy/MM/dd");
                sum2 = 0;
                paymentotal2 = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName ='" + guestnametb.Text + "' AND Date_Recorded between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicetb.DataSource = datatable3;
                conn.Close();
                for (int i = 0; i < servicetb.Rows.Count; ++i)
                {
                    sum2 += Convert.ToInt32(servicetb.Rows[i].Cells[5].Value);
                    counter2++;
                }
                paymentotal2 = sum2 + paymentotal;
                y = paymentotal2 - sum2;
                if (y <= sum)
                {
                    totalbalance = totalfinalprice1 - paymentotal2;
                    totaltb.Text = totalfinalprice1.ToString();
                    paidtb.Text = paymentotal2.ToString();
                    balancetb.Text = totalbalance.ToString();
                    totaltb.Text = totalfinalprice1.ToString();
                    servicetotaltb.Text = sum2.ToString();
                    nettotaltb.Text = sum2.ToString();
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
                DateTime now = DateTime.Now;
                string nows = now.ToString("yyyyMMdd");
                paymentotal = 0;
                x = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + guestnametb.Text + "' AND Payment_Date between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                paymentstb.DataSource = datatable2;
                conn.Close();
                sum = 0;
                for (int i = 0; i < paymentstb.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(paymentstb.Rows[i].Cells[5].Value);
                    counter++;
                }
                paymentotal = sum + paymentotal2;
                x = paymentotal - sum;
                if (x <= sum2)
                {

                    totalbalance = totalfinalprice1 - paymentotal;
                    totaltb.Text = totalfinalprice1.ToString();
                    paidtb.Text = paymentotal.ToString();
                    balancetb.Text = totalbalance.ToString();
                    totaltb.Text = totalfinalprice1.ToString();
                    servicetotaltb.Text = sum2.ToString();
                    nettotaltb.Text = sum2.ToString();
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
        private void getData(AutoCompleteStringCollection dataCollection)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Name FROM hm.guests", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(ds);
                adapter1.Dispose();
                cmd.Dispose();
                conn.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed with Reservation details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    insert = "";
                    if (roomtb.Text == "Select Room" || guestnametb.Text == "Select Guest"||statustb.Text =="Select Status")
                    {
                        MessageBox.Show("Pls Fill in every information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO hm.reservation (Res_ID,Status,Room,Guest_Name,Guest_Email,Guest_Phone,Guest_Company,Check_in,Check_Out,Adult_No,Child_No,Infant_No,Net_Total,Room_Total,Service_Total,Tax_Total,Discount,Tax,Total,Paid,Balance,Special_Req,Booking_Time,[User],Address,City,State,Country,Zip_Code) VALUES ('" + codetb.Text + "','" + statustb.Text + "','" + roomtb.Text + "','" + guestnametb.Text + "','" + guestemailtb.Text + "','" + guestphonetb.Text + "','" + guestcompanytb.Text + "','" + checkintb.Text + "','" + checkouttb.Text + "','" + adultnotb.Text + "','" + childnotb.Text + "','" + infantnotb.Text + "','" + nettotaltb.Text + "','" + roomtotaltb.Text + "','" + servicetotaltb.Text + "','" + taxtotaltb.Text + "','" + discounttb.Text + "','" + taxtb.Text + "','" + totaltb.Text + "','" + paidtb.Text + "','" + balancetb.Text + "','" + specialreqtb.Text + "','" + booktimetb.Text + "','" + usertttb.Text + "','" + addresstb.Text + "','" + citytb.Text + "','" + statetb.Text + "','" + countrytb.Text + "','" + zipcodetb.Text + "')";
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return;
                        }
                        this.Update();
                        MessageBox.Show("Successfully Reserved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            datatable.Clear();
                            ds.Clear();
                            cmd = new SqlCommand("UPDATE hm.roomorbed SET Name = '" + guestnametb.Text + "' WHERE Room_No ='" + roomtb.Text + "'", conn);
                            reader = cmd.ExecuteReader();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return;
                        }
                        insert = "insert";
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            queryString = "SELECT Status FROM hm.reservation WHERE Guest_Name = '" + guestnametb.Text + "'AND Guest_Email = '" + guestemailtb.Text + "'";
                            SqlCommand query;
                            query = new SqlCommand(queryString, conn);
                            reader = query.ExecuteReader();
                            while (reader.Read())
                            {
                                statusget = reader["Status"].ToString();
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return;
                        }
                        if (statusget == "Reserved") 
                        {
                            this.Alert("You have successfully recorded the reservation of " + guestnametb.Text + " ", FormAlertYellow.enmType.Reservation);
                        }
                        else
                        {
                            this.Alert("You have successfully recorded the Check in of " + guestnametb.Text + " ", FormAlertYellow.enmType.Checkedin);
                        }
                        (this.Owner as Reservation).secretrefresh.PerformClick();
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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Add_Guest agu = new Add_Guest();
            agu.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Add_payment apa = new Add_payment();
            apa.checkerpayment = "checkin";
            apa.Owner = this;
            apa.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Company,Email,Phone1,Address,Country,State,City,Zip_Code FROM hm.guests WHERE Name= '" + guestnametb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestcompanytb.Text = (reader["Company"].ToString());
                    guestemailtb.Text = (reader["Email"].ToString());
                    guestphonetb.Text = (reader["Phone1"].ToString());
                    addresstb.Text = (reader["Address"].ToString());
                    countrytb.Text = (reader["Country"].ToString());
                    statetb.Text = (reader["State"].ToString());
                    citytb.Text = (reader["City"].ToString());
                    zipcodetb.Text = (reader["Zip_Code"].ToString());
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            toolStrip1.Enabled = true;
            toolStrip2.Enabled = true;
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Add_service ase = new Add_service();
            ase.Owner = this;
            ase.checker2 = "checkin";
            ase.ShowDialog();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            update_payment upam = new update_payment();
            upam.checkereditres = "checkin";
            upam.Owner = this;
            upam.ShowDialog();
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            update_service userv = new update_service();
            userv.Owner = this;
            userv.checker3 = "checkin";
            userv.ShowDialog();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            delete_payment depay = new delete_payment();
            depay.ShowDialog();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            delete_services deser = new delete_services();
            deser.ShowDialog();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                string nows = now.ToString("yyyy/MM/dd");
                paymentotal = 0;
                x = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.paymentss WHERE GuestNa ='" + guestnametb.Text + "' AND Payment_Date between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                paymentstb.DataSource = datatable2;
                conn.Close();
                sum = 0;
                for (int i = 0; i < paymentstb.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(paymentstb.Rows[i].Cells[5].Value);
                    counter++;
                }
                paymentotal = sum - paymentotal2;
                x = paymentotal - sum;
                if (x<=sum2)
                {
                    
                    totalbalance = totalfinalprice1 - paymentotal;
                    totaltb.Text = totalfinalprice1.ToString();
                    paidtb.Text = paymentotal.ToString();
                    balancetb.Text = totalbalance.ToString();
                    totaltb.Text = totalfinalprice1.ToString();
                    servicetotaltb.Text = sum2.ToString();
                    nettotaltb.Text = sum2.ToString();
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
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                 string nows= now.ToString("yyyy/MM/dd");
                sum2 = 0;
                paymentotal2 = 0;
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.services WHERE GuestName ='" + guestnametb.Text + "' AND Date_Recorded between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                servicetb.DataSource = datatable3;
                conn.Close();
                for (int i = 0; i < servicetb.Rows.Count; ++i)
                {
                    sum2 += Convert.ToInt32(servicetb.Rows[i].Cells[5].Value);
                    
                    counter2++;
                }
                paymentotal2 = totalfinalprice1+sum2;
                y = paymentotal2 - sum2;
                if (y<=sum)
                {
                    totalbalance = totalfinalprice1 - sum2;
                    totaltb.Text = totalfinalprice1.ToString();
                    paidtb.Text = paymentotal.ToString();
                    balancetb.Text = totalbalance.ToString();
                    totaltb.Text = totalfinalprice1.ToString();
                    servicetotaltb.Text = sum2.ToString();
                    nettotaltb.Text = sum2.ToString();
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
        public void checkouttb_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(checkintb.Text);
            DateTime todate = Convert.ToDateTime(checkouttb.Text);
            if (fromdate <= todate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
                days = Convert.ToInt16(ts.Days);
                days2 = days.ToString();

            }
            else {
                MessageBox.Show("Error");
                return;
            }
            checkouttb.Enabled = false;
            roomtb.Enabled = true;
            checkintb.Enabled = true;
            
        }
        private void roomtb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_Type,Room_Status FROM hm.roomorbed WHERE Room_No = '" + roomtb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomp = reader["Room_Type"].ToString();
                    roomstatus = reader["Room_Status"].ToString();
                }
                conn.Close();
                if (roomstatus == "Vacant Dirty"||roomstatus=="Vacant Clean")
                {
                    DialogResult dr2 = MessageBox.Show("Current Room Status is Vacant Dirty or Vacant Clean. Would you like to change it to Vacant Ready?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd = new SqlCommand("UPDATE hm.roomorbed SET Room_Status ='Vacant Ready' WHERE Room_No ='" + roomtb.Text + "'", conn);
                        reader = cmd.ExecuteReader();
                        this.Update();
                        conn.Close();
                        MessageBox.Show("Successfully Changed", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                paidtb.Text = paymentotal.ToString();
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
        private void guestphonetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void codetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void postalcodetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void roomtotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void servicetotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void nettotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void discounttb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void taxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void taxtotaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void totaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void paidtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void balancetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void guestnametb_Click(object sender, EventArgs e)
        {
            guestnametb.Items.Clear();
            guestnametb.Text = "";
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT Name from hm.guests;", conn);
    
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guestnametb.Items.Add(reader["Name"].ToString());
                guestnametb.ForeColor = Color.Black;
            }
            conn.Close();
            conn.Open();
            cmd.Connection = conn;
            cmd = new SqlCommand("SELECT hm.reservation.Guest_Name FROM hm.reservation INNER JOIN hm.guests ON hm.reservation.Guest_Name=hm.guests.Name WHERE hm.reservation.Status='Checked in' OR hm.reservation.Status='Reserved'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guestnametb.Items.Remove(reader["Guest_Name"].ToString());
            }
            conn.Close();
        }
        private void checkintb_CloseUp(object sender, EventArgs e)
        {
            checkouttb.Enabled = true;
            checkintb.Enabled = false;
            checkouttb.MinDate = checkintb.Value;
        }

        private void statustb_Click(object sender, EventArgs e)
        {
           
        }

        private void roomtotaltb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert = roomtotaltb.Text.Replace(cs, "");
                double newVal = Convert.ToDouble(valueToConvert);
                roomtotaltb.Text = cs + Convert.ToString(newVal);
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
                string valueToConvert2 = servicetotaltb.Text.Replace(cs, "");
                double newVal2 = Convert.ToDouble(valueToConvert2);
                servicetotaltb.Text = cs + Convert.ToString(newVal2);
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
                string valueToConvert3 = nettotaltb.Text.Replace(cs, "");
                double newVal3 = Convert.ToDouble(valueToConvert3);
                nettotaltb.Text = cs + Convert.ToString(newVal3);
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
                string valueToConvert4 = totaltb.Text.Replace(cs, "");
                double newVal4 = Convert.ToDouble(valueToConvert4);
                totaltb.Text = cs + Convert.ToString(newVal4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void paidtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueToConvert5 = paidtb.Text.Replace(cs, "");
                double newVal5 = Convert.ToDouble(valueToConvert5);
                paidtb.Text = cs + Convert.ToString(newVal5);
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
                string valueToConvert6 = balancetb.Text.Replace(cs, "");
                double newVal6 = Convert.ToDouble(valueToConvert6);
                balancetb.Text = cs + Convert.ToString(newVal6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomtb_Click(object sender, EventArgs e)
        {
            try
            {
                roomtb.Items.Clear();
                roomtb.Text = "";
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT Room_No FROM hm.roomorbed WHERE Name ='N/A' AND NOT Room_Status='Out of Order'", conn);
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
        }
        private void guestnametb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Addreservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (counter==0 && counter2==0)
            {
                this.Hide();
            }
            else
            {
                if (insert == "insert")
                {
                    this.Hide();
                }
                else
                {
                    if (e.CloseReason == CloseReason.UserClosing)
                    {
                        dynamic mboxResult = MessageBox.Show("Cancelling will delete current saved Payment info and Service, Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo);
                        if (mboxResult == DialogResult.No)
                        {
                            e.Cancel = true;
                        }

                        else if (mboxResult == DialogResult.Yes)
                        {
                            try
                            {
                                DateTime now = DateTime.Now;
                                string nows = now.ToString("yyyyMMdd");
                                conn.Open();
                                cmd.Connection = conn;
                                cmd = new SqlCommand("DELETE FROM hm.services WHERE GuestName ='" + guestnametb.Text + "' AND Date_Recorded between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                                cmd.ExecuteNonQuery();
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
                                DateTime now = DateTime.Now;
                                string nows = now.ToString("yyyyMMdd");
                                conn.Open();
                                cmd.Connection = conn;
                                cmd = new SqlCommand("DELETE FROM hm.paymentss WHERE GuestNa ='" + guestnametb.Text + "' AND Payment_Date between '" + nows + "' AND '" + checkouttb.Text + "'", conn);
                                cmd.ExecuteNonQuery();
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
                }
            }
        }
        private void statetb_Click(object sender, EventArgs e)
        {
            try
            {
                statetb.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void citytb_Click(object sender, EventArgs e)
        {
            try
            {
                citytb.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void citytb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void guestnametb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void countrytb_Click(object sender, EventArgs e)
        {
            countrytb.Text = "";
        }
    }
}

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
    public partial class Rooms : Form
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
        DataTable datatable6 = new DataTable();
        SqlDataAdapter adapter6 = new SqlDataAdapter();
        DataSet ds6 = new DataSet();
        SqlDataReader reader;
        public Rooms()
        {

            InitializeComponent();
        }
        private void Rooms_Load(object sender, EventArgs e)
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
            roomtable.BackColor = Color.PaleGreen;
            roomtypetable.BackColor = Color.MediumAquamarine;
            roomratetable.BackColor = Color.MediumAquamarine;
            roomstatustb.SelectedIndex = 0;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                roomsdata.DataSource = datatable;
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
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes4", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notes5.Text = (reader["Notes4"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes4", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                noteslistdg4.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable5.Clear();
                ds5.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservation", conn);
                adapter5.SelectCommand = cmd;
                adapter5.Fill(datatable5);
                reservationdatadash.DataSource = datatable5;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable6.Clear();
                ds6.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                adapter6.SelectCommand = cmd;
                adapter6.Fill(datatable6);
                roomdatadash.DataSource = datatable6;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            for (int i = 1; i <= roomdatadash.Rows.Count; i++)
            {
                Button b = new Button();
                b.Text = Convert.ToString(roomdatadash.Rows[i - 1].Cells[2].Value);
                b.Name = Convert.ToString(roomdatadash.Rows[i - 1].Cells[2].Value);
                b.Height = 50;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 3;
                b.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
                b.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
                b.Location = new Point(3, 3);
                for (int x = 1; x <= reservationdatadash.Rows.Count; x++)
                {
                    if ((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value) == "Vacant Clean"))
                    {
                        b.FlatAppearance.BorderColor = Color.DodgerBlue;
                    }
                    else if ((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value) == "Vacant Dirty"))
                    {
                        b.FlatAppearance.BorderColor = Color.Crimson;
                    }
                    else if ((Convert.ToString(roomdatadash.Rows[i - 1].Cells[9].Value) == "Vacant Ready"))
                    {
                        b.FlatAppearance.BorderColor = Color.LawnGreen;
                    }
                    else
                    {
                        b.FlatAppearance.BorderColor = Color.Black;
                    }
                    if (Convert.ToString(roomdatadash.Rows[i - 1].Cells[1].Value) == "N/A")
                    {
                        b.BackColor = Color.White;
                    }
                    else
                    {
                        if (b.Text == (Convert.ToString(reservationdatadash.Rows[x - 1].Cells[2].Value)))
                        {
                            if ((Convert.ToString(reservationdatadash.Rows[x - 1].Cells[1].Value)) == "Checked in")
                            {
                                b.BackColor = Color.SpringGreen;
                            }
                            else if ((Convert.ToString(reservationdatadash.Rows[x - 1].Cells[1].Value)) == "Reserved")
                            {
                                b.BackColor = Color.Yellow;
                            }
                            else
                            {
                                b.BackColor = Color.Orange;
                            }
                        }
                    }
                }
                if (b.Text == "")
                {
                    flowLayoutPanel1.Controls.Remove(b);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(b);
                }



            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * from hm.roomorbed WHERE Room_No = '" + roomsearchtb.Text + "'", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                roomsdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomsearchtb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void roomstatustb_Click(object sender, EventArgs e)
        {
  
        }

        private void roomstatustb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (roomstatustb.Equals("Clean"))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='" + roomstatustb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    roomsdata.DataSource = datatable;
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed WHERE Room_Status='" + roomstatustb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    roomsdata.DataSource = datatable;
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
        private void btnote_Click(object sender, EventArgs e)
        {
            DateTime Datenow = DateTime.Now;
            string datenote;
            string datetimenote;
            string userinforoomorbed = (this.Owner as mainmenuform).usernameee.Text;
            datenote = Datenow.ToString("yyyy/MM/dd");
            datetimenote = Datenow.ToString("HH:mm:ss");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO hm.reservationnotes4 (Notes4,date4,time4,[User4]) VALUES ('" + notes5.Text + "','" + datenote + "','" + datetimenote + "','" + userinforoomorbed + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable3.Clear();
                ds3.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.reservationnotes4", conn);
                adapter3.SelectCommand = cmd;
                adapter3.Fill(datatable3);
                noteslistdg4.DataSource = datatable3;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrowdown_Click(object sender, EventArgs e)
        {
            notesplitter.SplitterDistance = 2000;
            arrowup.Visible = true;
            arrowdown.Visible = false;
        }

        private void arrowup_Click(object sender, EventArgs e)
        {
            notesplitter.SplitterDistance = 400;
            arrowdown.Visible = true;
            arrowup.Visible = false;
        }

        private void actioncb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (actioncb.Text == "Add")
            {
                Add_room aro = new Add_room();
                aro.ShowDialog();
            }
            else if (actioncb.Text == "Edit")
            {
                update_room uro = new update_room();
                uro.ShowDialog();
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
                        cmd = new SqlCommand("DELETE from hm.roomorbed WHERE Room_No = '" + roomsearchtb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        roomsdata.DataSource = datatable;
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
                    cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    roomsdata.DataSource = datatable;
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
                if (roomtable.BackColor == Color.PaleGreen)
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        roomsdata.DataSource = datatable;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                }
                else if(roomtypetable.BackColor == Color.PaleGreen)
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
                        adapter4.SelectCommand = cmd;
                        adapter4.Fill(datatable4);
                        roomsdata.DataSource = datatable4;
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
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable2.Clear();
                        ds2.Clear();
                        cmd = new SqlCommand("SELECT * FROM hm.roomrate", conn);
                        adapter2.SelectCommand = cmd;
                        adapter2.Fill(datatable2);
                        roomsdata.DataSource = datatable2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            roomtable.BackColor = Color.PaleGreen;
            roomtypetable.BackColor = Color.MediumAquamarine;
            roomratetable.BackColor = Color.MediumAquamarine;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomorbed", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                roomsdata.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomtypetable_Click(object sender, EventArgs e)
        {
            roomtable.BackColor = Color.MediumAquamarine;
            roomtypetable.BackColor = Color.PaleGreen;
            roomratetable.BackColor = Color.MediumAquamarine;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomtype", conn);
                adapter4.SelectCommand = cmd;
                adapter4.Fill(datatable4);
                roomsdata.DataSource = datatable4;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }

        private void roomratetable_Click(object sender, EventArgs e)
        {
            roomtable.BackColor = Color.MediumAquamarine;
            roomtypetable.BackColor = Color.MediumAquamarine;
            roomratetable.BackColor = Color.PaleGreen;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable2.Clear();
                ds2.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.roomrate", conn);
                adapter2.SelectCommand = cmd;
                adapter2.Fill(datatable2);
                roomsdata.DataSource = datatable2;
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

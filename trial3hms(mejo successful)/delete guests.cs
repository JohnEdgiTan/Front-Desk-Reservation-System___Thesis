﻿using System;
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
    public partial class delete_guests : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataSet mydataset = new DataSet();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public delete_guests()
        {
            InitializeComponent();
        }
        private void delete_guests_Load(object sender, EventArgs e)
        {
            try
            {
                guestnametb.Text = "Select Guest Name";
                conn.Open();
                cmd.Connection = conn;
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnametb.Items.Add(reader["Name"].ToString());
                    guestnametb.ForeColor = Color.Black;
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
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationtb.DataSource = datatable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (guestemailtb.Text == "")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests WHERE Name= '" + guestnametb.Text + "'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
                    conn.Close();
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
                    conn.Open();
                    cmd.Connection = conn;
                    datatable.Clear();
                    ds.Clear();
                    cmd = new SqlCommand("SELECT * FROM hm.guests WHERE Name= '" + guestnametb.Text + "' AND Email='"+guestemailtb.Text+"'", conn);
                    adapter1.SelectCommand = cmd;
                    adapter1.Fill(datatable);
                    reservationtb.DataSource = datatable;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (guestemailtb.Text == "")
            {
                try
                {
                    DialogResult dr2 = MessageBox.Show("This Deletes All Records With the Guest Name would you still like to Proceed to Delete Record/s?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("DELETE from hm.guests WHERE Name = '" + guestnametb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationtb.DataSource = datatable;
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
            }
            else
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
                        cmd = new SqlCommand("DELETE from hm.guests WHERE Name = '" + guestnametb.Text + "' AND Email = '" + guestemailtb.Text + "'", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationtb.DataSource = datatable;
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
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                datatable.Clear();
                ds.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                adapter1.SelectCommand = cmd;
                adapter1.Fill(datatable);
                reservationtb.DataSource = datatable;
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
            try
            {
                DialogResult dr2 = MessageBox.Show("Proceed to Deleting All Records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr2 == DialogResult.Yes)
                {
                    DialogResult dr3 = MessageBox.Show("Warning! Are sure in permanently deleteing all the records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr3 == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        datatable.Clear();
                        ds.Clear();
                        cmd = new SqlCommand("DELETE from hm.guests", conn);
                        adapter1.SelectCommand = cmd;
                        adapter1.Fill(datatable);
                        reservationtb.DataSource = datatable;
                        conn.Close();
                        MessageBox.Show("Successfully Deleted All Records", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else {
                        return;
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
            }
        }

        private void guestnametb_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                guestnametb.Items.Clear();
                cmd = new SqlCommand("SELECT * FROM hm.guests", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    guestnametb.Items.Add(reader["Name"].ToString());
                    guestnametb.ForeColor = Color.Black;
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
}

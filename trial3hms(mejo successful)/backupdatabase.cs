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
using System.Configuration;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class backupdatabase : Form
    {

        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        string sql = "";
        public backupdatabase()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr3 = MessageBox.Show("Confirm back up database", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr3 == DialogResult.Yes)
                {
                    try
                    {
                        if(ComboBoxDatabaseName.Text=="" || ComboBoxDatabaseName.Text=="Select Database Name")
                        {
                            MessageBox.Show("Please Select a Database", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        conn.Open();
                        sql = "BACKUP DATABASE ["+ComboBoxDatabaseName.Text +"] TO DISK = '" + browserfiletb.Text +"\\"+ filename.Text+".bak'";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                    MessageBox.Show("Backed up Successfully!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               browserfiletb.Text = dlg.SelectedPath;
            }
        }
        private void backupdatabase_Load(object sender, EventArgs e)
        {
            backupgb.Anchor = AnchorStyles.None;
            backupgb.Location =
                new Point(ClientSize.Width / 2 - backupgb.Size.Width / 2,
                 ClientSize.Height / 2 - backupgb.Size.Height / 2);
            conn.Open();
            sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            ComboBoxDatabaseName.Items.Clear();
            while (reader.Read())
            {
                ComboBoxDatabaseName.Items.Add(reader[0].ToString());
            }
            conn.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string ConnectionString

        {

            get

            {

                return ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            }

        }

        private void ComboBoxDatabaseName_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            ComboBoxDatabaseName.Items.Clear();
            while (reader.Read())
            {
                ComboBoxDatabaseName.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Restoredatabase bbd = new Restoredatabase();
            bbd.Owner = this;
            bbd.TopLevel = false;
            bbd.TopMost = true;
            bbd.Dock = DockStyle.Fill;
            (this.Owner as reservationmenu).newuipanel.Controls.Add(bbd);
            bbd.Show();
            bbd.BringToFront();
            (this.Owner as reservationmenu).newuipanel.Update();
        }
    }
}

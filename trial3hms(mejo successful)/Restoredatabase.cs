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
    public partial class Restoredatabase : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable datatable = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader reader;
        string sql = "";
        public Restoredatabase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0; 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename.Text = dlg.FileName;
            }
        }
        private void Restoredatabase_Load(object sender, EventArgs e)
        {

            restoregb.Anchor = AnchorStyles.None;
            restoregb.Location =
                new Point(ClientSize.Width / 2 - restoregb.Size.Width / 2,
                 ClientSize.Height / 2 - restoregb.Size.Height / 2);
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
        private void BackupButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "ALTER DATABASE [" + ComboBoxDatabaseName.Text + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            try
            {
                conn.Open();
                sql = "Restore Database [" + ComboBoxDatabaseName.Text + "] FROM Disk ='" + filename.Text + "';";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            MessageBox.Show("Restored Successfully!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Open();
            sql = "ALTER DATABASE [" + ComboBoxDatabaseName.Text + "] Set MULTI_USER WITH ROLLBACK IMMEDIATE;";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        private void comboBox1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

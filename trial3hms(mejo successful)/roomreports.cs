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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class roomreports : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public roomreports()
        {
            InitializeComponent();
        }

        private void roomreports_Load(object sender, EventArgs e)
        {
            ReportDataSource roomrep = new ReportDataSource("DataSet1", roomreport());
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            reportViewer1.LocalReport.DataSources.Add(roomrep);
            reportViewer1.RefreshReport();
        }
        private DataTable roomreport()
        {
            DataTable datatable = new DataTable();
            if((this.Owner as Daily_occup_rep).checkboxroomno.Checked == true)
            {
                conn.Open();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE hm.roomorbed.Room_No='" + (this.Owner as Daily_occup_rep).roomnotbreport.Text + "' AND Check_in between '" + (this.Owner as Daily_occup_rep).from3tb.Text + "' AND '" + (this.Owner as Daily_occup_rep).to3tb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                datatable.Load(reader);
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,Total,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Check_in between '" + (this.Owner as Daily_occup_rep).from3tb.Text + "' AND '" + (this.Owner as Daily_occup_rep).to3tb.Text + "'", conn);
                reader = cmd.ExecuteReader();
                datatable.Load(reader);
            }
            return datatable;
        }
    }
}

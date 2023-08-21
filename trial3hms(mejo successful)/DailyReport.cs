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
    public partial class DailyReport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private DataTable dailyreport()
        {
            DataTable datatable = new DataTable();
            conn.Open();
            cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Total,Paid,Balance,Status ,Check_in FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Check_in='"+ (this.Owner as Daily_occup_rep).dateofcheckintbdaily.Text+"'", conn);
            reader = cmd.ExecuteReader();
            datatable.Load(reader);
            return datatable;
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource dailyrep = new ReportDataSource("DataSet1", dailyreport());
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(dailyrep);
            reportViewer1.RefreshReport();
        }
    }
}

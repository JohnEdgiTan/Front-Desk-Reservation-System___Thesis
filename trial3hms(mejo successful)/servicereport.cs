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
    public partial class servicereport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public servicereport()
        {
            InitializeComponent();
        }

        private void servicereport_Load(object sender, EventArgs e)
        {
            ReportDataSource servrep = new ReportDataSource("DataSet1", servicereportss());
            reportViewer1.LocalReport.ReportPath = "Report4.rdlc";
            reportViewer1.LocalReport.DataSources.Add(servrep);
            reportViewer1.RefreshReport();
        }
        private DataTable servicereportss()
        {
            DataTable datatable = new DataTable();
            conn.Open();
            cmd = new SqlCommand("SELECT Service_Name,Type,Quantity,Subtotal,Date_Recorded FROM hm.services WHERE Date_Recorded between '" + (this.Owner as Daily_occup_rep).from5tb.Text + "' AND '" + (this.Owner as Daily_occup_rep).to5tb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            datatable.Load(reader);
            return datatable;
        }
    }
}

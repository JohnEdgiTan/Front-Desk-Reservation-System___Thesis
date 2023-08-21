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
    public partial class guestsreport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public guestsreport()
        {
            InitializeComponent();
        }

        private void guestsreport_Load(object sender, EventArgs e)
        {
            ReportDataSource guestrep = new ReportDataSource("DataSet1", guestreport());
            reportViewer1.LocalReport.ReportPath = "Report5.rdlc";
            reportViewer1.LocalReport.DataSources.Add(guestrep);
            reportViewer1.RefreshReport();
        }
        private DataTable guestreport()
        {
            DataTable datatable = new DataTable();
            conn.Open();
            cmd = new SqlCommand("SELECT Guest_Name,hm.guests.Guest_Type,hm.guests.Email,hm.guests.Phone1,hm.guests.Phone2,Check_in,Total,Paid,Balance FROM hm.guests INNER JOIN hm.reservation ON hm.guests.Name=hm.reservation.Guest_Name WHERE Check_in between '" + (this.Owner as Daily_occup_rep).from4tb.Text + "' AND '" + (this.Owner as Daily_occup_rep).to4tb.Text + "'", conn);
            reader = cmd.ExecuteReader();
            datatable.Load(reader);
            return datatable;
        }
    }
}

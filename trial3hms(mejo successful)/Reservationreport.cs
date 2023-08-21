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

    public partial class Reservationreport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = hm; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public Reservationreport()
        {
            InitializeComponent();
        }

        private void Reservationreport_Load(object sender, EventArgs e)
        {
            ReportDataSource reserverep = new ReportDataSource("DataSet1", reservation());
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reserverep);
            reportViewer1.RefreshReport();
        }
        private DataTable reservation()
        {
            DataTable datatable = new DataTable();
            if((this.Owner as Daily_occup_rep).checkboxguestname.Checked == true)
            {
                if ((this.Owner as Daily_occup_rep).choices1reserv.Text == "Check out")
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Guest_Name='" + (this.Owner as Daily_occup_rep).guestnametbreport.Text + "' AND Check_Out between '" + (this.Owner as Daily_occup_rep).fromtbrr.Text + "' AND '" + (this.Owner as Daily_occup_rep).totbrr.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    datatable.Load(reader);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Guest_Name='" + (this.Owner as Daily_occup_rep).guestnametbreport.Text + "'AND Check_in between '" + (this.Owner as Daily_occup_rep).fromtbrr.Text + "' AND '" + (this.Owner as Daily_occup_rep).totbrr.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    datatable.Load(reader);
                }
            }
            else
            {
                if ((this.Owner as Daily_occup_rep).choices1reserv.Text == "Check out")
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Check_Out between '" + (this.Owner as Daily_occup_rep).fromtbrr.Text + "' AND '" + (this.Owner as Daily_occup_rep).totbrr.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    datatable.Load(reader);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT hm.roomorbed.Room_No,hm.roomorbed.Room_Type,hm.roomorbed.Name,Check_in,Check_Out,Total,Paid,Balance,Status,Room_Total,Service_Total,Net_Total FROM hm.roomorbed INNER JOIN hm.reservation ON hm.roomorbed.Room_No=hm.reservation.Room WHERE Check_in between '" + (this.Owner as Daily_occup_rep).fromtbrr.Text + "' AND '" + (this.Owner as Daily_occup_rep).totbrr.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    datatable.Load(reader);
                }
            }
            return datatable;

        }
    }       

}

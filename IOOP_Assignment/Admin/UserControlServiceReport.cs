using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class UserControlServiceReport : UserControl
    {
        public UserControlServiceReport()
        {
            InitializeComponent();
        }

        private void UserControlServiceReport_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                dataGVServiceReport.DataSource = GetServiceReportList();
            }
        }

        private DataTable GetServiceReportList()
        {
            DataTable dt = new DataTable();

            String conString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("select * from ServiceReport", con))
                {
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
            }
            return dt;

        }



}
}

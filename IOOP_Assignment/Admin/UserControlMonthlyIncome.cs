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


namespace IOOPAssignment
{
    public partial class UserControlMonthlyIncome : UserControl
    {
        public UserControlMonthlyIncome()
        {
            InitializeComponent();
        }

        private void UserControlMonthlyIncome_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                dtGVIncome.DataSource = GetIncomeList();

            }
        }
        private DataTable GetIncomeList()
        {
            DataTable dt = new DataTable();

            String conString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Income", con))
                {
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }

            return dt;
        }




    }
}

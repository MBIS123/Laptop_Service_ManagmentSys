using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class CusPayment
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public void loadPaymentTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("select [Order].OrderID,[Customer].Name," +
                " [Types of Service Request].Service Title, [Order].Service Type, " +
                "[Order].Status,[Order].Laptop, [Order].Amount(RM), [Order].Payment Status " +
                "From [dob].[Order] inner join [dob].[Customer] on [Order].CustomerID=Customer.CustomerID inner join " +
                "[dob].[Types of Service Request] on [Order].ServiceRequestTypeID=[Types of Service Request].ServiceRequestTypeID", con);
            
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dtbl;
            con.Close();
        }
    }
}

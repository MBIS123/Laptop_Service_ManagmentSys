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
    internal class Order
    {

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Order()
        {

        }
        public void loadCustomerTable(DataGridView dgv1)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Customer]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv1.DataSource = dtbl;
            con.Close();
        }
        public void loadServReqTable(DataGridView dgv2)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Types of Service Request]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv2.DataSource = dtbl;
            con.Close();
        }
        public string AddOrder(int cuscell, DateTime dt, int servIDcell, string servType, string tAmt, string lp)
        {
            string status;
            int cusIDCell = cuscell;
            int servID = servIDcell;
            string typeServ = servType;
            string totalAmt = tAmt;
            DateTime date = dt;
            string laptop = lp;
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into [Order](CustomerID, [Date Requested], [ServiceRequestType ID], [Service Type], " +
                "Status, [Amount (RM)], Laptop, [Payment Status]) values (@cusID, @date, @servID, @servType, 'Pending',@amt, @lp, 'Unpaid')", con);
            cmd.Parameters.AddWithValue("@cusID",cusIDCell);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@lp", laptop);
            cmd.Parameters.AddWithValue("@servType", typeServ);
            cmd.Parameters.AddWithValue("@amt", totalAmt);
            cmd.Parameters.AddWithValue("@servID", servID);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Order Confirmed. Thank You!";
            else
                status = "Order Unsuccessful. Please try again.";
            con.Close();
            return status;
        }


    }
}

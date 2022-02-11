using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_Assignment
{
    internal class Customers
    {
        private int service;
        private string service_type;
        private string user_name;
        private string userid;
        private string customer_id;
        private string amount;
        private string status;
        private string Expec_date;
        private string Collec_date;
        private string CusUName;
        private string CusBOD;
        private string CusPhoneNo;
        private string CusEmail;
        private string CusAddress;
        private string CusPassword;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int Service { get => service; set => service = value; }
        public string Service_type { get => service_type; set => service_type = value; }
        public string CusName1 { get => CusUName; set => CusUName = value; }
        public string CusBOD1 { get => CusBOD; set => CusBOD = value; }
        public string CusPhoneNo1 { get => CusPhoneNo; set => CusPhoneNo = value; }
        public string CusEmail1 { get => CusEmail; set => CusEmail = value; }
        public string CusAddress1 { get => CusAddress; set => CusAddress = value; }
        public string CusPassword1 { get => CusPassword; set => CusPassword = value; }

        public Customers (int serv,string type)
        {
            service = serv;
            service_type = type;
        }
        public Customers (string u)
        {
            user_name = u;
            
        }
        public Customers()
        {
            

        }

        internal string changeservice() 
        {
            string status;
            con.Open();

            // the status of the service is pending only can change service
            SqlCommand cmd = new SqlCommand("update [Order] set ServiceRequestTypeID ='" + service + "',[Service Type]='" + service_type + "' where Status = 'pending'" , con);
            
            int i = cmd.ExecuteNonQuery();//executes the command and returns the number of rows affected
            if (i != 0)
            {
                status = "Change Successfully.";
            }
            else
            {
                status = "Change Unsuccessfully.";
            }
            con.Close();
            return status;
        }

        internal string showservdesc()
        {
            string stat;

            con.Open();
            SqlCommand cmd0 = new SqlCommand ("select UserID from [Users] where UserName = '" + user_name + "'",con);
            userid = cmd0.ExecuteScalar().ToString();
            // first, i use username to find out what is thehis/her user id

            SqlCommand cmd1 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid + "'", con);
            customer_id = cmd1.ExecuteScalar().ToString();
            // then i use user id to find out his/her customer id

            SqlCommand cmd2 = new SqlCommand("select [Service Description/Suggestion] from [Order] where CustomerID =  '" + customer_id + "'", con);
            string service_desc = cmd2.ExecuteScalar().ToString();
            // By using his/her customer id i can get what is the service description

            int c = cmd2.ExecuteNonQuery();
            if (c != 0)
            {
                stat = service_desc ;
            }
            else
            {
                stat= ("There is no founded record");
            }
            con.Close ();
            return stat;
        }

        internal string showAmount_ToPaid()
        {
            string stat1;

            con.Open ();
            SqlCommand cmd3 = new SqlCommand("select [Amount (RM)] from [Order] where CustomerID = '" + customer_id + "'", con);
            amount = cmd3.ExecuteScalar().ToString();

            con.Close ();
            return "RM"+ amount;
        }

        internal string showStatus()
        {
            string stat2;

            con.Open ();
            SqlCommand cmd4 = new SqlCommand("select status from [Order] where CustomerID = '" + customer_id + "'", con);
            status = cmd4.ExecuteScalar().ToString();

            con.Close();
            return status;
        }

        internal string showExpec_date()
        {
            string stat3;

            con.Open();
            SqlCommand cmd5 = new SqlCommand("select [Expected Completion Date] from [Order] where CustomerID = '" + customer_id + "'", con);
            Expec_date = cmd5.ExecuteScalar().ToString();

            con.Close () ;
            return Expec_date;
        }

        internal string showCollec_date()
        {
            string stat4;
            con.Open();

            SqlCommand cmd6 = new SqlCommand("select [Collection Date] from [Order] where CustomerID = '" + customer_id + "'", con);
            Collec_date = cmd6.ExecuteScalar().ToString();

            con.Close() ;
            return Collec_date;
        }
        
        internal string store_comment(string c)
        {
            string stat5;
            con.Open();

            SqlCommand cmd7 = new SqlCommand("update [Order] set Comments ='" + c + "'", con);
            int comm = cmd7.ExecuteNonQuery();

            if(comm != 0 )
            {
                stat5 = "Review send successfully";
            }
            else
            {
                stat5 = "Review not send successfully";
            }
            con.Close();
            return stat5;
        }

        internal void viewCustomer(string u)
        {
            con.Open();
            SqlCommand cmd8 = new SqlCommand("select UserID from [Users] where UserName = '" + u + "'", con);
            user_name = u;

            SqlCommand cmd9 = new SqlCommand("select * from Customer where UserID = '" + user_name + "'", con);

            SqlCommand cmd10 = new SqlCommand("select Password from [Users],[Customer] where Users.UserID = Customer.UserID and Customer.Name = '" + o1.CusUName + "'", con);
            CusPassword = cmd10.ExecuteScalar().ToString();

            SqlCommand cmd10 = new SqlCommand("select Password from [Users],[Customer] where Users.UserID = Customer.UserID and Customer.Name = '" + CusUName + "'", con);
            CusPassword = cmd10.ExecuteScalar().ToString();

            SqlDataReader sqlDataReader = cmd9.ExecuteReader(); //used for any result set with multiple rows/columns (e.g., SELECT col1, col2 from sometable )

            while(sqlDataReader.Read())
            {
                CusUName= sqlDataReader.GetString(2);
                CusBOD = sqlDataReader.GetString(4);
                CusPhoneNo = sqlDataReader.GetString(6);
                CusEmail = sqlDataReader.GetString(7);
                CusAddress = sqlDataReader.GetString(8);
            }
            con.Close();
        }

    }
}

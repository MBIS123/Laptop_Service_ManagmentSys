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
        private string name;
        private string userid;
        private string CusName;
        private DateTime CusBOD;
        private string CusPhoneNo;
        private string CusEmail;
        private string CusAddress;
        private string CusPassword;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string CusName1 { get => CusName; set => CusName = value; }
        public DateTime CusBOD1 { get => CusBOD; set => CusBOD = value; }
        public string CusPhoneNo1 { get => CusPhoneNo; set => CusPhoneNo = value; }
        public string CusEmail1 { get => CusEmail; set => CusEmail = value; }
        public string CusAddress1 { get => CusAddress; set => CusAddress = value; }
        public string CusPassword1 { get => CusPassword; set => CusPassword = value; }

        
        public Customers(string n)
        {
            name = n;

        }
        public Customers()
        {


        }
        internal bool validationstatus()
        {
            Boolean status;
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select CustomerID from Customer where Name = '" + name + "'", con);
            string customerid = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("select Status from [Order] where CustomerID = '" + customerid + "'", con);
            string service_status = cmd.ExecuteScalar().ToString();

            if (service_status == "Pending" || service_status == "Changes Required")
            {
                status = true;
            }
            else
            {
                status = false;
            }
            con.Close();
            return status;
        }
        internal string changeservice(int ind, string t)
        {
            string status;
            service = ind;
            service_type = t;

            con.Open();
            // the status of the service is pending only can change service
            SqlCommand cmd2 = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            string customer_id = cmd2.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("update [Order] set [ServiceRequestType ID] = '" + service + "', [Service Type] = '" + service_type + "' where CustomerID ='" + customer_id + "'", con);

            int i = cmd.ExecuteNonQuery();//executes the command and returns the number of rows affected
            if (i != 0)
            {
                status = ("Change Successfully");
            }
            else
            {
                status = ("Change Unsuccessfully");
            }
            con.Close();
            return status;
        }

        internal string showservdesc()
        {
            string stat;

            con.Open();
            SqlCommand cmd0 = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            MessageBox.Show(name);
            string customerID = cmd0.ExecuteScalar().ToString();
            // first, i use customer name to find customer id

            SqlCommand cmd1 = new SqlCommand("select [Service Description/Suggestion] from [Order] where CustomerID =  '" + customerID + "'", con);
            string service_desc = cmd1.ExecuteScalar().ToString();
            // By using his/her customer id i can get what is the service description

            int c = cmd1.ExecuteNonQuery();
            if (c != 0)
            {
                stat = service_desc;
            }
            else
            {
                stat = ("There is no founded record");
            }
            con.Close();
            return stat;
        }

        internal string showAmount_ToPaid()
        {

            con.Open();
            SqlCommand cmd0 = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            string customerID = cmd0.ExecuteScalar().ToString();

            SqlCommand cmd3 = new SqlCommand("select [Amount (RM)] from [Order] where CustomerID = '" + customerID + "'", con);
            string amount = cmd3.ExecuteScalar().ToString();

            con.Close();
            return "RM" + amount;
        }

        internal string showStatus()
        {
            con.Open();
            SqlCommand cmd0 = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            string customerID = cmd0.ExecuteScalar().ToString();

            SqlCommand cmd4 = new SqlCommand("select status from [Order] where CustomerID = '" + customerID + "'", con);
            string status = cmd4.ExecuteScalar().ToString();

            con.Close();
            return status;
        }

        

        internal string showCollec_date()
        {
            con.Open();
            SqlCommand cmd0 = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            string customerID = cmd0.ExecuteScalar().ToString();

            SqlCommand cmd6 = new SqlCommand("select [Collection Date] from [Order] where CustomerID = '" + customerID + "'", con);
            string Collec_date = cmd6.ExecuteScalar().ToString();

            con.Close();
            return Collec_date;
        }

        internal string store_comment(string c)
        {
            string stat;
            con.Open();
            SqlCommand cmd = new SqlCommand("select CustomerID from [Customer] where Name = '" + name + "'", con);
            MessageBox.Show(name);
            string customerID = cmd.ExecuteScalar().ToString();

            SqlCommand cmd7 = new SqlCommand("update [Order] set Comments ='" + c  + "' where [CustomerID] = '" + customerID + "'" , con);
            int comm = cmd7.ExecuteNonQuery();

            if (comm != 0)
            {
                stat = "Review send successfully";
            }
            else
            {
                stat = "Review not send successfully";
            }
            con.Close();
            return stat;
        }

        internal static void viewCustomerProfile(Customers o1) //this parameter is an object of the class customer
        {
            con.Open();
            SqlCommand cmd8 = new SqlCommand("select UserID from [Customer] where Name = '" + o1.name + "'", con);
            o1.userid = cmd8.ExecuteScalar().ToString();
            // i find out what is the userid by his/her name

            SqlCommand cmd9 = new SqlCommand("select * from Customer where Name = '" + o1.name + "'", con);
            //using his/her name, i select all the rows and columns within the table
            SqlDataReader sqlDataReader = cmd9.ExecuteReader(); //used for any result set with multiple rows/columns (e.g., SELECT col1, col2 from sometable )

            SqlCommand cmd10 = new SqlCommand("select Password from [Users] where UserID = '" + o1.userid + "'", con);
            o1.CusPassword = cmd10.ExecuteScalar().ToString();
            //In order to get the password, i use his/her userid to find out what is the password

            while (sqlDataReader.Read()) // i read the customer personal details and store it to variable accordingly and display back to my get method at viewprofile form
            {
                o1.CusName = sqlDataReader.GetString(2);
                o1.CusBOD = sqlDataReader.GetDateTime(4);
                o1.CusPhoneNo = sqlDataReader.GetString(6);
                o1.CusEmail = sqlDataReader.GetString(7);
                o1.CusAddress = sqlDataReader.GetString(8);
            }
            con.Close();




        }
        
        internal string updateCustomerProfile(string Name,DateTime DOB, string ph, string Email, string Address)
        {
            string stat6;
            con.Open();
            CusName = Name;
            CusBOD = DOB;
            CusPhoneNo = ph;
            CusEmail = Email;
            CusAddress = Address;
            

            SqlCommand cmd12 = new SqlCommand("Update [Customer] set [Name] = '" + CusName  +  
                "', [Date of Birth] = @date, [Contact No.] = '" + CusPhoneNo + "', [Email] = '" + CusEmail +
                "', [Address] = '" + CusAddress + "' where [Name] = '" + name + "'", con);

            cmd12.Parameters.AddWithValue("@date", CusBOD);
            int i = cmd12.ExecuteNonQuery();

            if (i != 0)
            {
                stat6 = "Dear Customer, profile updated successfully ";
            }
            else
            {
                stat6 = "Dear Customer, profile updated unsuccessfully ";
            }

            con.Close();
            return stat6;

        }


        internal string updateCustomerPassword(string new_passw)
        {
            string stat7;
            con.Open();

            CusPassword = new_passw;
            SqlCommand cmd13 = new SqlCommand("update [Users] set [Password] = '" + CusPassword + "' where [UserID] = '" + userid + "'", con);
            int i = cmd13.ExecuteNonQuery();

            if (i != 0)
            {
                stat7 = "Dear Customer, password updated successfully ";
            }
            else
            {
                stat7 = "Dear Customer, password updated unsuccessfully ";
            }

            con.Close();
            return stat7;


        }
    }
}

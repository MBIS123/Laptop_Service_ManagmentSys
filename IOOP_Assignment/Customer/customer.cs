﻿using System;
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
        private string CusName;
        private DateTime CusBOD;
        private string CusPhoneNo;
        private string CusEmail;
        private string CusAddress;
        private string CusPassword;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int Service { get => service; set => service = value; }
        public string Service_type { get => service_type; set => service_type = value; }
        public string CusName1 { get => CusName; set => CusName = value; }
        public DateTime CusBOD1 { get => CusBOD; set => CusBOD = value; }
        public string CusPhoneNo1 { get => CusPhoneNo; set => CusPhoneNo = value; }
        public string CusEmail1 { get => CusEmail; set => CusEmail = value; }
        public string CusAddress1 { get => CusAddress; set => CusAddress = value; }
        public string CusPassword1 { get => CusPassword; set => CusPassword = value; }

        public Customers(int serv, string type)
        {
            service = serv;
            service_type = type;
        }
        public Customers(string un)
        {
            user_name = un;

        }
        public Customers()
        {


        }
        internal bool validationstatus()
        {
            Boolean status;
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select UserID from Users where UserName = '" + user_name + "'", con);
            string userid = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("select Status from [Order], Customer where [Order].CustomerID = Customer.CustomerID and Customer.UserID = '" + userid + "'", con);
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
        internal string changeservice()
        {
            string status;
            con.Open();

            // the status of the service is pending only can change service
            SqlCommand cmd1 = new SqlCommand("select UserID from [Users] where UserName = '" + user_name + "'", con);
            string userid = cmd1.ExecuteScalar().ToString();
            MessageBox.Show(userid);

            SqlCommand cmd2 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid + "'", con);
            customer_id = cmd2.ExecuteScalar().ToString();
            MessageBox.Show(customer_id);


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
            SqlCommand cmd0 = new SqlCommand("select UserID from [Users] where UserName = '" + user_name + "'", con);
            string userid1 = cmd0.ExecuteScalar().ToString();
            // first, i use username to find out what is thehis/her user id

            SqlCommand cmd1 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid1 + "'", con);
            string customer_id1 = cmd1.ExecuteScalar().ToString();
            // then i use user id to find out his/her customer id

            SqlCommand cmd2 = new SqlCommand("select [Service Description/Suggestion] from [Order] where CustomerID =  '" + customer_id1 + "'", con);
            string service_desc = cmd2.ExecuteScalar().ToString();
            // By using his/her customer id i can get what is the service description

            int c = cmd2.ExecuteNonQuery();
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
            string stat1;

            con.Open();
            SqlCommand cmd0 = new SqlCommand("select UserID from [Users] where UserName = '" + user_name + "'", con);
            string userid1 = cmd0.ExecuteScalar().ToString();
            // first, i use username to find out what is thehis/her user id

            SqlCommand cmd1 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid1 + "'", con);
            string customer_id1 = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd3 = new SqlCommand("select [Amount (RM)] from [Order] where CustomerID = '" + customer_id1 + "'", con);
            string amount1 = cmd3.ExecuteScalar().ToString();

            con.Close();
            return "RM" + amount1;
        }

        internal string showStatus()
        {
            string stat2;

            con.Open();
            SqlCommand cmd0 = new SqlCommand("select UserID from [Users] where UserName = '" + user_name + "'", con);
            string userid1 = cmd0.ExecuteScalar().ToString();
            // first, i use username to find out what is thehis/her user id

            SqlCommand cmd1 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid1 + "'", con);
            string customer_id1 = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd4 = new SqlCommand("select status from [Order] where CustomerID = '" + customer_id1 + "'", con);
            string status1 = cmd4.ExecuteScalar().ToString();

            con.Close();
            return status1;
        }

        

        internal string showCollec_date()
        {
            string stat4;
            con.Open();
            SqlCommand cmd0 = new SqlCommand("select UserID from [Users] where UserName = '" + user_name + "'", con);
            string userid1 = cmd0.ExecuteScalar().ToString();
            // first, i use username to find out what is thehis/her user id

            SqlCommand cmd1 = new SqlCommand("select CustomerID from [Customer] where UserId = '" + userid1 + "'", con);
            string customer_id1 = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd6 = new SqlCommand("select [Collection Date] from [Order] where CustomerID = '" + customer_id1 + "'", con);
            string Collec_date1 = cmd6.ExecuteScalar().ToString();

            con.Close();
            return Collec_date1;
        }

        internal string store_comment(string c)
        {
            string stat5;
            con.Open();

            SqlCommand cmd7 = new SqlCommand("update [Order] set Comments ='" + c + "'", con);
            int comm = cmd7.ExecuteNonQuery();

            if (comm != 0)
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

        internal static void viewCustomerProfile(Customers o1) //this parameter is an object of the class customer
        {
            con.Open();
            SqlCommand cmd8 = new SqlCommand("select UserID from [Users] where UserName = '" + o1.user_name + "'", con);
            o1.userid = cmd8.ExecuteScalar().ToString();
            // i find out what is the userid by his/her username

            SqlCommand cmd9 = new SqlCommand("select * from Customer where UserID = '" + o1.userid + "'", con);
            //using his/her userid, i select all the rows and columns within the table
            SqlDataReader sqlDataReader = cmd9.ExecuteReader(); //used for any result set with multiple rows/columns (e.g., SELECT col1, col2 from sometable )

            SqlCommand cmd10 = new SqlCommand("select Password from [Users] where UserID = '" + o1.userid + "'", con);
            o1.CusPassword = cmd10.ExecuteScalar().ToString();
            //In order to get the password, i use his/her userid, customerid and name to find out what is the password

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
        internal string updateCustomerProfile(string Name, DateTime date, string ph, string Email, string Address)
        {
            string stat6;
            con.Open();

            CusName = Name;
            CusBOD = date;
            CusPhoneNo = ph;
            CusEmail = Email;
            CusAddress = Address;

            SqlCommand cmd12 = new SqlCommand("Update [Customer] set [Name] = '" + CusName + "', [Date of Birth] = '" + CusBOD + "', [Contact No.] = '" + CusPhoneNo + "', [Email] = '" + CusEmail + "', [Address] = '" + CusAddress + "' where [UserID] = '" + userid + "'", con);
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

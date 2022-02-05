using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOPAssignment
{
    internal class Customer
    {
        private int service;
        private string service_type;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int Service { get => service; set => service = value; }
        public string Service_type { get => service_type; set => service_type = value; }

        public Customer(int serv,string type)
        {
            service = serv;
            service_type = type;
        }
        private string change_service() // change the customer service (should return status)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update order set ServiceRequestType ID ='" + service + "',Service Type='" + service_type, con);
            int i = cmd.ExecuteNonQuery();////executes the command and returns the number of rows affected
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
    }
}

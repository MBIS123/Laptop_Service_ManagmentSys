using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_Assignment.Customer
{
    internal class customer
    {
        private string service;
        private string service_type;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Service { get => service; set => service = value; }
        public string Service_type { get => service_type; set => service_type = value; }

        internal void change_service(string serv,string type) // change the customer service (should return status)
        {
            con.Open();

            service = serv;
            service_type = type;

            SqlCommand cmd = new SqlCommand("update order set service ='" + serv + "',serviceType='" + type, con);
            con.Close();
        }
    }
}

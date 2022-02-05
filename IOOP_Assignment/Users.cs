using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Users
    {
        private string username;
        private string password;

        public User(string u, string p) //u = admin, p = admin
        {
            username = u;
            password = p;
        } 

        public string login(string un) //login method, un = admin
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"]);
        }

    }
}

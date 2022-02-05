using IOOPAssignment;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public Users(string u, string p) //u = admin, p = admin
        {
            username = u;
            password = p;
        } 

        public string login(string un) //login method, un = admin
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString)
            SqlCommand cmd = new SqlCommand("select count(*) from users where username = '" + username + "' and password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0) //redirection to admin or student
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username = '" + username + "' and password = '" + password + "'", con);
                string user_role = cmd2.ExecuteScalar().ToString();

                if (user_role = "admin")
                {
                    AdminPage a = new AdminPage();
                    a.ShowDialog();
                }
                /*else if (user_role = "customer")
                {
                    wenhui, you need to change your namespace to IOOP_Assignment first. 
                }*/
                else if (user_role = "receptionist")
                {
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                }
                else if (user_role = "technician")
                {
                    TechnicianDashboard t = new TechnicianDashboard();
                    t.ShowDialog();
                }
                else
                    status = "Incorrect username or password entered!";
                con.Close();

                return status;
            }    
        }

    }
}

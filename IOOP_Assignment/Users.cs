
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
            SqlCommand cmd = new SqlCommand("select count(*) from users where UserName = '" + username + "' and Password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0) //redirection to admin, customer, receptionist or technician
            {
                SqlCommand cmd2 = new SqlCommand("select [User Role] from users where username = '" + username + "' and password = '" + password + "'", con);
                string user_role = cmd2.ExecuteScalar().ToString();
                /*
                if (user_role == "admin")
                {
                    AdminPage a = new AdminPage();
                    a.ShowDialog();
                }
                else if (user_role == "customer")
                {
                    //wenhui, you need to change your namespace to IOOP_Assignment first. 
                }
                else if (user_role == "receptionist")
                {
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                }*/
                if (user_role == "technician")
                {
                    SqlCommand cmd3 = new SqlCommand("select [name] from technician where UserID = (select UserID from users where username = '" + username + "')", con);
                    string technician_name = cmd3.ExecuteScalar().ToString();
                    TechnicianDashboard td = new TechnicianDashboard(technician_name); 
                    td.ShowDialog(); //adding a simple comment here
                }
            }
            else
                status = "Incorrect username or password entered!";
            con.Close();

            return status; 
        }

    }
}
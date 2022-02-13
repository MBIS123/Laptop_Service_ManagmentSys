
using IOOP_Assignment.Customer;
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

        public Users() //u = admin, p = admin
        {

        }

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
            SqlCommand cmd = new SqlCommand("select count(*) from [Users] where UserName = '" + username + "' and Password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0) //redirection to admin, customer, receptionist or technician
            {
                SqlCommand cmd2 = new SqlCommand("select [User Role] from Users where UserName = '" + username + "' and Password = '" + password + "'", con);
                string user_role = cmd2.ExecuteScalar().ToString();

                if (user_role == "admin")
                {
                    DashBoard a = new DashBoard();
                    a.ShowDialog();
                }
                else if (user_role == "customer")
                {
                    update_profile u = new update_profile(un);// pass username and display at update profile form
                    Viewprofile v = new Viewprofile(un);
                    change_service d = new change_service(un); 
                    Myorder c = new Myorder(un);
                    c.ShowDialog();
                }
                else if (user_role == "technician")
                {
                    SqlCommand cmd3 = new SqlCommand("select [name] from technician where UserID = (select UserID from users where username = '" + username + "')", con);
                    string technician_name = cmd3.ExecuteScalar().ToString();
                    SqlCommand cmd4 = new SqlCommand("select [TechnicianID] from technician where UserID = (select UserID from users where username = '" + username + "')", con);
                    int technician_id = (int)cmd4.ExecuteScalar();
                    TechnicianDashboard td = new TechnicianDashboard(technician_name, technician_id);
                    td.ShowDialog(); //adding a simple comment here
                }
                else if (user_role == "receptionist")
                {
                    SqlCommand cmd5 = new SqlCommand("select [name] from Receptionist where UserID = (select UserID from users where username = '" + username + "')", con);
                    string receptionist_name = cmd5.ExecuteScalar().ToString();
                    SqlCommand cmd6 = new SqlCommand("select [ReceptionistID] from Receptionist where UserID = (select UserID from users where username = '" + username + "')", con);
                    int receptionist_id = (int)cmd6.ExecuteScalar();
                    frmRegNewCus td = new frmRegNewCus(receptionist_name);
                    td.ShowDialog(); //adding a simple comment here
                }
            }
            else
                status = "Incorrect username or password entered!";
            con.Close();

            return status;
        }


        internal void assignOrder()
        {
            int techId;
            int nmlOrderID;
            DateTime nmlRequestDate;
            DateTime urgRequestDate;
            int urgOrderID;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

            SqlCommand numAvailableTech = new SqlCommand("select count(*) from Technician where Status= 'Available';", con);
            int numOfAvaiTech = (int)numAvailableTech.ExecuteScalar();


            if (numOfAvaiTech != 0) // code will only run if there are at  least one technician which is Staus = 'Available'
            {
                SqlCommand availableTech = new SqlCommand("select top (1) TechnicianID from Technician  where Status ='Available';", con); //first available tech
                techId = (int)availableTech.ExecuteScalar();

                SqlCommand cmdNormalPendingOrder = new SqlCommand("select count(*) from [Order] where [Service Type] ='Normal' and TechnicianID is null;", con);
                int numOfNormalPendingOrder = (int)cmdNormalPendingOrder.ExecuteScalar();

                SqlCommand cmdUrgentPendingOrder = new SqlCommand("select count(*) from [Order] where [Service Type] ='Urgent' and TechnicianID is null;", con);
                int numOfUrgentPendingOrder = (int)cmdUrgentPendingOrder.ExecuteScalar();




                SqlCommand updtTechStatus = new SqlCommand("update Technician set Status = 'Unavailable' where TechnicianID = " + techId + ";", con);


                if (numOfNormalPendingOrder == 0 && numOfUrgentPendingOrder == 0) { }

                else if (numOfNormalPendingOrder != 0 && numOfUrgentPendingOrder != 0)
                {

                    MessageBox.Show("hi");
                    SqlCommand findFirstNormalOrder = new SqlCommand("select top (1) OrderID,[Date Requested] from [Order] where TechnicianID is null and [Service Type]='Normal'order by [Date Requested] ASC;", con);
                    SqlDataReader nmlRead = findFirstNormalOrder.ExecuteReader();
                    nmlRead.Read();
                    nmlOrderID = nmlRead.GetInt32(0);
                    nmlRequestDate = nmlRead.GetDateTime(1);
                    nmlRead.Close();

                    SqlCommand findFirstUrgOrder = new SqlCommand("select top (1) OrderID,[Date Requested] from [Order] where TechnicianID is null and [Service Type]='Urgent'order by [Date Requested] ASC;", con);
                    SqlDataReader urgtRead = findFirstUrgOrder.ExecuteReader();
                    urgtRead.Read();
                    urgOrderID = urgtRead.GetInt32(0);
                    urgRequestDate = urgtRead.GetDateTime(1);
                    urgtRead.Close();


                    SqlCommand updtUrgentTechID = new SqlCommand("update [Order] set TechnicianID = " + techId + " where OrderID = " + urgOrderID + ";", con);


                    SqlCommand updtNormalTechID = new SqlCommand("update [Order] set TechnicianID = " + techId + " where OrderID = " + nmlOrderID + ";", con);


                    DateTime nmlWaitDate = nmlRequestDate.AddDays(14);

                    int differentDays = (int)(nmlWaitDate - urgRequestDate).TotalDays;    // if normalorder are  urg order waiting together within 14 day urg will get assign to technician

                    if (differentDays >= 0)
                    {
                        updtUrgentTechID.ExecuteNonQuery();
     

                    }
                    else
                    {
                        updtNormalTechID.ExecuteNonQuery();
 
                    }

                    updtTechStatus.ExecuteNonQuery();


                }
                else if (numOfNormalPendingOrder == 0) //  if no normal order then no need search for normal order , just arranged urgent order and assign to technician
                {

                    SqlCommand findFirstUrgOrder = new SqlCommand("select top (1) OrderID,[Date Requested] from [Order] where TechnicianID is null and [Service Type]='Urgent'order by [Date Requested] ASC;", con);

                    SqlDataReader urgtRead = findFirstUrgOrder.ExecuteReader();
                    urgtRead.Read();
                    urgOrderID = urgtRead.GetInt32(0);
                    urgtRead.Close();

                    SqlCommand updtUrgentTechID = new SqlCommand("update [Order] set TechnicianID = " + techId + " where OrderID = " + urgOrderID + ";", con);


                    updtUrgentTechID.ExecuteNonQuery();
                    updtTechStatus.ExecuteNonQuery();

                }

                else if (numOfUrgentPendingOrder == 0) //  if no urgent order then no need search for urgent order , just arranged normal order and assign to technician
                {

                    SqlCommand findFirstNormalOrder = new SqlCommand("select top (1) OrderID,[Date Requested] from [Order] where TechnicianID is null and [Service Type]='Normal'order by [Date Requested] ASC;", con);

                    SqlDataReader nmlRead = findFirstNormalOrder.ExecuteReader();
                    nmlRead.Read();
                    nmlOrderID = nmlRead.GetInt32(0);
                    nmlRead.Close();

                    SqlCommand updtNormalTechID = new SqlCommand("update [Order] set TechnicianID = " + techId + " where OrderID = " + nmlOrderID + ";", con);

                    updtNormalTechID.ExecuteNonQuery();
                    updtTechStatus.ExecuteNonQuery();

                }

                con.Close();
            }


        }


    }
}

                    
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Technician
    {
        private int techID;
        private string techName;
        private string techGender;
        private DateTime techDOB;
        private string techEthnicity;
        private string techIC;
        private string techContact;
        private string techEmail;
        private string techAddress;
        private string techPassword;

        //for dashboard widgets
        private int numberofpending;
        private int numberofurgent;
        private int numberofcompleted;
        
        //for edit service request form
        private int orderid_forselection;
        private string servicerequest_status;
        private string servdesc;
        private DateTime collectiondate;
        private string collectiondate_string;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        //static used to use 'con' object multiple times

        //methods for 'auto-filling' fields when viewing technician profile + update profile
        public string TechName { get => techName; set => techName = value; }
        public string TechGender { get => techGender; set => techGender = value; }
        public DateTime TechDOB { get => techDOB; set => techDOB = value; }
        public string TechEthnicity { get => techEthnicity; set => techEthnicity = value; }
        public string TechIC { get => techIC; set => techIC = value; }
        public string TechContact { get => techContact; set => techContact = value; }
        public string TechEmail { get => techEmail; set => techEmail = value; }
        public string TechAddress { get => techAddress; set => techAddress = value; }
        public string TechPassword { get => techPassword; set => techPassword = value; }
        public int TechID { get => techID; set => techID = value; }
        public string Servicerequest_status { get => servicerequest_status; set => servicerequest_status = value; }
        public string Servdesc { get => servdesc; set => servdesc = value; }
        public DateTime Collectiondate { get => collectiondate; set => collectiondate = value; }
        public int Orderid_forselection { get => orderid_forselection; set => orderid_forselection = value; }
        public int Numberofpending { get => numberofpending; set => numberofpending = value; }
        public int Numberofurgent { get => numberofurgent; set => numberofurgent = value; }
        public int Numberofcompleted { get => numberofcompleted; set => numberofcompleted = value; }

        public Technician()
        {

        }

        public Technician(string tn)
        {
            techName = tn;
        }

        public Technician(int tid)
        {
            techID = tid;
        }

        public Technician(string tn, int tid)
        {
            techName = tn;
            techID = tid;
        }

        public Technician(int tid, int ord_id)
        {
            techID = tid;
            orderid_forselection = ord_id;
        }

        //loading order table into technician dashboard
        public void loadOrderTable(DataGridView dgv, int tech_ID)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Order] where TechnicianID = '" + tech_ID + "' AND Status = 'Pending' or Status = 'Changes Required'", con);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Order] where TechnicianID = '" + tech_ID + "'", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            //method 1 - direct method that shows all columns
            //dataGrid_AllServ.DataSource = dtbl;

            //method 2 - indirect method that shows select columns
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dtbl;
            con.Close();
        }

        //loading number of pending jobs into dashboard widget
        public static void dashboardWidgetValues(Technician o1)
        {
            con.Open();
            //number of pending jobs belonging to technician with specific techID
            SqlCommand cmd = new SqlCommand("select COUNT(OrderID) FROM [Order] where Status = 'Pending' AND TechnicianID = '" + o1.techID + "'", con); 
            o1.numberofpending = (Int32) cmd.ExecuteScalar();
            //no. of urgent jobs belonging to technician with specific techID
            SqlCommand cmd2 = new SqlCommand("select COUNT(OrderID) FROM [Order] where [Service Type] = 'Urgent' AND TechnicianID = '" + o1.techID + "'", con);
            o1.numberofurgent = (Int32) cmd2.ExecuteScalar();
            //no. of completed jobs in the month belonging to technician with specific techID
            SqlCommand cmd3 = new SqlCommand("select COUNT(OrderID) FROM [Order] where Status = 'Completed' AND TechnicianID = '" + o1.techID + "' AND Month([Collection Date]) = Month(GETDATE())", con); 
            o1.numberofcompleted = (Int32) cmd3.ExecuteScalar();
            con.Close();
        }

        //loading details from order table into edit service request
        public static void viewOrderTableforEdit(Technician o1)
        {
            con.Open();
            Technician obj1 = new Technician(o1.techID);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] where OrderID = '" + o1.orderid_forselection + "'AND TechnicianID = '" + o1.techID + "'", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                o1.servicerequest_status = sqlDataReader.GetString(5); //true or false...
                if (!sqlDataReader.IsDBNull(7))
                {
                    o1.servdesc = sqlDataReader.GetString(7);
                    o1.collectiondate = sqlDataReader.GetDateTime(8);
                }
            }
            con.Close();

        }

        //loading OrderIDs into array to show in comboOrderID
        public static ArrayList viewOrderID(Technician o1)
        {
            con.Open();
            //MessageBox.Show(o1.techID.ToString()); //for testing if value of technician_ID (line 48 TechnicianDashboard) is passed
            ArrayList OID = new ArrayList();
            //SqlCommand cmd = new SqlCommand("select [OrderID] FROM [Order] where Status = 'Pending' or Status = 'Changes Required' AND TechnicianID = '" + techID + "'", con); //only add pending 
            SqlCommand cmd = new SqlCommand("select [OrderID] FROM [Order] where TechnicianID = '" + o1.techID + "' AND Status = 'Pending' or Status = 'Changes Required'", con); //only add pending 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OID.Add(reader.GetValue(0));
            }
            con.Close();
            return OID;
        }

        //updating service request in edit service request form
        public string updateEditServReq(int oid, string stat, string serv_desc, DateTime date)
        {
            string status;
            con.Open();

            orderid_forselection = oid;
            servicerequest_status = stat;
            servdesc = serv_desc;
            collectiondate = date;
            collectiondate_string = collectiondate.ToString("yyyy-MM-dd");

            //MessageBox.Show(collectiondate_string); testing if collectiondate is passed into collectiondate_string 

            SqlCommand cmd = new SqlCommand("update [Order] set [Status] = '" + servicerequest_status + "', [Service Description/Suggestion] = '" + servdesc + "', [Collection Date] = '" + collectiondate_string + "' where [OrderID] = '" + orderid_forselection + "'", con);
            //MessageBox.Show(techID.ToString()); //for testing if TechID is passed
            SqlCommand cmd2 = new SqlCommand("update [Technician] set [Status] = 'Available' where TechnicianID = '" + techID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                int x = cmd2.ExecuteNonQuery();
                if (x != 0)
                {
                    status = "The service request has been successfully updated.";
                }
                else
                {
                    status = "Update Unsuccessful. Please try again.";
                }
            }
            else
            {
                status = "Update Unsuccessful. Please try again.";
            }
            con.Close();

            return status;

        }

        //loading technician information into profile
        public static void viewTechProfile(Technician o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Technician where Name = '" + o1.techName + "'", con);
            SqlCommand cmd2 = new SqlCommand("select [Password] from Users, Technician where Users.UserID = Technician.UserID and Technician.Name = '" + o1.techName + "'", con);
            o1.techPassword = cmd2.ExecuteScalar().ToString();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                o1.techGender = sqlDataReader.GetString(3);
                o1.techDOB = sqlDataReader.GetDateTime(4);
                o1.techEthnicity = sqlDataReader.GetString(5);
                o1.techIC = sqlDataReader.GetString(6);
                o1.techContact = sqlDataReader.GetString(7);
                o1.techEmail = sqlDataReader.GetString(8);
                o1.techAddress = sqlDataReader.GetString(9);
            }
            con.Close();
        }

        public string updateTechProfileContactDetails(string cont, string em, string add)
        {
            string status;
            con.Open();

            techContact = cont;
            techEmail = em;
            techAddress = add;

            SqlCommand cmd = new SqlCommand("update [Technician] set [Contact No.] = '" + techContact + "', [Email] = '" + techEmail + "', [Address] = '" + techAddress + "' where [Name] = '" + techName + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Your details have been successfully updated.";
            else
                status = "Update Unsuccessful. Please try again.";
            con.Close();

            return status;
        }
        public string updateTechProfilePassword(string pw)
        {
            string status;
            con.Open();

            techPassword = pw;

            SqlCommand cmd = new SqlCommand("update [Users] set [Password] = '" + techPassword + "' where [UserID] = (select Users.[UserID] from Technician, Users where Technician.UserID = Users.UserID)", con);
            //("select [Password] from Users, Technician where Users.UserID = Technician.UserID and Technician.Name = '" + o1.techName + "'", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Your password has been successfully updated.";
            else
                status = "Update Unsuccessful. Please try again.";
            con.Close();

            return status;
        }
    }
}

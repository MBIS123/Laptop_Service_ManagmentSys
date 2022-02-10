using System;
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

        public Technician(string tn)
        {
            techName = tn;
        }

        public void loadOrderTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Order]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            //method 1 - direct method that shows all columns
            //dataGrid_AllServ.DataSource = dtbl;

            //method 2 - indirect method that shows select columns
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dtbl;
            con.Close();
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

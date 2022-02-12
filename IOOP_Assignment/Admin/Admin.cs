using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_Assignment
{
    internal class Admin
    {
        DataValidation objValidt = new DataValidation();

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString() );
        

        private string position;
        private string name;
        private string gender;
        private string dateOfBirth;
        private string ethnicity;
        private string address;
        private string emailAddress;
        private string noIC;
        private string phoneNumber;
        private bool allInfoFilled = true;  // used for validation purpose
        private int numOfUsers;
        private int numOfTechnician;
        private int numOfReceptionist;


        public Admin() { } //constructor

        
        
        public string Position { get => position; set => position = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Ethnicity { get => ethnicity; set => ethnicity = value; }
        public string Address { get => address; set => address = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string NoIC { get => noIC; set => noIC = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public bool AllInfoFilled { get => allInfoFilled; set => allInfoFilled = value; }

        internal void validateRegisPosition(RadioButton technician ,RadioButton receptionist)
        {
            if (technician.Checked == true)
                position = "technician";
            else if (receptionist.Checked == true)
                position = "receptionist";
            else
                allInfoFilled = false;
               
        }

        internal void validateRegisCheckComboBx(ComboBox gender, ComboBox ethnic )
        {
            if (gender.SelectedIndex == -1 && ethnic.SelectedIndex == -1) // ensure admin select something (validation for gender)
            {
                allInfoFilled = false;
                MessageBox.Show("first false");
            }

            else if (ethnic.SelectedIndex == -1)
            {
                allInfoFilled = false;
                MessageBox.Show("secfalse");
            }

            else if (gender.SelectedIndex == -1)
            {
                allInfoFilled = false;
                MessageBox.Show("third false");
            }

            else
            {
                this.gender = gender.SelectedItem.ToString();
                ethnicity = ethnic.SelectedItem.ToString();
            }
        }
       
        internal void insertDataBase()
        {
            numOfUserFrmDtBase();
            string userName = generateUserName();
            string password = position + "123";

            conn.Open();
            int userID = numOfUsers+ 1; //generating new userID
            int techID = numOfTechnician + 1;
            int recpID = numOfReceptionist + 1; 

            SqlCommand cmdInsertStaffToUser = new SqlCommand("SET IDENTITY_INSERT Users ON; insert into Users(UserID,UserName,Password,[User Role]) values" +
                                                       "( "+ userID+" ,'"+userName+"','"+password+"','"+position+ "' ); SET IDENTITY_INSERT Users off; ",conn);
            cmdInsertStaffToUser.ExecuteNonQuery();

            SqlCommand cmdInsertTechnician = new SqlCommand("SET IDENTITY_INSERT Technician ON; insert into Technician(TechnicianID,UserID,Name,Gender,[Date of Birth],Ethnicity,[IC No.],[Contact No.],Email,Address,Status) values" +
                                                      "( "+techID+","+ userID + " ,'" + name + "','" + gender + "','" + dateOfBirth + "','"+ethnicity + "','"+noIC+ "','"+phoneNumber + "','" +emailAddress+ "','"+address+ "','Available'); SET IDENTITY_INSERT Technician off; ", conn);

            SqlCommand cmdInsertReceptionist = new SqlCommand("SET IDENTITY_INSERT Receptionist ON; insert into Receptionist (ReceptionistID,UserID,Name,Gender,[Date of Birth],Ethnicity,[IC No.],[Contact No.],Email,Address) values" +
                                          "( " + recpID + "," + userID + " ,'" + name + "','" + gender + "','" + dateOfBirth + "','" + ethnicity + "','" + noIC + "','" + phoneNumber + "','" + emailAddress + "','" + address + "'); SET IDENTITY_INSERT Receptionist off; ", conn);

            if (position == "receptionist")
                cmdInsertReceptionist.ExecuteNonQuery();
            else
                cmdInsertTechnician.ExecuteNonQuery();


            conn.Close();
        }

        private void numOfUserFrmDtBase()
        {
            conn.Open();
            SqlCommand cmdNumUser = new SqlCommand("select count(*) from Users",conn);
            numOfUsers = int.Parse(cmdNumUser.ExecuteScalar().ToString());

            SqlCommand cmdNumTech = new SqlCommand("select count(*) from Technician", conn);
            numOfTechnician = int.Parse(cmdNumTech.ExecuteScalar().ToString());

            SqlCommand cmdNumRecep = new SqlCommand("select count(*) from Receptionist", conn);
            numOfReceptionist = int.Parse(cmdNumRecep.ExecuteScalar().ToString());

            conn.Close();
            
        }

        private string generateUserName()
        {
            string headUserName;
            string userName;

            if (position == "technician")
            {
                headUserName = "T_";
                userName = headUserName + dateOfBirth.Replace("-","") + (numOfTechnician+1);
            }
            else
            {
                headUserName = "R_";
                userName = headUserName + dateOfBirth.Replace("-", "") + (numOfReceptionist+1);
            }
            return userName;
        }
    
        internal  void showRelatedForm(string x)
        {
            DashBoard adminFrm = new DashBoard();
            MonthlyIncome incomeFrm = new MonthlyIncome();
            Registration regisFrm = new Registration();
            ServiceReport reportFrm = new ServiceReport();

            switch (x)
            {
                case "dashboard":
                    adminFrm.Show();
                    break;
                case "income":
                    incomeFrm.Show();
                    break;
                case "registration":
                    regisFrm.Show();
                    break ;
                case "serviceReport":
                    reportFrm.Show();
                    break;
                    
            }


        }
        
  
  

        // messagebox.show("message","title" , MessageBoxButton, ... , MessageBoxIcon,Warning)
        /// INSIDE THE ADMIN CLASS I DECLARE A METHOD FIRST

    }


}

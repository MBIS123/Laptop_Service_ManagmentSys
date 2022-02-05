using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment.Receptionist
{
    class Customer
    {
        private string cusName;
        private string cusGender;
        private string cusIC;
        private string cusPhoneNum;
        private string cusEmail;
        private string cusAddress;
        private string cusDob;
        private string cusUsername;
        //frmRegNewCus

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string CusName { get => cusName; set => cusName = value; }
        public string CusGender { get => cusGender; set => cusGender = value; }
        public string CusIC { get => cusIC; set => cusIC = value; }
        public string CusPhoneNum { get => cusPhoneNum; set => cusPhoneNum = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public string CusDob { get => cusDob; set => cusDob = value; }

        public Customer(string n, string g, string i, string num, string e, string a, string d, string un)
        {
            cusName = n;
            cusGender = g;
            cusIC = i;
            cusPhoneNum = num;
            cusEmail = e;
            cusAddress = a;
            cusDob = d;
            cusUsername = un;
        }
        public Customer()
        {

        }
        public Customer(string un)
        {
            cusUsername = un;
        }

        public string addNewCus()
        {
      
            string status;
            con.Open();
            
            SqlCommand cmd1 = new SqlCommand("insert into Users(Username, Password, Role) values (@username, @pwd, @role)", con);
            SqlCommand cmd2 = new SqlCommand("insert into Customer(UserID, Name, Gender, Date of Birth, IC No., Contact No., Email, Address) values(@userID, @name, @gender, @dob, @ic, @phone, @email, @address)", con);


            return status;
        }
    }
}

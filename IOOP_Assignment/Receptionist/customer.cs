using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment.Receptionist
{
    class customer
    {
        private string cusName;
        private string cusGender;
        private string cusIC;
        private string cusPhoneNum;
        private string cusEmail;
        private string cusAddress;
        private string cusDob;
        private string cusUsername;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string CusName { get => cusName; set => cusName = value; }
        public string CusGender { get => cusGender; set => cusGender = value; }
        public string CusIC { get => cusIC; set => cusIC = value; }
        public string CusPhoneNum { get => cusPhoneNum; set => cusPhoneNum = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public string CusDob { get => cusDob; set => cusDob = value; }

        public customer(string n, string g, string i, string num, string e, string a, string d, string un)
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

        public customer(string un)
        {
            cusUsername = un;
        }
        public string addNewCus()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer(Name, Gender, Date of Birth, IC No., Contact No., Email, Address) values() ");


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Customer
    {
        DataValidation objDataVal = new DataValidation();

        private string cusName;
        private string cusGender;
        private string cusIC;
        private string cusPhoneNum;
        private string cusEmail;
        private string cusAddress;
        private string cusDob;
        private string cusUsername;
        private static bool allcusinfoFilled = true;

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
        internal void allSecFill()
        {
            if (!allcusinfoFilled) //some infor are not filled
            {
                MessageBox.Show("Please ensure every section was filled !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string addNewCus()
        {

            string status = null;
            con.Open();
            bool exists = false;
            SqlCommand cmd1 = new SqlCommand("select count(*) from Users where Username= '"+ cusUsername+ "'" ,con);
            exists = (int)cmd1.ExecuteScalar() > 0;
            if (exists)
            {
                MessageBox.Show("Username existed. Please enter a valid username");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("insert into Users(Username, Password, User Role) values (@username, '123456', 'customer')", con);
                SqlCommand cmd3 = new SqlCommand("insert into Customer(Name, Gender, Date of Birth, IC No., Contact No., Email, Address) values(@name, @gender, @dob, @ic, @phone, @email, @address)", con);
                cmd2.Parameters.AddWithValue("@username", cusUsername);
                cmd3.Parameters.AddWithValue("@name", cusName);
                cmd3.Parameters.AddWithValue("@gender", cusGender);
                cmd3.Parameters.AddWithValue("@dob", cusDob);
                cmd3.Parameters.AddWithValue("@ic", cusIC);
                cmd3.Parameters.AddWithValue("@phone", cusPhoneNum);
                cmd3.Parameters.AddWithValue("@email", cusEmail);
                cmd3.Parameters.AddWithValue("@address", cusAddress);

                cmd2.ExecuteNonQuery();
                int i = cmd3.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Successful!";
                //cmd3.Parameters.AddWithValue("@userID", Convert.ToInt32(cmd2.ExecuteScalar().ToString()));
                else
                    status = "Unable to Register!";
            }
            con.Close();
            return status;
        }
    }
}

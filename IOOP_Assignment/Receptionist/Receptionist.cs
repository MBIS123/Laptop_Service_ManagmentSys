using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Receptionist
    {

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
        private object dataGridViewPayment;

        public string CusName { get => cusName; set => cusName = value; }
        public string CusGender { get => cusGender; set => cusGender = value; }
        public string CusIC { get => cusIC; set => cusIC = value; }
        public string CusPhoneNum { get => cusPhoneNum; set => cusPhoneNum = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public string CusDob { get => cusDob; set => cusDob = value; }

        public Receptionist(string n, string g, string i, string num, string e, string a, string d, string un)
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
        public Receptionist()
        {

        }
        public Receptionist(string un)
        {
            cusName = un;
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

            string status= null;
            con.Open();
            bool exists = false;
            SqlCommand cmd1 = new SqlCommand("select count(*) from Users where Username= '" + cusUsername + "'", con);
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
        public void loadPaymentTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("select [Order].OrderID,[Customer].Name," +
                " [Types of Service Request].[Service Title], [Order].[Service Type], " +
                "[Order].Status,[Order].Laptop, [Order].[Amount (RM)], [Order].[Payment Status] " +
                "From [dbo].[Order] inner join [dbo].[Customer] on [Order].CustomerID=[Customer].CustomerID inner join " +
                "[dbo].[Types of Service Request] on [Order].[ServiceRequestType ID]=[Types of Service Request].ServiceRequestTypeID", con);
            
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }

        public void paymentDone(float amt, float balanced)
        {
            /*servType = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
            this.Hide();
            fReceipt.lblReqServ.Text = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
            fReceipt.lblServType.Text = this.dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
            fReceipt.lblTotal.Text = this.dataGridViewPayment.CurrentRow.Cells[6].Value.ToString();*/
        }
        public void loadCustomerTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Customer]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }
        public void loadServReqTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Types of Service Request]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }
    }
}

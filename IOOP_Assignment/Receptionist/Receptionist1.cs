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
    internal class Receptionist1
    {

        private string cusName;
        private string cusGender;
        private string cusIC;
        private string cusPhoneNum;
        private string cusEmail;
        private string cusAddress;
        private DateTime cusDob;
        private string cusUsername;
        private int numOfUsers;

        private string recName;
        private string recPhone;
        private string recEmail;
        private string recAddress;
        private string recPw;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string CusName { get => cusName; set => cusName = value; }
        public string CusGender { get => cusGender; set => cusGender = value; }
        public string CusIC { get => cusIC; set => cusIC = value; }
        public string CusPhoneNum { get => cusPhoneNum; set => cusPhoneNum = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }
        public DateTime CusDob { get => cusDob; set => cusDob = value; }
        public string CusUsername { get => cusUsername; set => cusUsername = value; }

        public string RecName { get => recName; set => recName = value; }
        public string RecPhone { get => recPhone; set => recPhone = value; }
        public string RecEmail { get => recEmail; set => recEmail = value; }
        public string RecAddress { get => recAddress; set => recAddress = value; }
        public string RecPw { get => recPw; set => recPw = value; }

        public Receptionist1(string n, string g, string i, string num, string e, string a, DateTime d, string un)
        {
            cusName = n;
            cusGender = g;
            cusIC = i;
            cusPhoneNum = num;
            cusEmail = e;
            cusAddress = a;
            DateTime cusDob = d;
            cusUsername = un;
        }
        public Receptionist1()
        {
            
        }
        public Receptionist1(string un)
        {
            recName = un;
        }

        public void AddNewCustomer()
        {
            con.Open();
            bool exists = true;
            SqlCommand cmdUsernameExist = new SqlCommand("select count(*) from Users where Username= '" + cusUsername + "'", con);
            //count if the username existed
            exists = (int)cmdUsernameExist.ExecuteScalar() > 0;
            if (exists== false)
            {
                int userID = numOfUsers + 1;
                SqlCommand cmdUser = new SqlCommand("SET IDENTITY_INSERT Users ON; insert into Users( UserName, Password,[User Role]) values" +
                        "(@username, '123456', 'customer'); SET IDENTITY_INSERT Users off;", con);
                cmdUser.Parameters.AddWithValue("@username", cusUsername);
                cmdUser.ExecuteNonQuery();
                string birthdate = CusDob.ToString("yyyy-MM-dd");
                SqlCommand cmdNewCus = new SqlCommand("SET IDENTITY_INSERT Customer ON; insert into Customer(UserID,Name,Gender,[Date of Birth],[IC No.]," +
                        "[Contact No.],Email,Address) values" +
                        "( " + userID + " ,'" + cusName + "','" + cusGender + "','" + birthdate + "','" + cusIC + "','" + cusPhoneNum + "','" + CusEmail + "','" + CusAddress + "'); SET IDENTITY_INSERT Customer off; ", con);

                cmdNewCus.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Username existed. Please enter a new username!");
            }
            con.Close();
        }

        public void loadPaymentTable(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("select [Order].OrderID,[Customer].Name," +
                " [Types of Service Request].[Service Title], [Order].[Service Type], " +
                "[Order].Status,[Order].Laptop, [Order].[Amount (RM)], [Order].[Payment Status] " +
                "From [dbo].[Order] inner join [dbo].[Customer] on [Order].CustomerID=[Customer].CustomerID inner join " +
                "[dbo].[Types of Service Request] on [Order].[ServiceRequestType ID]=[Types of Service Request].ServiceRequestTypeID where [Order].[Payment Status]='Unpaid'", con);

            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv.DataSource = dtbl;
            con.Close();
        }
        public string updPaymentStatus(string row)
        {
            string status;
            string pStatusRow = row;
            //string pStatusCell= cell;
            con.Open();
            SqlCommand command = new SqlCommand("update [Order] set [Payment Status] = 'Paid'" +
                " where OrderId = '" + pStatusRow + "'", con);
            //command.Parameters.AddWithValue("Paid", pStatusCell);

            int i = command.ExecuteNonQuery();
            if (i != 0)
                status = "Payment Status has been successfully updated.";
            else
                status = "Update Unsuccessful. Please try again.";
            con.Close();

            return status;
        }
        public void loadCustomerTable(DataGridView dgv1)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Customer]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv1.DataSource = dtbl;
            con.Close();
        }
        public void loadServReqTable(DataGridView dgv2)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Types of Service Request]", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgv2.DataSource = dtbl;
            con.Close();
        }
        public string AddOrder(int cuscell, DateTime dt, int servIDcell, string servType, string tAmt, string lp)
        {
            string status;
            int cusIDCell = cuscell;
            int servID = servIDcell;
            string typeServ = servType;
            string totalAmt = tAmt;
            DateTime date = dt;
            string laptop = lp;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Order](CustomerID, [Date Requested], [ServiceRequestType ID], [Service Type], " +
                "Status, [Amount (RM)], Laptop, [Payment Status]) values (@cusID, @date, @servID, @servType, 'Pending',@amt, @lp, 'Unpaid')", con);
            cmd.Parameters.AddWithValue("@cusID", cusIDCell);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@lp", laptop);
            cmd.Parameters.AddWithValue("@servType", typeServ);
            cmd.Parameters.AddWithValue("@amt", totalAmt);
            cmd.Parameters.AddWithValue("@servID", servID);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Order Confirmed. Thank You!";
            else
                status = "Order Unsuccessful. Please try again.";
            con.Close();
            return status;
        }

        public static void viewRecProfile(Receptionist1 o1)
        {
            con.Open();
            MessageBox.Show(o1.recName.ToString());
            SqlCommand cmd = new SqlCommand("select * from Receptionist where Name = '" + o1.recName + "'", con);
            SqlCommand cmd2 = new SqlCommand("select [Password] from [Users], [Receptionist] where [Users].UserID = [Receptionist].UserID and [Receptionist].Name = '" + o1.recName + "'", con);

            o1.recPw = cmd2.ExecuteScalar().ToString();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                o1.recPhone = sqlDataReader.GetString(7);
                o1.recEmail = sqlDataReader.GetString(8);
                o1.RecAddress = sqlDataReader.GetString(9);
            }
            con.Close();
        }
        public string updReceptionist(string ph, string em, string add)
        {
            SqlCommand cmd1 = new SqlCommand("update [Users] set [Password] = '" + recPw + "' where [UserID] = (select Users.[UserID] from Receptionist, Users where Receptionist.UserID = Users.UserID)", con);

            string status;
            con.Open();

            recPhone = ph;
            recEmail = em;
            recAddress = add;

            SqlCommand cmd = new SqlCommand("Update [Receptionist] set  [Contact No.] = '" + recPhone + "'," +
                " [Email] = '" + recEmail + "', [Address] = '" + recAddress + "'"+" where [UserID] = (select Users.[UserID] from Receptionist, " +
                "Users where Receptionist.UserID = Users.UserID)", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                status = "Your personal details have been successfully updated.";
            }
            else
            {
                status = "Update Unsuccessful. Please try again. ";
            }

            con.Close();
            return status;
        }
        internal string updReceptionistPwd(string pw)
        {
            string status;
            con.Open();

            recPw = pw;

            SqlCommand cmd1 = new SqlCommand("update [Users] set [Password] = '" + recPw + "' where [UserID] =" +
                " (select Users.[UserID] from Receptionist, Users where Receptionist.UserID = Users.UserID)", con);
            int i = cmd1.ExecuteNonQuery();

            if (i != 0)
            {
                status = "Your password have been successfully updated.";
            }
            else
            {
                status = "Update Unsuccessful. Please try again.";
            }

            con.Close();
            return status;


        }
    }
}

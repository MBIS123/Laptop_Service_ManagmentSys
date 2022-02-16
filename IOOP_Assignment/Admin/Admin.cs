using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace IOOP_Assignment
{
    internal class Admin
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString() );
        Users userObj = new Users();

        private string position;
        private string name;
        private string gender;
        private string dateOfBirth;
        private string ethnicity;
        private string address;
        private string emailAddress;
        private string noIC;
        private string phoneNumber;  // for storing data to database
        private bool allInfoFilled = true;  // used for validation 

        private int numOfUsers;
        private int numOfTechnician;
        private int numOfReceptionist; 

        private int totalOfServiceRequested;
        // used for setting up dashboard
        private int lstMthIncome;
        private int lst2MthIncome;
        private int lst3MthIncome; 
        //For displaying the monthly Income data in Monthly Income form
        private string[] monthList = { "January", "February", "March", "April", "May", "June", "July",
                                        "August", "September", "October", "November", "December" }; 
        // for the month label display in admin
        private string[] sFMonthList = { "Jan", "Feb", "Mch", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" }; 

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
        public int NumOfTechnician { get => numOfTechnician; set => numOfTechnician = value; }
        public int NumOfReceptionist { get => numOfReceptionist; set => numOfReceptionist = value; }
        public int TotalOfServiceRequested { get => totalOfServiceRequested; set => totalOfServiceRequested = value; }
        public int LstMthIncome { get => lstMthIncome; set => lstMthIncome = value; }
        public int Lst2MthIncome { get => lst2MthIncome; set => lst2MthIncome = value; }
        public int Lst3MthIncome { get => lst3MthIncome; set => lst3MthIncome = value; }

        internal void showRelatedForm(string x)
        {
            AdminDashBoard adminFrm = new AdminDashBoard();
            AdminMonthlyIncome incomeFrm = new AdminMonthlyIncome();
            AdminRegistration regisFrm = new AdminRegistration();
            AdminServiceReport reportFrm = new AdminServiceReport();
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
                    break;
                case "serviceReport":
                    reportFrm.Show();
                    break;
            }
        }
        internal void numOfUserInDtBase()
        {
            conn.Open();
            SqlCommand cmdNumUser = new SqlCommand("select count(*) from Users", conn);
            numOfUsers = int.Parse(cmdNumUser.ExecuteScalar().ToString());


            SqlCommand cmdNumTech = new SqlCommand("select count(*) from Technician", conn);
            numOfTechnician = int.Parse(cmdNumTech.ExecuteScalar().ToString());


            SqlCommand cmdNumRecep = new SqlCommand("select count(*) from Receptionist", conn);
            numOfReceptionist = int.Parse(cmdNumRecep.ExecuteScalar().ToString());
            conn.Close();
        }
        internal void addNewYear(ComboBox cmbBxYear)
        {
            DateTime tdyDate = DateTime.Now;
            string currentYear = tdyDate.Year.ToString();
            if (currentYear != cmbBxYear.Items[(cmbBxYear.Items.Count - 1)])
                cmbBxYear.Items.Add(currentYear);
        }
        internal DateTime[] searchPass3Months()
        {
            DateTime[] passMonths = new DateTime[3];
            DateTime tdyDate = DateTime.Now;
            passMonths[0] = tdyDate.AddDays(-(tdyDate.Day) - 1);
            passMonths[1] = passMonths[0].AddDays(-(passMonths[0].Day) - 1);
            passMonths[2] = passMonths[1].AddDays(-(passMonths[1].Day) - 1);

            return passMonths;
        }
        internal void pass3MonthsIncome()
        {
            DateTime[] passMonths = searchPass3Months();
            int[] passMonthIncome = new int[3];

            conn.Open();
            for (int i = 0; i < 3; i++) //loop 3 times to get the last 3 month income
            {
                try
                {
                    SqlCommand findPassMonthIncome = new SqlCommand("select SUM([Amount (RM)]) from [Order] where MONTH([Date Requested])=" 
                                                   + passMonths[i].Month + " and YEAR([Date Requested]) =" + passMonths[i].Year + " and [Payment Status]='Paid';", conn);
                    passMonthIncome[i] = (int)findPassMonthIncome.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    passMonthIncome[i] = 0;
                }
            }
            lstMthIncome = passMonthIncome[0];
            lst2MthIncome = passMonthIncome[1];
            lst3MthIncome = passMonthIncome[2];
            conn.Close();
        }

        internal int[] passMonthsRequestedService()
        {
            DateTime[] passMonths = searchPass3Months();
            int[] passMonthsRequestedServ = new int[2];
            conn.Open();
            for (int i = 0; i < 2; i++) //loop 3 times to get the last 3 month requested service
            {

                try
                {
                    SqlCommand findPassMonthRequestedOder = new SqlCommand("select count(*) from [Order] where MONTH([Date Requested])=" + 
                        passMonths[i].Month + " and YEAR([Date Requested]) =" + passMonths[i].Year + ";", conn);
                    passMonthsRequestedServ[i] = (int)findPassMonthRequestedOder.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    passMonthsRequestedServ[i] = 0;
                }
            }
            conn.Close();
            return passMonthsRequestedServ;
        }
        internal void fillDashBoardServInfo(Label lblTotalServ, Label lblServPct)
        {

            int[] passMonthsRqtServ = passMonthsRequestedService();
            int lstMntRqtServ = passMonthsRqtServ[0];
            int lst2MntRqtServ = passMonthsRqtServ[1];
            lblTotalServ.Text = lstMntRqtServ.ToString();

            if (lst2MntRqtServ != 0)
            {
                decimal srvRqtPct = (1 - ((decimal)lstMntRqtServ / (decimal)lst2MntRqtServ)) * 100;

                if (lst2MntRqtServ> lstMntRqtServ)
                {
                    lblServPct.ForeColor = Color.Red;
                    lblServPct.Text = "-" + srvRqtPct.ToString() + "%";
                }
                else if (lst2MntRqtServ == lstMntRqtServ)
                {
                    lblServPct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblServPct.Text = "+0%";
                }
                else
                {
                    lblServPct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblServPct.Text = "+" + srvRqtPct.ToString() + "%";
                }
            }
        }
        internal void compareIncomeBetweenMntPct(Label lblIncomePct)
        {
            if (lst2MthIncome != 0)
            {
                decimal incomePct = (1-((decimal)lstMthIncome / (decimal)lst2MthIncome))* 100;
                incomePct = Math.Round(incomePct, 2);

                if (lst2MthIncome > lstMthIncome)
                {
                    lblIncomePct.ForeColor = Color.Red;
                    lblIncomePct.Text = "-" + incomePct.ToString() + "%";
                }
                else if (lst2MthIncome == lstMthIncome)
                {
                    lblIncomePct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblIncomePct.Text = "+" + (incomePct - 100).ToString() + "%";
                }
                else
                {
                    lblIncomePct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblIncomePct.Text = "+" + incomePct.ToString() + "%";
                }
            }
        } //for dashboard


        internal void changeMonthBarTitle(Label lblBar1, Label lblBar2, Label lblBar3)
        {
            DateTime[] searchPass3Month = searchPass3Months(); //return last month , last last month , last last last month.

            int lstMonth = searchPass3Month[0].Month;
            lblBar1.Text = sFMonthList[lstMonth - 1];

            int lst2Month = searchPass3Month[1].Month;
            lblBar2.Text = sFMonthList[lst2Month - 1];

            int lst3Month = searchPass3Month[2].Month;
            lblBar3.Text = sFMonthList[lst3Month - 1];
        }
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
            }

            else if (ethnic.SelectedIndex == -1)
            {
                allInfoFilled = false;
            }

            else if (gender.SelectedIndex == -1)
            {
                allInfoFilled = false;
            }

            else
            {
                this.gender = gender.SelectedItem.ToString();
                ethnicity = ethnic.SelectedItem.ToString();
            }
        }
        private string generateUserName()
        {
            string headUserName;
            string userName;

            if (position == "technician")
            {
                headUserName = "T_";
                userName = headUserName + dateOfBirth.Replace("-", "") + (numOfTechnician + 1);
            }
            else
            {
                headUserName = "R_";
                userName = headUserName + dateOfBirth.Replace("-", "") + (numOfReceptionist + 1);
            }
            return userName;
        }
        internal void insertDataBase()
        {
            numOfUserInDtBase();
            string userName = generateUserName();
            string password = position + "123";

            conn.Open();
            numOfUsers += 1;     //generating new user
            int techID = numOfTechnician +1;
            int recepID =  numOfReceptionist + 1;

            SqlCommand cmdInsertStaffToUser = new SqlCommand("SET IDENTITY_INSERT Users ON; insert into Users(UserID,UserName,Password,[User Role]) values" +
                                                       "( "+ numOfUsers+" ,'"+userName+"','"+password+"','"+position+ "' ); SET IDENTITY_INSERT Users off; ",conn);
            cmdInsertStaffToUser.ExecuteNonQuery();

            SqlCommand cmdInsertTechnician = new SqlCommand("SET IDENTITY_INSERT Technician ON; insert into Technician(TechnicianID,UserID,Name,Gender,[Date of Birth],Ethnicity,[IC No.],[Contact No.],Email,Address,Status) values" +
                                                      "( "+techID+","+ numOfUsers + " ,'" + name + "','" + gender + "','" + dateOfBirth + "','"+ethnicity + "','"+noIC+ "','"+phoneNumber + "','" +emailAddress+ "','"+address+ "','Available'); SET IDENTITY_INSERT Technician off; ", conn);

            SqlCommand cmdInsertReceptionist = new SqlCommand("SET IDENTITY_INSERT Receptionist ON; insert into Receptionist (ReceptionistID,UserID,Name,Gender,[Date of Birth],Ethnicity,[IC No.],[Contact No.],Email,Address) values" +
                                          "( " + recepID + "," + numOfUsers + " ,'" + name + "','" + gender + "','" + dateOfBirth + "','" + ethnicity + "','" + noIC + "','" + phoneNumber + "','" + emailAddress + "','" + address + "'); SET IDENTITY_INSERT Receptionist off; ", conn);

            if (position == "receptionist")
                cmdInsertReceptionist.ExecuteNonQuery();
            else
            {
                cmdInsertTechnician.ExecuteNonQuery();
                userObj.assignOrder();
            }
               


            conn.Close();
        }

        internal bool checkSelectedMonthYear(ComboBox year , ComboBox month)
        {
            bool beginSearch = false;

            if (year.SelectedIndex == -1 || month.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure Year and Month are selected !", " Reminder ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                beginSearch = true;
            }
            return beginSearch;

        }// for service report form

        internal DataTable generateServiceReport(ComboBox year , ComboBox month)
        {
            int totalOfServiceRequested = 0;
            DataTable servDT = new DataTable();
            servDT.Columns.Add("Year");
            servDT.Columns.Add("Month");
            for (int i = 1; i<=8; i++)
            {
                servDT.Columns.Add(i.ToString());
            }
            servDT.Columns.Add("Total Requested Service");

            string searchYear = year.SelectedItem.ToString();
            string searchMonth = (month.SelectedIndex + 1).ToString();

            conn.Open();

            int[] numOfServeType = new int[8];
            for (int i = 0; i<8;i++ )
            {
                SqlCommand findNumServeType = new SqlCommand("select COUNT(*) from [Order] where MONTH([Date Requested])=" + searchMonth + " and YEAR([Date Requested]) =" + searchYear + "and [ServiceRequestType ID]="+(i+1)+";", conn);
                int serveType = (int)findNumServeType.ExecuteScalar();
                numOfServeType[i] = serveType;
            }

            foreach (int i in numOfServeType)
            {
                totalOfServiceRequested = totalOfServiceRequested + i;
            }

            servDT.Rows.Add(searchYear, month.SelectedItem.ToString(), numOfServeType[0], numOfServeType[1], numOfServeType[2], numOfServeType[3], numOfServeType[4], 
                            numOfServeType[5], numOfServeType[6], numOfServeType[7], totalOfServiceRequested);

            conn.Close();
            return servDT;
        } // for service report form
        internal DataTable generateMonthlyIncome(ComboBox year)     //for monthly income form
        {
            DataTable incomeDT = new DataTable();

            string selectedYear = year.SelectedItem.ToString();
            int monthIncome;

            incomeDT.Columns.Add("Year");
            incomeDT.Columns.Add("Month");
            incomeDT.Columns.Add("Monthly Income (RM)");
            conn.Open();

            for (int  i =0; (i<=monthList.GetUpperBound(0)); i++)
            {
                try
                {
                    SqlCommand findMonthlyIncome = new SqlCommand("select SUM([Amount (RM)]) from [Order] where MONTH([Date Requested])=" + (i + 1) + " and YEAR([Date Requested]) =" + selectedYear + " and [Payment Status]='Paid';", conn);
                    monthIncome = (int)findMonthlyIncome.ExecuteScalar();
                }
                catch (Exception ex){ //will catch System.InvalidCast Exception becuz can't cast null to int (some month has no order , or all order haven't paid in that month)
                    monthIncome = 0;
                }
                incomeDT.Rows.Add(selectedYear,monthList[i], monthIncome);
            }

            conn.Close();
            return incomeDT;

        } 
    
    }
        

    }



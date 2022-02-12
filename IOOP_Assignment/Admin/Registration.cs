using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace IOOP_Assignment
{
    public partial class Registration : Form
    {
        Admin adminObjR = new Admin();
        DataValidation validtObj = new DataValidation();
        


        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (ckBxFilled.Checked)
            {
                if (isValidated())
                {
                    setValueToVar();
                    adminObjR.insertDataBase();
                    MessageBox.Show("Registration Successfully !");
                    clearForm();
                }
                else
                    MessageBox.Show(" Entered data does not meet the format.Please try again");
            }
            else
                MessageBox.Show("Required field was not marked !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ckBxFilled_MouseClick(object sender, MouseEventArgs e)
        {
           

            if (!allFilled(ckBxFilled)) // if not allfilled then need to fill in again ant chkbox will become unchecked
                ckBxFilled.Checked = false;

        }

        private bool allFilled(CheckBox chkBx)
        {

            if (chkBx.Checked)
            {
                adminObjR.AllInfoFilled = true;
                MessageBox.Show(adminObjR.AllInfoFilled.ToString());
                adminObjR.validateRegisCheckComboBx(cmbBxGender, cmbBxEthnic); // will set the value of selected combo box index  to related variable
                MessageBox.Show(adminObjR.AllInfoFilled.ToString() + "for combobox");

                adminObjR.validateRegisPosition(rdBtnTech, rdBtnRecep);       // will set the value of selected radioButton for position to related variable
                MessageBox.Show(adminObjR.AllInfoFilled.ToString()+ "regis positon");
            }
            bool filledInfo = adminObjR.AllInfoFilled; // will return false if the radio button was not click , and checkbox index = -1;

            if ((validtObj.isStringNull(txtName) || validtObj.isStringNull(txtDateOfBirth) || validtObj.isStringNull(txtAddress)
                || validtObj.isStringNull(txtEmailAddress) || validtObj.isStringNull(txtIcNo) || validtObj.isStringNull(txtContactNo)) || !filledInfo) // if gt null value
            {
                MessageBox.Show(txtName.Text +" " + txtDateOfBirth.Text + " "+ txtAddress.Text + " " + txtEmailAddress.Text  +" " +txtIcNo.Text + " "+ txtContactNo.Text + "filled info  = " + filledInfo);
                MessageBox.Show("Please ensure every section was filled !", " Reminder ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool isValidated()
        {
            int sucssCase = 0;

            if (validtObj.isString(txtName.Text) && validtObj.isString(txtAddress.Text))
                sucssCase += 1;
            if (validtObj.isDate(txtDateOfBirth))
                sucssCase += 1;

            if (validtObj.isEmailAddress(txtEmailAddress))
                sucssCase += 1;

            if (validtObj.isIcNum(txtIcNo))
                sucssCase += 1;

            if (validtObj.isPhoneNum(txtContactNo.Text))
                sucssCase += 1;
            MessageBox.Show("num of tsetcase =" + sucssCase.ToString());

            if (sucssCase == 5)  // there are 5 testcase for data validation
                return true;
            else
            {
                return false;
            }

        }

        private void setValueToVar()  // get the value from textbox and pass to related member field
        {
            adminObjR.Name = txtName.Text.ToUpper().Replace(" ", "");
            adminObjR.Address = txtAddress.Text;
            adminObjR.PhoneNumber = txtContactNo.Text;
            adminObjR.DateOfBirth = dateFormation();
            adminObjR.EmailAddress = txtEmailAddress.Text;
            adminObjR.NoIC = txtIcNo.Text;
        }

        private string dateFormation()
        {
            DateTime birthDate;

            DateTime.TryParse(txtDateOfBirth.Text, out birthDate);

            string year = birthDate.Year.ToString().PadLeft(4, '0');
            string day = birthDate.Day.ToString().PadLeft(2, '0');
            string month = birthDate.Month.ToString().PadLeft(2, '0');

            string formattedBirthDate = year + '-' + month + '-' + day;

            return formattedBirthDate; // the birthdate are now in YYYY-MM-DD
        }
        
        private void clearForm()
        {
            txtIcNo.Text =String.Empty;
            txtName.Text = String.Empty;
            txtAddress.Text = String.Empty; 
            txtContactNo.Text = String.Empty;
            txtDateOfBirth.Text = String.Empty;
            txtEmailAddress.Text = String.Empty;
            txtContactNo.Text = String.Empty;
            rdBtnRecep.Checked = false;
            rdBtnTech.Checked = false;
            ckBxFilled.Checked = false;
            cmbBxEthnic.SelectedIndex = -1;
            cmbBxGender.SelectedIndex = -1;

        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome iObj = new MonthlyIncome();
            iObj.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dObj = new DashBoard();
            dObj.Show();
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceReport sObj = new ServiceReport();
            sObj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

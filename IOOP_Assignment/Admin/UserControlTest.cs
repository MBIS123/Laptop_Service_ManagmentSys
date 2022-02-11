﻿

namespace IOOP_Assignment
{
    public partial class UserControlTest : UserControl
    {
        Admin adminObj = new Admin();
        DataValidation validtObj = new DataValidation();
        public UserControlTest()
        {
            InitializeComponent();
        }

        private void UserControlTest_Load(object sender, EventArgs e)
        {

        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (ckBxFilled.Checked)
            {
                if (isValidated())
                {
                    MessageBox.Show("yay finally done registration");
                    setValueToVar();
                    MessageBox.Show(adminObj.Name + " " + adminObj.Ethnicity + " " + adminObj.Gender + " " + adminObj.DateOfBirth + " " + adminObj.EmailAddress + " " + adminObj.PhoneNumber + " " + adminObj.NoIC + " " + adminObj.Position);
                }
                else
                    MessageBox.Show(" Entered data does not meet the format.Please try again");
            }
            else
                MessageBox.Show("Required field was not marked !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ckBxFilled_MouseClick(object sender, MouseEventArgs e)
        {
            adminObj.AllInfoFilled = true;

            if (!allFilled(ckBxFilled)) // if not allfilled then need to fill in again ant chkbox will become unchecked
                ckBxFilled.Checked = false;

        }

        private bool allFilled(CheckBox chkBx)
        {

            if (chkBx.Checked)
            {
                adminObj.validateRegisCheckComboBx(cmbBxGender, cmbBxEthnic); // will set the value of selected combo box index  to related variable
                adminObj.validateRegisPosition(rdBtnTech, rdBtnRecep);       // will set the value of selected radioButton for position to related variable
            }
            bool filledInfo = adminObj.AllInfoFilled; // will return false if the radio button was not click , and checkbox index = -1;

            if ((validtObj.isStringNull(txtName) || validtObj.isStringNull(txtDateOfBirth) || validtObj.isStringNull(txtAddress)
                || validtObj.isStringNull(txtEmailAddress) || validtObj.isStringNull(txtIcNo) || validtObj.isStringNull(txtContactNo)) || !filledInfo) // if gt null value
            {
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

            if (sucssCase == 5)  // there are 5 testcase for data validation
                return true;
            else
            {
                return false;
            }

        }
                private void setValueToVar()  // get the value from textbox and pass to related member field
        {
            adminObj.Name = txtName.Text.ToUpper().Replace(" ","");
            adminObj.Address = txtAddress.Text;
            adminObj.PhoneNumber = txtContactNo.Text;
            //adminObj.DateOfBirth = dateFormation();
            adminObj.EmailAddress = txtEmailAddress.Text;
            adminObj.NoIC = txtIcNo.Text;
        }
    }
}

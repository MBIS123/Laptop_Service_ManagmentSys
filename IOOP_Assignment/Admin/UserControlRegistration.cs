using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{

    public partial class UserControlRegistration : UserControl
    {
        Admin adminObj = new Admin();
        DataValidation validtObj = new DataValidation();    
        
      
        public UserControlRegistration()
        {
            InitializeComponent();
        }

        private void UserControlRegistration_Load(object sender, EventArgs e)
        {
   
            

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (ckBxFilled.Checked)
            {
                if (isValidated())
                    MessageBox.Show("yay finally done registration");
                else
                    MessageBox.Show(" Entered data does not meet the format");
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

           if(validtObj.isString(txtName.Text) && validtObj.isString(txtAddress.Text))
                sucssCase +=1;
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
    }
}

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
    public partial class AdminRegistration : Form
    {
        Admin rAdminObj = new Admin();
        public static string adminName;

        DataValidation validtObj = new DataValidation();
        


        public AdminRegistration()
        {
            InitializeComponent();
        }

        public AdminRegistration(string admName)
        {
            InitializeComponent();
            adminName = admName;
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = adminName;
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (ckBxFilled.Checked == true)
            {
                if (isValidated())
                {
                    setValueToVar();
                    rAdminObj.insertDataBase();
                    MessageBox.Show("Registration Successfully !");
                    clearForm();
                }
                else
                {
                    MessageBox.Show(" Entered data does not meet the format.Please try again", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ckBxFilled.Checked = false;
                }
                
            }
            else
                MessageBox.Show("Required field was not marked !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ckBxFilled_MouseClick(object sender, MouseEventArgs e)
        {         
            if (!allFilled(ckBxFilled)) // if not allfilled then need to fill in again and chkbox will become unchecked
                ckBxFilled.Checked = false;
        }

        private bool allFilled(CheckBox chkBx)
        {
            if (chkBx.Checked)
            {
                rAdminObj.AllInfoFilled = true;
                rAdminObj.validateRegisCheckComboBx(cmbBxGender, cmbBxEthnic); // will set the value of selected combo box index  to related variable
                rAdminObj.validateRegisPosition(rdBtnTech, rdBtnRecep);       // will set the value of selected radioButton for position to related variable
            }
            bool filledInfo = rAdminObj.AllInfoFilled; // will return false if the radio button was not click , and checkbox index = -1;

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
            int failedCase = 0;

            if (!(validtObj.isString(txtName.Text)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid name entered.Please enter a valid name", "Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
            if((validtObj.isStringNull(txtAddress)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid address entered.Please enter a valid address", "Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

            if (!(validtObj.isDate(txtDateOfBirth)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid date of Birth entered.Please enter a valid birthdate", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!(validtObj.isEmailAddress(txtEmailAddress)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid email address entered.Please enter a valid email address", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!(validtObj.isIcNum(txtIcNo)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid IC number entered.Please enter a valid IC number", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!(validtObj.isPhoneNum(txtContactNo.Text)))
            {
                failedCase += 1;
                MessageBox.Show("Invalid contact no entered.Please enter a valid contact no", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (failedCase >=1)  // return false if any of the test case were failed
                return false;
            else
                return true;

        }

        private void setValueToVar()  // get the value from textbox and pass to related member field
        {
            rAdminObj.Name = txtName.Text.ToUpper().Replace(" ", "");
            rAdminObj.Address = txtAddress.Text;
            rAdminObj.PhoneNumber = txtContactNo.Text;
            rAdminObj.DateOfBirth = dateFormation();
            rAdminObj.EmailAddress = txtEmailAddress.Text;
            rAdminObj.NoIC = txtIcNo.Text;
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
            rAdminObj.showRelatedForm("income");
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            rAdminObj.showRelatedForm("dashboard");
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            rAdminObj.showRelatedForm("serviceReport");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}

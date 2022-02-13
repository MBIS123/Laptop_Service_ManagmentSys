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
    public partial class frmAccSet : Form
    {
        public static string Name;
        public frmAccSet()
        {
            InitializeComponent();
        }
        public frmAccSet(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void frmAccSet_Load(object sender, EventArgs e)
        {
            lblRcn.Text = Name;
            Receptionist1 obj1 = new Receptionist1(Name);
            Receptionist1.viewRecProfile(obj1);
            txtMobile.Text = obj1.RecPhone;
            txtEmail.Text = obj1.RecEmail;
            txtAddress.Text = obj1.RecAddress;
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            //validation
            DataValidation objval = new DataValidation();
            if (objval.isString(txtName.Text) == true && objval.isPhoneNum(txtMobile.Text) == true && (objval.isEmailAddress(txtEmail)) == true && (objval.isStringNull(txtAddress) == false)) //all valid
            {
                Receptionist1 obj1 = new Receptionist1(Name);
                MessageBox.Show(obj1.updReceptionist(txtName.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text));
            }
            else
            {
                if (objval.isStringNull(txtName))//name not entered
                {
                    MessageBox.Show("Please enter your name!");
                }
                if (objval.isPhoneNum(txtMobile.Text) == false)//phone number invalid
                {
                    MessageBox.Show("Please enter a correct phone number!");
                }
                if (objval.isEmailAddress(txtEmail) == false) //email invalid
                {
                    MessageBox.Show("Please enter a correct email!");
                }
                if (objval.isStringNull(txtAddress)) //address not entered
                {
                    MessageBox.Show("Please enter a correct address!");
                }
            }
        }
        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            Receptionist1 obj1 = new Receptionist1(Name);
            Receptionist1.viewRecProfile(obj1);
            if (txtCurrentPwd.Text == obj1.RecPw) //Current password entered matches
            {
                DataValidation objpwval = new DataValidation();
                if (objpwval.isPassword(txtNewPwd.Text)) //if new pw is valid
                {
                    if (txtNewPwd.Text == txtConfirmPwd.Text) //if new password match with confirm password
                    {
                        if (txtCurrentPwd.Text == txtNewPwd.Text)// if new password same with old password
                        {
                            MessageBox.Show("The new password you have entered is the same as your current password. Please try again!");
                        }
                        else
                        {
                            MessageBox.Show(obj1.updReceptionistPwd(txtConfirmPwd.Text)); //update to users table
                        }
                    }
                    else //if new pw and confirm pw are different
                    {
                        MessageBox.Show("New password does not match the confirmed password. Please try again!");
                    }
                }
                else //if newpw is not valid
                {
                    MessageBox.Show("New password entered is not valid. Please try again!");

                }
            }
            else // cuurent pw does not match, unable to change pw
            {
                MessageBox.Show("Password entered does not match with your current password. Please try again!");
            }
        }
        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtCurrentPwd.Clear();
            txtNewPwd.Clear();
            txtConfirmPwd.Clear();  
        }
    }
}

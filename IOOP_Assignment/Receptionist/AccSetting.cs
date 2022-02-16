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
        private static string Name;
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
            if (objval.isPhoneNum(txtMobile.Text) == true && (objval.isEmailAddress(txtEmail)) == true &&
                (objval.isStringNull(txtAddress) == false)) //all valid
            {
                Receptionist1 obj1 = new Receptionist1();
                MessageBox.Show(obj1.updReceptionist(txtMobile.Text, txtEmail.Text, txtAddress.Text));
            }
            else
            {
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
        private void btnClear1_Click(object sender, EventArgs e)
        {
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

        private void btnConfirm2_Click_1(object sender, EventArgs e)
        {
            Receptionist1 obj1 = new Receptionist1(Name);
            Receptionist1.viewRecProfile(obj1);
            if (txtCurrentPwd.Text == obj1.RecPw) //Current password entered matches
            {
                DataValidation objpwval = new DataValidation();
                if (objpwval.isPassword(txtNewPwd.Text)) //if new pw is valid
                {
                    if (txtCurrentPwd.Text != txtNewPwd.Text)  //if new pw not same with current pw
                    {
                        if (txtNewPwd.Text == txtConfirmPwd.Text)// if new pw same with confirm pw
                        {
                            MessageBox.Show(obj1.updReceptionistPwd(txtConfirmPwd.Text));//update to users table
                        }
                        else
                        {
                            MessageBox.Show("New password does not match the confirmed password. Please try again!");
                        }
                    }
                    else //if new pw and current pw same
                    {
                        MessageBox.Show("The new password you have entered is the same as your current password. Please try again!");
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
        private void linklblNewCusReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegNewCus fRegCus= new frmRegNewCus(Name);
            fRegCus.Show();
            this.Hide();
        }

        private void linklblServReq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmServRequest fservRq = new frmServRequest();
            fservRq.Show();
            this.Hide();
        }

        private void linklblPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPayment fpayment = new frmPayment();
            fpayment.Show();
            this.Hide();
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}

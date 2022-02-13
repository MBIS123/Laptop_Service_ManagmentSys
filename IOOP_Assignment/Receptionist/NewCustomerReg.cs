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
    public partial class frmRegNewCus : Form
    {
        public static string Name;
        Receptionist1 obj1 = new Receptionist1();
        public frmRegNewCus()
        {
            InitializeComponent();
        }
        public frmRegNewCus(string n)
        {
            InitializeComponent();
            Name = n;
        }
        string Gender;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataValidation objval = new DataValidation();
            if (objval.isString(txtName.Text) == true && objval.isIcNum(txtIC) == true && objval.isPhoneNum(txtMobile.Text) == true
                && objval.isEmailAddress(txtEmail) == true && objval.isStringNull(txtAddress) == false && objval.isStringNull(txtUsername) == false)
            {
                if (radBtnFemale.Checked == true)
                {
                    Gender = "Female";
                    DateTime bdaydate1 = DateTime.Parse(dateTimePickerDate.Text);
                    Receptionist1 obj1 = new Receptionist1(txtName.Text, Gender, txtIC.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, bdaydate1, txtUsername.Text);
                    MessageBox.Show(obj1.AddNewCustomer());
                }
                else if (radBtnMale.Checked ==true)
                {
                    Gender = "Male";
                    DateTime bdaydate2 = DateTime.Parse(dateTimePickerDate.Text);
                    Receptionist1 obj1 = new Receptionist1(txtName.Text, Gender, txtIC.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, bdaydate2, txtUsername.Text);
                    MessageBox.Show(obj1.AddNewCustomer());
                }
                else
                {
                    MessageBox.Show("Please choose your gender!");
                }
            }
            else
            {
                if (objval.isStringNull(txtName))//name not entered
                {
                    MessageBox.Show("Please enter your name!");
                }
                if (objval.isIcNum(txtIC) ==false)
                {
                    MessageBox.Show("Please enter a correct IC number!");
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
                if (objval.isStringNull(txtUsername))
                {
                    MessageBox.Show("Please enter your username!");
                }
            }
            
        }

        private void frmRegNewCus_Load(object sender, EventArgs e)
        {
            lblRcn.Text = Name;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtIC.Clear();
            txtMobile.Clear();
            txtUsername.Clear();
            radBtnFemale.Checked = false;
            radBtnMale.Checked = false;
        }


        private void linklblServReq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmServRequest fservRq = new frmServRequest();
            fservRq.Show();
            this.Hide();
        }

        private void linklblAccSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccSet faccSet = new frmAccSet();
            faccSet.Show();
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
            frmLogin flogout = new frmLogin();
            flogout.Show();
            this.Hide();
        }
    }
}

using IOOP_Assignment.Customer;
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
    public partial class update_profile : Form
    {
        public static string name;
        public update_profile(string n)
        {
            InitializeComponent();
            name = n;
        }
        public update_profile()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) //passing all customer's details into textbox accordingly
        {
            lbl_cusName.Text = name;
            Customers obj1 = new Customers(name);
       //     Customers.viewCustomerProfile(obj1);
            txtname.Text = obj1.CusName1;
            txtbirthdate.Text = obj1.CusBOD1.ToString("dd/MM/yyyy");
            txtphonenum.Text = obj1.CusPhoneNo1;
            txtemail.Text = obj1.CusEmail1;
            txtaddress.Text = obj1.CusAddress1;
            txtcurrentpassw.Text = obj1.CusPassword1;

        }

        private void llbaccount_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Viewprofile view_prof = new Viewprofile();
            view_prof.ShowDialog();
        }

        private void llbchange_serv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            change_service change = new change_service();
            change.ShowDialog();
        }

        private void llbmy_order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Myorder order = new Myorder();
            order.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcurrentpassw.Text = String.Empty;

        }

        private void btnclear_cusInfo_Click(object sender, EventArgs e)
        {
            txtname.Text = String.Empty;
            txtbirthdate.Text = String.Empty;
            txtphonenum.Text = String.Empty;
            txtemail.Text = String.Empty;
            txtaddress.Text = String.Empty;
        }

        private void btn_savePassword_Click(object sender, EventArgs e)
        {
            Customers obj_passw = new Customers(name);
            DataValidation obj_validationpassw = new DataValidation(); // for validate password

            //view the current password

           // Customers.viewCustomerProfile(obj_passw); // pass in my username inside method viewCustomerProfile


            Customers.viewCustomerProfile(obj_passw); // pass in my username inside method viewCustomerProfile
            

            if (txtcurrentpassw.Text == obj_passw.CusPassword1) //compare the current password with get password (from method viewCustomerProfile)
            {
                if ((txtnewpassw.Text == txtconfirmpassw.Text) && (obj_validationpassw.isPassword(txtnewpassw.Text)) && (obj_validationpassw.isStringNull(txtnewpassw) == false && (obj_validationpassw.isStringNull(txtconfirmpassw) == false)))
                // make condition new passw & conf passw must same AND new passw validated AND both new passw & conf passw text box cannot be null
                {
                    MessageBox.Show(obj_passw.updateCustomerPassword(txtnewpassw.Text));
                }
                else
                {
                    MessageBox.Show("Dear customer," + "\n" + "Please make sure :" + "\n" + "1. New Password and Confirm Password is same." + "\n" + "2. Password format is correct." + "\n" + "3. Make sure has not entered null, empty or whitespace value.");
                }

            }
            else
            {
                MessageBox.Show("Dear customer, password entered not match current password");
            }

        }

        private void btnsave_cusInfo_Click(object sender, EventArgs e)
        {
            DataValidation objvalidation = new DataValidation();

            //check whether text box is null or not 
            if (objvalidation.isStringNull(txtname) == true)
            {
                MessageBox.Show("Dear customer, you have not entered a new Name");
            }
            else if (objvalidation.isStringNull(txtbirthdate) == true)
            {
                MessageBox.Show("Dear customer, you have not entered a new Date of Birth");
            }
            else if(objvalidation.isStringNull(txtphonenum) == true)
            {
                MessageBox.Show("Dear customer, you have not entered a new phone number");

            }
            else if (objvalidation.isStringNull(txtemail) == true)
            {
                MessageBox.Show("Dear customer, you have not entered a new email");
            }
            else if(objvalidation.isStringNull(txtaddress) == true)
            {
                MessageBox.Show("Dear customer, you have not entered a new address");
            }
            else
            {
                // do all validation for customer's details here 
                if (objvalidation.isString(txtname.Text) && objvalidation.isDate(txtbirthdate) && objvalidation.isPhoneNum(txtphonenum.Text) && objvalidation.isEmailAddress(txtemail) && objvalidation.isStringNull(txtaddress) == false)
                {
                    Customers obj1 = new Customers(name);
                    DateTime DOB = Convert.ToDateTime(txtbirthdate.Text);
                    MessageBox.Show(obj1.updateCustomerProfile(txtname.Text, DOB, txtphonenum.Text, txtemail.Text, txtaddress.Text));
                }
                else
                {
                    MessageBox.Show("Dear customer, please make sure you have enter new personal information to save.");
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


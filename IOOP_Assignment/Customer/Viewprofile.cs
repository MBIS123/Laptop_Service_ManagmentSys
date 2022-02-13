using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment.Customer
{
    public partial class Viewprofile : Form
    {
        public static string name;
        public Viewprofile()
        {
            InitializeComponent();
        }
        public Viewprofile(string n)
        {
            InitializeComponent();
            name = n;
        }       

        private void Viewprofile_Load_1(object sender, EventArgs e)
        {
            lbl_cusName.Text = name;
            Customers obj1 = new Customers(name);
            Customers.viewCustomerProfile(obj1);
            lblcusName.Text = obj1.CusName1; //get customer's name
            lblcusDOB.Text = (obj1.CusBOD1).ToString("dd / MM / yyyy");//get customer's date of birth
            lblcusPhno.Text = obj1.CusPhoneNo1;//get customer'suser's phone number
            lblcusEmail.Text = obj1.CusEmail1;//get user's customer's email
            lblcusAddress.Text = obj1.CusAddress1;//get customer's address
            lblcusCurrentPassw.Text = obj1.CusPassword1;//get customer's password
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            update_profile up_prof = new update_profile();
            up_prof.ShowDialog();
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
    }
}

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
        public static string name;
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
            DateTime bdaydate = DateTime.Parse(dateTimePickerDate.Text);
            Receptionist1 obj1 = new Receptionist1(txtName.Text,Gender, txtIC.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, bdaydate, txtUsername.Text);
            MessageBox.Show(obj1.AddNewCustomer());
        }

        private void frmRegNewCus_Load(object sender, EventArgs e)
        {

        }

        private void radBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
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
    }
}

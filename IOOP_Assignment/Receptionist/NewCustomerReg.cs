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
            Receptionist1 obj1 = new Receptionist1(txtName.Text,Gender, txtIC.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, dateTimePickerDate.Text, txtUsername.Text);
            obj1.allSecFill();
            MessageBox.Show(obj1.addNewCus());
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

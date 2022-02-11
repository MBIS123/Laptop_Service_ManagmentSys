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
        Receptionist obj1 = new Receptionist();
        public frmRegNewCus()
        {
            InitializeComponent();
        }
        string Gender;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(txtName.Text,Gender, txtIC.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, dateTimePickerDate.Text, txtUsername.Text);
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

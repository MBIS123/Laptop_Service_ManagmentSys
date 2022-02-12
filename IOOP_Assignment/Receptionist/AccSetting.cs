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
    //public static string Name;
    public partial class frmAccSet : Form
    {
        public frmAccSet()
        {
            InitializeComponent();
        }
        public frmAccSet(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //validation
            DataValidation objval = new DataValidation();
            if (objval.isPhoneNum(txtMobile.Text) && (objval.isStringNull(txtAddress) == false)) //&& (objval.isEmailAddress(txtEmail));
            {
                Receptionist1 obj1 = new Receptionist1(Name);
                MessageBox.Show(obj1.updReceptionist(txtMobile.Text, txtEmail.Text, txtAddress.Text, txtConfirmPwd.Text));
            }
            else
            {
                MessageBox.Show("Invalid!");
            }   
        }
    }
}

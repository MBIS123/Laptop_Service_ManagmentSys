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

    public partial class UserControlRegistration : UserControl
    {
        Admin obj = new Admin();
        DataValidation validtObj = new DataValidation();    
        
      
        public UserControlRegistration()
        {
            InitializeComponent();
        }

        private void UserControlRegistration_Load(object sender, EventArgs e)
        {
   
            

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            obj.validateRegisPosition(rdBtnTech,rdBtnRecep);
            obj.validateRegisCheckComboBx(cmbBxGender, cmbBxEthnic);
            obj.checking();
            obj.askToReenter();

            if (validtObj.isIcNum(txtIcNo))
                MessageBox.Show("True");

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

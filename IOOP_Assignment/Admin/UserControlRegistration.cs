using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    public partial class UserControlRegistration : UserControl
    {
        private string name;
        public UserControlRegistration()
        {
            InitializeComponent();
        }

        private void UserControlRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            name = txtFirstName.Text;  
            
            
            
            
            
        }
    }
}

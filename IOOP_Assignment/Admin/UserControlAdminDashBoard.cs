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
    public partial class UserControlAdminDashBoard : UserControl
    {
        public UserControlAdminDashBoard()
        {
            InitializeComponent();
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminPageObj = new AdminDashBoard();
          
            
        }

        private void UserControlAdminDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}

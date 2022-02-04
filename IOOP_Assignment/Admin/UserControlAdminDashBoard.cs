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
    public partial class UserControlAdminDashBoard : UserControl
    {
        public UserControlAdminDashBoard()
        {
            InitializeComponent();
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            AdminPage adminPageObj = new AdminPage();
            adminPageObj.hideAllUserCtrl();
            UserControlServiceReport uCServiceReport = new UserControlServiceReport();
            uCServiceReport.Show();
            uCServiceReport.BringToFront();
            
        }

        private void UserControlAdminDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}

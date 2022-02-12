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
    public partial class MonthlyIncome : Form
    {
        Admin objAdminI = new Admin();
        public MonthlyIncome()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rObj = new Registration();
            rObj.Show();

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dObj = new DashBoard();
            dObj.Show();
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceReport sObj = new ServiceReport();
            sObj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}

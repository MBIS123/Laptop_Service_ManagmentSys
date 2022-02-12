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
    public partial class ServiceReport : Form
    {
     
        public ServiceReport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        internal void showServiceReport()
        {
            this.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dObj = new DashBoard();
            dObj.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rObj = new Registration();
            rObj.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome iObj = new MonthlyIncome();
            iObj.Show();
        }
    }
}

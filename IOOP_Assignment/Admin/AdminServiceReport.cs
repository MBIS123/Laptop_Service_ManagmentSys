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
     
    public partial class AdminServiceReport : Form
    {
     
        Admin sAdminObj = new Admin();
        public static string adminName;

        public AdminServiceReport(string admName)
        {
            InitializeComponent();
            adminName = admName;
        }
        public AdminServiceReport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           sAdminObj.exitSystem();
        }
        internal void showServiceReport()
        {
            this.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAdminObj.showRelatedForm("dashboard");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAdminObj.showRelatedForm("registration");
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAdminObj.showRelatedForm("income");
        }

        private void ServiceReport_Load(object sender, EventArgs e)
        {
            sAdminObj.addNewYear(cmbBxYear);
            lblAdminName.Text = adminName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool beginSearch = sAdminObj.checkSelectedMonthYear(cmbBxYear, cmbBxMonth);

            if (beginSearch)
            {
                dataGVServiceReport.DataSource = sAdminObj.generateServiceReport(cmbBxYear, cmbBxMonth);
            }
       
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}

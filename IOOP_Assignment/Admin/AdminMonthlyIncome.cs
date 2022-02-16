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
    public partial class AdminMonthlyIncome : Form
    {
        Admin iAdminObj = new Admin();
        public static string adminName;

        public AdminMonthlyIncome(string admnName)
        {
            InitializeComponent();
            adminName = admnName;
        }

        public AdminMonthlyIncome()
        {
            InitializeComponent();
        }
      
        private void MonthlyIncome_Load(object sender, EventArgs e)
        {
            iAdminObj.addNewYear(cmbBxYear);
            lblAdminName.Text = adminName;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            iAdminObj.showRelatedForm("registration");
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            iAdminObj.showRelatedForm("dashboard");
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            iAdminObj.showRelatedForm("serviceReport");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iAdminObj.exitSystem();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbBxYear.SelectedIndex != -1)
                dtGVIncome.DataSource = iAdminObj.generateMonthlyIncome(cmbBxYear);
            else
                MessageBox.Show("Please select a year !", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

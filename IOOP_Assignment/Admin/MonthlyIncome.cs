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
            objAdminI.showRelatedForm("registration");

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            objAdminI.showRelatedForm("dashboard");
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            objAdminI.showRelatedForm("serviceReport");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MonthlyIncome_Load(object sender, EventArgs e)
        {
            objAdminI.addNewYear(cmbBxYear);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbBxYear.SelectedIndex != -1)
                dtGVIncome.DataSource = objAdminI.generateMonthlyIncome(cmbBxYear);
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

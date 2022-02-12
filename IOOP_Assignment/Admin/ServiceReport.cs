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
     
        Admin objS = new Admin();
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
            objS.showRelatedForm("dashboard");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            objS.showRelatedForm("registration");
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            objS.showRelatedForm("income");
        }

        private void ServiceReport_Load(object sender, EventArgs e)
        {

            objS.addNewYear(cmbBxYear);

            if (!this.DesignMode)
            {
                objS.loadtoDataGridView(dataGVServiceReport);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool beginSearch = objS.chkYearMonthSelected(cmbBxYear, cmbBxMonth);
                
        }
    }
}

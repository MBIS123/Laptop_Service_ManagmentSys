using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class AdminDashBoard : Form
    {
        
        public static string adminName;

        Admin dAminObj = new Admin();

        AdminMonthlyIncome objM = new AdminMonthlyIncome(adminName);
        AdminRegistration objR = new AdminRegistration(adminName);
        AdminServiceReport objS = new AdminServiceReport(adminName);
        public AdminDashBoard()
        {
            InitializeComponent();
            
        }
        public AdminDashBoard(string adnName)
        {
            InitializeComponent();
            adminName = adnName;
        }
   

        private void Admin_Load(object sender, EventArgs e)
        {
            dAminObj.numOfUserInDtBase();
            lblAdminName.Text = adminName;
            lblNoOfRecep.Text = dAminObj.NumOfReceptionist.ToString();
            lblNoOfTech.Text =dAminObj.NumOfTechnician.ToString();
            lblTotalRecpTech.Text = (dAminObj.NumOfReceptionist + dAminObj.NumOfTechnician).ToString();
            dAminObj.searchPass3Months();
            dAminObj.pass3MonthsIncome();
            dAminObj.changeMonthBarTitle(lblMnthBar1,lblMnthBar2,lblMnthBar3);
            dAminObj.compareIncomeBetweenMntPct(lblProfitPct);
            
            lblIncome.Text = "RM " + dAminObj.LstMthIncome.ToString();

            dAminObj.fillDashBoardServInfo(lblLstMthServ, lblServPct);

            int sizeLastMonthBar = (int)(((decimal)dAminObj.LstMthIncome / 6000) * 430);
            lblServBar1.Size = new Size(sizeLastMonthBar, 30);
            int sizeLast2MonthBar = (int)(((decimal)dAminObj.Lst2MthIncome / 6000) * 430);
            lblServBar2.Size = new Size(sizeLast2MonthBar, 30);
            int sizeLast3MonthBar = (int)(((decimal)dAminObj.Lst3MthIncome / 6000) * 430);
            lblServBar3.Size = new Size(sizeLast3MonthBar, 30);

        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            dAminObj.showRelatedForm("income");
        }

        internal void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            dAminObj.showRelatedForm("serviceReport");
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {   
            this.Hide();
            dAminObj.showRelatedForm("registration");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           dAminObj.exitSystem();
        }
        private void btnServReport_Click(object sender, EventArgs e) // the blue button
        {
            this.Hide();
            dAminObj.showRelatedForm("serviceReport");
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
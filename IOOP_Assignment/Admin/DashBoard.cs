using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class DashBoard : Form
    {
        
        Admin adminObjD = new Admin();
        DateTime[] passMonth = new DateTime[3];
        string[] monthlist = Admin.Monthlist;


        public DashBoard()
        {
            InitializeComponent();
            
        }

      

        private void Admin_Load(object sender, EventArgs e)
        {
            adminObjD.numOfUserInDtBase();
            lblNoOfRecep.Text = adminObjD.NumOfReceptionist.ToString();
            lblNoOfTech.Text =adminObjD.NumOfTechnician.ToString();
            passMonth = adminObjD.searchPass3Months();
            int[] passMonthsIncome = adminObjD.pass3MonthsIncome();
            int passMonthIncome = passMonthsIncome[0];
            int pass2MonthIncome = passMonthsIncome[1];
            int pass3MonthIncome = passMonthsIncome[2];

            lblIncome.Text = passMonthIncome.ToString();
            MessageBox.Show(passMonthIncome.ToString() + "asdhjk");
            if ( pass2MonthIncome-passMonthIncome > 0)
            {
                lblProfitPct.ForeColor = Color.Red;
                lblProfitPct.Text = "- " + (Math.Round((decimal)(1 -(passMonthIncome/pass2MonthIncome)),2)*100).ToString() + "%";
            }



             
        }

      

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminObjD.showRelatedForm("income");


        }

        internal void btnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminObjD.showRelatedForm("serviceReport");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {   
            this.Hide();
            adminObjD.showRelatedForm("registration");

        }


        private void btnDashBoard_MouseLeave(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = ColorTranslator.FromHtml("#0A0909");
        }

        private void btnDashBoard_MouseEnter(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = ColorTranslator.FromHtml("#464646");
        }

        //DEFINED FUNCTION


        private void chgForeColour(Button x) //changeThe fore color of button to indicate which user control was shown
        {
            btnDashBoard.ForeColor= Color.White;  
            btnRegistration.ForeColor= Color.White;
            btnServiceReport.ForeColor= Color.White;
            btnIncome.ForeColor= Color.White;
          x.ForeColor = Color.FromArgb(36, 192, 251);

        }

        private void chgSideLabelLocation(Button x)
        {
            sideLabel.Location =  new Point(3,x.Location.Y);
        }

       //yused to show related user control

        private void btnRegistration_MouseEnter(object sender, EventArgs e)
        {
            btnRegistration.BackColor = ColorTranslator.FromHtml("#464646");
        }

        private void btnRegistration_MouseLeave(object sender, EventArgs e)
        {
            btnRegistration.BackColor = ColorTranslator.FromHtml("#0A0909");
        }

        private void btnIncome_MouseEnter(object sender, EventArgs e)
        {
            btnIncome.BackColor = ColorTranslator.FromHtml("#464646");
        }

        private void btnIncome_MouseLeave(object sender, EventArgs e)
        {
            btnIncome.BackColor = ColorTranslator.FromHtml("#0A0909");
        }

        private void btnServiceReport_MouseEnter(object sender, EventArgs e)
        {
            btnServiceReport.BackColor = ColorTranslator.FromHtml("#464646");
        }

        private void btnServiceReport_MouseLeave(object sender, EventArgs e)
        {
            btnServiceReport.BackColor = ColorTranslator.FromHtml("#0A0909");
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(57,57,57);
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(20,20,20);
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(57, 57, 57);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(10,10,10);
        }

        private void showForm(Registration a)
        {
            this.Hide();
            a.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uCBtnServiceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceReport sObj = new ServiceReport();
            sObj.Show();
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
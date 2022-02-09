using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminPage : Form
    {

        public AdminPage()
        {
            InitializeComponent();
        }

      

        private void Admin_Load(object sender, EventArgs e)
        {
            hideAllUserCtrl();
            pcBxDashBrd.Show();
            userControlAdminDashBoard1.Show();
            userControlAdminDashBoard1.BringToFront();


        }

      
        private void userControlMonthlyIncome1_Load(object sender, EventArgs e)
        {

            hideAllUserCtrl();
            userControlAdminDashBoard1.Show();
            userControlAdminDashBoard1.BringToFront();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            hideAllUserCtrl();
            frmHeader.Text = "Monthly Income";   
            pcBxIncome.Show();
            chgSideLabelLocation(btnIncome);
            chgForeColour(btnIncome);
            showUserControl("Income");

        }

        internal void btnServiceReport_Click(object sender, EventArgs e)
        {
            hideAllUserCtrl();
            frmHeader.Text = "Service Report";
            pcBxServRpt.Show();
            chgSideLabelLocation(btnServiceReport);
            chgForeColour(btnServiceReport);
            showUserControl("Service Report");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            hideAllUserCtrl();
            frmHeader.Text = "Registration";
            pcBxRegis.Show();
            chgSideLabelLocation(btnRegistration);
            chgForeColour(btnRegistration);
            showUserControl("Registration");

        }



        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            hideAllUserCtrl();
            frmHeader.Text = "Admin DashBoard";
            pcBxDashBrd.Show();
            chgSideLabelLocation(btnDashBoard);
            chgForeColour(btnDashBoard);
            showUserControl("DashBoard");
     
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
        internal void hideAllUserCtrl()
        {
            userControlMonthlyIncome1.Hide();
            userControlRegistration1.Hide();
            userControlServiceReport1.Hide();
            userControlAdminDashBoard1.Hide();
            pcBxDashBrd.Hide();
            pcBxIncome.Hide();
            pcBxRegis.Hide();
            pcBxServRpt.Hide();

        }

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

        private void showUserControl(String useCtrlName )
        {
            switch (useCtrlName)
            {
                case "DashBoard" :
                    userControlAdminDashBoard1.Show();
                    userControlAdminDashBoard1.BringToFront();
                    break;
                case "Registration":
                    userControlRegistration1.Show();
                    userControlRegistration1.BringToFront();
                    break ;
                case "Income":
                    userControlMonthlyIncome1.Show();
                    userControlMonthlyIncome1.BringToFront();
                    break;;
                case "Service Report":
                    userControlServiceReport1.Show();
                    userControlServiceReport1.BringToFront();
                    break;

            }

        } //yused to show related user control

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

        private void pcBxDashBrd_Click(object sender, EventArgs e)
        {

        }

        private void frmHeader_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
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


    }
}
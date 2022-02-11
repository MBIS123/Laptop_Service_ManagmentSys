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
            pcBxDashBrd.Show();


        }

      

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmHeader.Text = "Monthly Income";   
         
            chgSideLabelLocation(btnIncome);
            chgForeColour(btnIncome);

        }

        internal void btnServiceReport_Click(object sender, EventArgs e)
        {
           
            frmHeader.Text = "Service Report";
            pcBxServRpt.Show();
            chgSideLabelLocation(btnServiceReport);
            chgForeColour(btnServiceReport);
           
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
         
            frmHeader.Text = "Registration";
          
            chgSideLabelLocation(btnRegistration);
            chgForeColour(btnRegistration);
           

        }



        private void btnDashBoard_Click(object sender, EventArgs e)
        {
           
            frmHeader.Text = "Admin DashBoard";
            pcBxDashBrd.Show();
            chgSideLabelLocation(btnDashBoard);
            chgForeColour(btnDashBoard);
           
     
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
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class AdminDashBoard : Form
    {
        
        Admin adminObjD = new Admin();
   





        public AdminDashBoard()
        {
            InitializeComponent();
            
        }

      

        private void Admin_Load(object sender, EventArgs e)
        {
            adminObjD.numOfUserInDtBase();
            lblNoOfRecep.Text = adminObjD.NumOfReceptionist.ToString();
            lblNoOfTech.Text =adminObjD.NumOfTechnician.ToString();
            lblTotalRecpTech.Text = (adminObjD.NumOfReceptionist + adminObjD.NumOfTechnician).ToString();

            adminObjD.changeMonthBarTitle(lblMnthBar1,lblMnthBar2,lblMnthBar3);
            

            int[] passMonthsIncome = adminObjD.pass3MonthsIncome();
            int lstMthIncome = passMonthsIncome[0];
            int lst2MthIncome = passMonthsIncome[1];
            int lst3MthIncome = passMonthsIncome[2];
            
            lblIncome.Text = "RM " + lstMthIncome.ToString();

            if (lst2MthIncome != 0)
            {
                decimal incomePct = ((decimal)lstMthIncome / (decimal)lst2MthIncome) * 100;
                incomePct = Math.Round(incomePct, 2);

   

                if (lst2MthIncome - lstMthIncome > 0)
                {
                    lblProfitPct.ForeColor = Color.Red;
                    lblProfitPct.Text = "-" + incomePct.ToString() + "%";
                }
                else if (lst2MthIncome == lstMthIncome)
                {
                    lblProfitPct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblProfitPct.Text = "+" + (incomePct - 100).ToString() + "%";
                }
                else
                {
                    lblProfitPct.ForeColor = Color.FromArgb(0, 192, 0);
                    lblProfitPct.Text = "+" + incomePct.ToString() + "%";
                }
            }
            adminObjD.fillDashBoardServInfo(lblLstMthServ, lblServPct);

            int sizeLastMonthBar = (int)(((decimal)lstMthIncome / 6000) * 430);
            lblServBar1.Size = new Size(sizeLastMonthBar, 30);
            int sizeLast2MonthBar = (int)(((decimal)lst2MthIncome / 6000) * 430);
            lblServBar2.Size = new Size(sizeLast2MonthBar, 30);

            int sizeLast3MonthBar = (int)(((decimal)lst3MthIncome / 6000) * 430);
            lblServBar3.Size = new Size(sizeLast3MonthBar, 30);






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

        private void showForm(AdminRegistration a)
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
            AdminServiceReport sObj = new AdminServiceReport();
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

        private void btnServReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminObjD.showRelatedForm("serviceReport");
        }

        private void lblMnthBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
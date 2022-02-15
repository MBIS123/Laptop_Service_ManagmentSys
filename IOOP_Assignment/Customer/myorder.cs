using IOOP_Assignment.Customer;

namespace IOOP_Assignment
{
    public partial class Myorder : Form
    {
        public static string name;
        public Myorder(string n)
        {
            InitializeComponent();
            name = n; //customer name here
        }
        public Myorder()
        {
            InitializeComponent();
        }

        private void Myorder_Load(object sender, EventArgs e)
        {
            lbl_cusName.Text = name; //display customer name
            Customers obj1 = new Customers(name);
            lblserv_desc.Text = obj1.showservdesc();
            lblamount_pay.Text = obj1.showAmount_ToPaid();
            lbl_orderstatus.Text = obj1.showStatus();
            lblcollec_date.Text = obj1.showCollec_date();
        }

        private void llbchange_serv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            change_service change = new change_service(name);
            change.ShowDialog();
            this.Close();
        }

        private void llbaccount_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Viewprofile view_prof = new Viewprofile(name);
            view_prof.ShowDialog();
            this.Close();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers();
            if (txtreview.Text != "")
            {
                MessageBox.Show(obj1.store_comment(txtreview.Text));
            }
            else
            {
                MessageBox.Show("You have not entered any comment yet !");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtreview.Text = String.Empty;
        }

        private void llblogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        
    }
}
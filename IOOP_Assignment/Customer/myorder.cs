using IOOP_Assignment.Customer;

namespace IOOP_Assignment
{
    public partial class Myorder : Form
    {
        public static string name;
        public Myorder(string n)
        {
            InitializeComponent();
            name = n; //username here
        }
        public Myorder()
        {
            InitializeComponent();
        }
        
        private void Myorder_Load(object sender, EventArgs e)
        {
            lbl_cusName.Text = name;
            Customers obj1 = new Customers(name);
            lblserv_desc.Text = obj1.showservdesc();
            lblamount_pay.Text = obj1.showAmount_ToPaid();
            lblstatus.Text = obj1.showStatus();
            lblexpected_collect_date.Text = obj1.showExpec_date();
            lblcollec_date.Text=obj1.showCollec_date();
            // i want display service description in my lbl by using method show_servdesc
        }

        private void llbchange_serv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            change_service change = new change_service();
            change.ShowDialog();
        }

        private void llbaccount_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Viewprofile view_prof = new Viewprofile();
            view_prof.ShowDialog();

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
    }
}
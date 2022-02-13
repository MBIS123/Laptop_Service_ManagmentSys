using IOOP_Assignment.Customer;
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
    public partial class change_service : Form
    {
        public static string name;
        string Type;
        int index;
        public change_service(string n)
        {
            InitializeComponent();
            name = n;//customer name here
        }
        public change_service()
        {
            InitializeComponent();
        }
        private void change_service_Load(object sender, EventArgs e)
        {
            lbl_cusName.Text = name;

        }
        private void rdb_normal_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Normal";
        }

        private void rdb_urgent_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Urgent";
        }

        private void lstservices_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstservices.SelectedIndex;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string decide_change_service = lstservices.Text;
            Customers obj0 = new Customers(name);


            if (lstservices.SelectedItems.Count == 1 && (rdb_normal.Checked || rdb_urgent.Checked))
            {
                if (obj0.validationstatus() == true)
                {
                    lbl_decided_change_service.Text = "You have change service from " + decide_change_service + " with " + Type + " successfully";
                    Customers obj1 = new Customers(name);
                    MessageBox.Show(obj1.changeservice(index, Type));
                }
                else
                {
                    MessageBox.Show("Your service status is completed. You are not allowed to change service anymore");
                }

            }
            else
                MessageBox.Show("You have not choose service / service type yet");

        }

        private void llbmy_order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Myorder order = new Myorder(name);
            order.ShowDialog();
            this.Close();
        }

        private void llbaccount_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Viewprofile view_prof = new Viewprofile(name);
            view_prof.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void llblogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
            this.Close();
        }
    }
}

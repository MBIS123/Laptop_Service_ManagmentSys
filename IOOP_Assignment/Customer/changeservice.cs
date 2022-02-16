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
        int amount;
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
                    lbl_decided_change_service.Text = ("You have change service from " + decide_change_service + " with " + Type + " successfully");
                    Customers obj1 = new Customers(name);
                    if (index == 0)
                    {
                        if (Type != "Normal")
                        {
                            amount = 80;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 50;
                        }
                    }
                    else if (index == 1)
                    {
                        if (Type != "Normal")
                        {
                            amount = 90;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 60;
                        }
                    }
                    else if (index == 2)
                    {
                        if (Type != "Normal")
                        {
                            amount = 430;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 380;
                        }
                    }
                    else if (index == 3)
                    {
                        if (Type != "Normal")
                        {
                            amount = 200;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 160;
                        }
                    }
                    else if (index == 4)
                    {
                        if (Type != "Normal")
                        {
                            amount = 210;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 180;
                        }
                    }
                    else if (index == 5)
                    {
                        if (Type != "Normal")
                        {
                            amount = 150;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 100;
                        }
                    }
                    else if (index == 6)
                    {
                        if (Type != "Normal")
                        {
                            amount = 130;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 80;
                        }
                    }
                    else
                    {
                        if (Type != "Normal")
                        {
                            amount = 100;
                        }
                        else if (Type != "Urgent")
                        {
                            amount = 70;
                        }
                    }

                        MessageBox.Show(obj1.changeservice(index, Type, amount));

                    }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Your service status is completed. You are not allowed to change service anymore", "Error", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        change_service change = new change_service();
                        change.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("You have not choose service / service type yet", "Error");
            }

        }
        

        private void llbaccount_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Viewprofile view_prof = new Viewprofile(name);
            view_prof.ShowDialog();
            this.Close();
        }

        private static void label14_Click(object sender, EventArgs e)
        {

        }

        private static void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private static void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llbmy_order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Myorder order = new Myorder(name);
            order.ShowDialog();
            this.Close();
        }

        private void llblogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

    }
}

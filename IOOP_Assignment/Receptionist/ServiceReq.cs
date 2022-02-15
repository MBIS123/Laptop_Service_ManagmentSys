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
    public partial class frmServRequest : Form
    {
        private static string Name;
        public frmServRequest()
        {
            InitializeComponent();
        }
        public frmServRequest(string n)
        {
            InitializeComponent();
            Name = n;
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lavy Chew\source\repos\IOOP_Assignment\IOOP_Assignment\LpDoctorDataBase.mdf;Integrated Security = True;";
        

        private void frmServRequest_Load(object sender, EventArgs e)
        {
            lblRcn.Text = Name;
            Receptionist1 obj1 = new Receptionist1();
            obj1.loadCustomerTable(dataGridViewCustomer);
            obj1.loadServReqTable(dataGridViewServ);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.ClearSelection();
            dataGridViewServ.ClearSelection();
            txtSearch.Clear();
            txtLaptop.Clear();
            radBtnNormal.Checked = false;
            radBtnUrgent.Checked = false;
        }

        private void linklblNewCusReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegNewCus fRegCus = new frmRegNewCus();
            fRegCus.Show();
            this.Hide();
        }

        private void linklblAccSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccSet faccSet = new frmAccSet();
            faccSet.Show();
            this.Hide();
        }

        private void linklblPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPayment fpayment = new frmPayment();
            fpayment.Show();
            this.Hide();
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin flogout = new frmLogin();
            flogout.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCustomer.SelectedRows.Count == 1 && this.dataGridViewServ.SelectedRows.Count == 1)
            {
                if (txtLaptop.Text == "") //validate laptop input not empty
                {
                    MessageBox.Show("Please enter customer's laptop model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DateTime date = DateTime.Parse(dateTimePicker1.Text);
                    if (radBtnNormal.Checked == true)
                    {
                        int servReID = Convert.ToInt32(dataGridViewServ.CurrentRow.Cells[0].Value);
                        string stype = "Normal";
                        string fee = dataGridViewServ.CurrentRow.Cells[2].Value.ToString();
                        Receptionist1 objOrder1 = new Receptionist1();
                        int customerID = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                        MessageBox.Show(objOrder1.AddOrder(customerID, date, servReID, stype, fee, txtLaptop.Text));
                        Users techForServ1 = new Users();
                        techForServ1.assignOrder();
                    }
                    else if (radBtnUrgent.Checked == true)
                    {
                        int servReID = Convert.ToInt32(dataGridViewServ.CurrentRow.Cells[0].Value);
                        string stype = "Urgent";
                        string fee = dataGridViewServ.CurrentRow.Cells[3].Value.ToString();
                        Receptionist1 objOrder2 = new Receptionist1();
                        int customerID = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                        MessageBox.Show(objOrder2.AddOrder(customerID, date, servReID, stype, fee, txtLaptop.Text));
                        Users techForServ2 = new Users();
                        techForServ2.assignOrder();
                    }
                    else
                    {
                        MessageBox.Show("Please select a service type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customaer and a order only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

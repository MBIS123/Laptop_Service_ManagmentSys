using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class frmPayment : Form
    {
        private static string Name;
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(string n)
        {
            InitializeComponent();
            Name = n;  
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lavy Chew\source\repos\IOOP_Assignment\IOOP_Assignment\LpDoctorDataBase.mdf;Integrated Security = True;";
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewPayment.SelectedRows.Count == 1)
            {
                // get information of status column from the row
                string statusChck = this.dataGridViewPayment.CurrentRow.Cells[4].Value.ToString();
                if (statusChck != "Completed")
                {
                    MessageBox.Show("The service is not done yet!", "Invalid payment.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //validation for enter numbers only in textbox
                    int Amount;
                    if (int.TryParse(txtAmtPaid.Text, out Amount))
                    {
                        int chckTotalAmt = Convert.ToInt32(dataGridViewPayment.CurrentRow.Cells[6].Value);
                        float Amt = float.Parse(txtAmtPaid.Text);
                        if (Amt < chckTotalAmt)
                        {
                            MessageBox.Show("The amount paid is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //update Payment Status to Paid
                            Receptionist1 objPay = new Receptionist1();
                            string idrow = dataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
                            //string paymentstat = dataGridViewPayment.CurrentRow.Cells[4].ToString();
                            MessageBox.Show(objPay.updPaymentStatus(idrow));

                            //Calculate the balanced
                            float bal = (float)(Amt - chckTotalAmt);
                            frmReceipt fReceipt = new frmReceipt();
                            fReceipt.Show();

                            //Pass values to receipt for printing
                            fReceipt.lblReqServ.Text = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
                            fReceipt.lblServType.Text = this.dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
                            fReceipt.lblTotal.Text = "RM" + this.dataGridViewPayment.CurrentRow.Cells[6].Value.ToString();
                            fReceipt.lblInvoice.Text = this.dataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
                            fReceipt.lblCustomer.Text = this.dataGridViewPayment.CurrentRow.Cells[1].Value.ToString();
                            fReceipt.lblAmtPaid.Text = "RM" + Amt.ToString();
                            fReceipt.lblBal.Text = "RM" + bal.ToString();
                            fReceipt.lblRcn.Text = Name;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one row only for payment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblName.Text = Name;
            Receptionist1 obj1 = new Receptionist1();
            obj1.loadPaymentTable(dataGridViewPayment);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewPayment.ClearSelection();
            txtAmtPaid.Clear();
        }

        private void linklblNewCusReg1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegNewCus fRegCus = new frmRegNewCus();
            fRegCus.Show();
            this.Hide();
        }

        private void linklblServReq1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmServRequest fservRq = new frmServRequest();
            fservRq.Show();
            this.Hide();
        }

        private void linklblAccSet1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccSet faccSet = new frmAccSet();
            faccSet.Show();
            this.Hide();
        }

        private void linklblLogout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}

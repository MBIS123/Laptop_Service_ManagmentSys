using Assignment;
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
        public static string Name;
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
                                MessageBox.Show("The amount paid is incorrect!", "Please pay the correct amount.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //Calculate the balanced
                                float bal = (float)(Amt - chckTotalAmt);
                                frmReceipt fReceipt = new frmReceipt();
                                this.Hide();
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

                                //update Payment Status to Paid
                                Receptionist1 objPay = new Receptionist1();
                                string idrow = dataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
                                //string paymentstat = dataGridViewPayment.CurrentRow.Cells[4].ToString();
                                MessageBox.Show(objPay.updPaymentStatus(idrow));

                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter numbers only!", "Please enter the correct amount.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
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
    }
}

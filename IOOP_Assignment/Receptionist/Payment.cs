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
            foreach (DataGridViewRow row in dataGridViewPayment.Rows)
            {
                if (this.dataGridViewPayment.SelectedRows.Count == 1)
                {
                    // get information of status column from the row
                    //string chckStatus = dataGridViewPayment.CurrentRow.Cells[4].ToString();
                    if (dataGridViewPayment.CurrentRow.Cells[4].ToString() != "Completed")
                    {
                        MessageBox.Show("The status is not completed!", "Invalid payment.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int chckTotalAmt = Convert.ToInt32(dataGridViewPayment.CurrentRow.Cells[6].Value);
                        float Amt = float.Parse(txtAmtPaid.Text);
                        if (Amt < chckTotalAmt)
                        {
                            MessageBox.Show("The amount paid is incorrect!", "Please pay the correct amount.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            float bal = (float)(Amt - chckTotalAmt);
                            frmReceipt fReceipt = new frmReceipt();
                            this.Hide();
                            fReceipt.Show();

                            fReceipt.lblReqServ.Text = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
                            fReceipt.lblServType.Text = this.dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
                            fReceipt.lblTotal.Text = "RM" + this.dataGridViewPayment.CurrentRow.Cells[6].Value.ToString();
                            fReceipt.lblInvoice.Text = this.dataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
                            fReceipt.lblCustomer.Text = this.dataGridViewPayment.CurrentRow.Cells[1].Value.ToString();
                            fReceipt.lblAmtPaid.Text= "RM" + Amt.ToString();
                            fReceipt.lblBal.Text = "RM" + bal.ToString();
                        }
                    }
                }
            }

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist();
            obj1.loadPaymentTable(dataGridViewPayment);
        }
    }
}

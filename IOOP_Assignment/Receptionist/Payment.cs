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
            frmReceipt fReceipt = new frmReceipt();
            fReceipt.Show();
            this.Hide();
            fReceipt.lblReqServ.Text = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
            fReceipt.lblServType.Text = this.dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
            fReceipt.lblTotal.Text = "RM" + this.dataGridViewPayment.CurrentRow.Cells[6].Value.ToString();
            fReceipt.lblInvoice.Text = this.dataGridViewPayment.CurrentRow.Cells[0].Value.ToString();
            //fReceipt.lblAmtPaid.Text = this.dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();


        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist();
            obj1.loadPaymentTable(dataGridViewPayment);
        }
    }
}

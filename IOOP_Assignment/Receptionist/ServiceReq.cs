using Assignment;
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
        
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCustomer.SelectedRows.Count == 1 && this.dataGridViewServ.SelectedRows.Count == 1)
            {
                if (txtLaptop.Text == "")
                {
                    MessageBox.Show("Please enter customer's laptop model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DateTime date = DateTime.Parse(dateTimePicker1.Text);
                    if (radBtnNormal.Checked==true)
                    {
                        int servReID = Convert.ToInt32(dataGridViewServ.CurrentRow.Cells[0].Value);
                        string stype = "Normal";
                        string fee = dataGridViewServ.CurrentRow.Cells[2].Value.ToString();
                        Order objOrder1 = new Order();
                        int customerID = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                        MessageBox.Show(objOrder1.AddOrder(customerID, date, servReID, stype, fee, txtLaptop.Text));
                    }
                    if (radBtnUrgent.Checked==true)
                    {
                        int servReID = Convert.ToInt32(dataGridViewServ.CurrentRow.Cells[0].Value);
                        string stype = "Urgent";
                        string fee = dataGridViewServ.CurrentRow.Cells[3].Value.ToString();
                        Order objOrder2 = new Order();
                        int customerID = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                        MessageBox.Show(objOrder2.AddOrder(customerID, date, servReID, stype, fee, txtLaptop.Text));
                    }
                }
            }
        }
        private void frmServRequest_Load(object sender, EventArgs e)
        {
            Order obj1 = new Order();
            obj1.loadCustomerTable(dataGridViewCustomer);
            obj1.loadServReqTable(dataGridViewServ);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
        }
    }
}

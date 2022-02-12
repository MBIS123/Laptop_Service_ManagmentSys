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
    //public static string Name;
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
                        Receptionist1 objOrder1 = new Receptionist1();
                        int customerID = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                        MessageBox.Show(objOrder1.AddOrder(customerID, date, servReID, stype, fee, txtLaptop.Text));
                        Users techForServ1 = new Users();
                        techForServ1.assignOrder();
                    }
                    if (radBtnUrgent.Checked==true)
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
                }
            }
        }
        private void frmServRequest_Load(object sender, EventArgs e)
        {
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
    }
}

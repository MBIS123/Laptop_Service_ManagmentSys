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

        }

        private void lblLaptop_Click(object sender, EventArgs e)
        {

        }

        private void frmServRequest_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist();
            obj1.loadCustomerTable(dataGridViewCustomer);
            obj1.loadCustomerTable(dataGridViewServ);
        }
    }
}

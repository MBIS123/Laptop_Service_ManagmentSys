using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class TechnicianDashboard : Form
    {
        public static string name;
        public static int technician_ID;
        public static int order_id;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Source\Repos\IOOP_Assignment\IOOP_Assignment\LpDoctorDataBase.mdf;Integrated Security=True;";
        public TechnicianDashboard()
        {
            InitializeComponent();
        }

        public TechnicianDashboard(string n, int id) //technician_name and technician_id passed
        {
            InitializeComponent();
            name = n;
            technician_ID = id;
        }

        private void TechnicianDashboard_Load(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(name);
            Technician.viewTechProfile(obj1);
            lblName.Text = obj1.TechName; //loading name into label
            obj1.loadOrderTable(dataGrid_AllServ);
        }

        //navigating menu
        private void btnAccess_AllServ_Click(object sender, EventArgs e) //edit button
        {
            EditServiceRequest ed = new EditServiceRequest(technician_ID, order_id);
            ed.StartPosition = FormStartPosition.Manual;
            ed.Location = new Point(500, 250);
            ed.ShowDialog();
        }

        private void btnRefresh_AllServ_Click(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(name);
            obj1.loadOrderTable(dataGrid_AllServ);
        }

        private void btnAccess_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianProfile tp = new TechnicianProfile(name);
            tp.StartPosition = FormStartPosition.Manual;
            tp.Location = new Point(100, 100);
            tp.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        //when form is closed
        /*private void TechnicianDashboard.Closed(object sender, EventArgs e)
        {

        }*/

        //for changes in button color when user hovers over button 
        private void btnAccess_Dashboard_MouseLeave(object sender, EventArgs e)
        {
            btnAccess_Dashboard.BackColor = Color.LightSkyBlue;
        }

        private void btnAccess_Dashboard_MouseEnter(object sender, EventArgs e)
        {
            btnAccess_Dashboard.BackColor = Color.SteelBlue;
        }

        private void btnAccess_Profile_MouseLeave(object sender, EventArgs e)
        {
            btnAccess_Profile.BackColor = Color.LightSkyBlue;
        }

        private void btnAccess_Profile_MouseEnter(object sender, EventArgs e)
        {
            btnAccess_Profile.BackColor = Color.SteelBlue;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.LightSkyBlue;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.SteelBlue;
        }

        private void btnAccess_AllServ_MouseLeave(object sender, EventArgs e)
        {
            btnAccess_AllServ.BackColor = Color.LightSkyBlue;
        }

        private void btnAccess_AllServ_MouseEnter(object sender, EventArgs e)
        {
            btnAccess_AllServ.BackColor = Color.SteelBlue;
        }

        private void btnRefresh_AllServ_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh_AllServ.BackColor = Color.LightSkyBlue;
        }

        private void btnRefresh_AllServ_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh_AllServ.BackColor = Color.SteelBlue;
        }
    }
}

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
    public partial class TechnicianProfile : Form
    {
        public static string name;

        public TechnicianProfile()
        {
            InitializeComponent();
        }

        public TechnicianProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        //loading details into Profile
        private void TechnicianProfile_Load(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(name);
            Technician.viewTechProfile(obj1);
            lblName.Text = obj1.TechName;
            txtName.Text = obj1.TechName;
            txtGender.Text = obj1.TechGender;
            txtDOB.Text = (obj1.TechDOB).ToString("dd/MM/yyyy");
            txtEthnicity.Text = obj1.TechEthnicity;
            txtIC.Text = obj1.TechIC;
            txtContact.Text = obj1.TechContact;
            txtEmail.Text = obj1.TechEmail;
            txtAddress.Text = obj1.TechAddress;
        }

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
            btnAccess_Profile.BackColor= Color.SteelBlue;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.LightSkyBlue;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.SteelBlue;
        }

        private void btnAccess_EditProfile_MouseLeave(object sender, EventArgs e)
        {
            btnAccess_EditProfile.BackColor = Color.LightSkyBlue;
        }

        private void btnAccess_EditProfile_MouseEnter(object sender, EventArgs e)
        {
            btnAccess_EditProfile.BackColor= Color.SteelBlue;
        }

        //navigating menu
        private void btnAccess_EditProfile_Click(object sender, EventArgs e)
        {
            UpdateTechnicianProfile utp = new UpdateTechnicianProfile(name);
            utp.StartPosition = FormStartPosition.Manual;
            utp.Location = new Point(100, 100);
            utp.ShowDialog();
        }

        private void btnAccess_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianDashboard td = new TechnicianDashboard();
            td.StartPosition = FormStartPosition.Manual;
            td.Location = new Point(100, 100);
            td.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void txtIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class TechnicianDashboard : Form
    {
        public TechnicianDashboard()
        {
            InitializeComponent();
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

        private void btnAccess_PendServ_MouseLeave(object sender, EventArgs e)
        {
            btnAccess_AllServ.BackColor = Color.LightSkyBlue;
        }

        private void btnAccess_PendServ_MouseEnter(object sender, EventArgs e)
        {
            btnAccess_AllServ.BackColor = Color.SteelBlue;
        }

        //clicking 'edit'
        private void btnAccess_AllServ_Click(object sender, EventArgs e)
        {
            EditServiceRequest ed = new EditServiceRequest();
            ed.StartPosition = FormStartPosition.Manual;
            ed.Location = new Point(500, 250);
            ed.ShowDialog();
        }

        private void btnAccess_Profile_Click(object sender, EventArgs e)
        {
            UpdateTechnicianProfile utp = new UpdateTechnicianProfile();
            utp.StartPosition = FormStartPosition.Manual;
            utp.Location = new Point(100, 100);
            utp.ShowDialog();
        }

        //still have to code logout
    }
}

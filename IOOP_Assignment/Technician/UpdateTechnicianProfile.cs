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
    public partial class UpdateTechnicianProfile : Form
    {
        public static string name;
        public UpdateTechnicianProfile()
        {
            InitializeComponent();
        }
        public UpdateTechnicianProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        //loading details into fields
        private void UpdateTechnicianProfile_Load(object sender, EventArgs e)
        {
            MessageBox.Show(name); //for testing
            Technician obj1 = new Technician(name);
            Technician.viewTechProfile(obj1);
            txtContact.Text = obj1.TechContact;
            txtEmail.Text = obj1.TechEmail;
            txtAddress.Text = obj1.TechAddress;
        }

        //reset contact details button: details reset to details saved in database
        private void btnResetContactDetails_Click(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(name);
            Technician.viewTechProfile(obj1);
            txtContact.Text = obj1.TechContact;
            txtEmail.Text = obj1.TechEmail;
            txtAddress.Text = obj1.TechAddress;
        }
        
        //save contact details button: update technician table
        private void btnSaveContactDetails_Click(object sender, EventArgs e)
        {
            //validation
            DataValidation objval = new DataValidation();
            if (objval.isPhoneNum(txtContact.Text)) //&& (objval.isEmail(txtEmail.Text)) && (objval.isAddress(txtAddress.Text)) 
            {
                //calling the update method
                Technician obj1 = new Technician(name);
                MessageBox.Show(obj1.updateTechProfileContactDetails(txtContact.Text, txtEmail.Text, txtAddress.Text));
            }
            else
            {
                MessageBox.Show("Invalid!");
            }

            
        }

        //close window button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*TechnicianDashboard td = new TechnicianDashboard();
            td.StartPosition = FormStartPosition.Manual;
            td.Location = new Point(100, 100);
            td.ShowDialog();*/
        }

        //for changes in button color when user hovers over button
        private void btnResetContactDetails_MouseLeave(object sender, EventArgs e)
        {
            btnResetContactDetails.BackColor = Color.LightSkyBlue;
        }

        private void btnResetContactDetails_MouseEnter(object sender, EventArgs e)
        {
            btnResetContactDetails.BackColor = Color.SteelBlue;
        }

        private void btnSaveContactDetails_MouseLeave(object sender, EventArgs e)
        {
            btnSaveContactDetails.BackColor = Color.LightSkyBlue;
        }

        private void btnSaveContactDetails_MouseEnter(object sender, EventArgs e)
        {
            btnSaveContactDetails.BackColor= Color.SteelBlue;
        }

        private void btnResetPW_MouseLeave(object sender, EventArgs e)
        {
            btnResetPW.BackColor = Color.LightSkyBlue;
        }

        private void btnResetPW_MouseEnter(object sender, EventArgs e)
        {
            btnResetPW.BackColor = Color.SteelBlue;
        }

        private void btnSavePW_MouseLeave(object sender, EventArgs e)
        {
            btnSavePW.BackColor = Color.LightSkyBlue;
        }

        private void btnSavePW_MouseEnter(object sender, EventArgs e)
        {
            btnSavePW.BackColor = Color.SteelBlue;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightSkyBlue;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor= Color.SteelBlue;
        }
    }
}

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
            //MessageBox.Show(name); //for testing
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
            if (objval.isPhoneNum(txtContact.Text) && (objval.isEmailAddress(txtEmail)) && (objval.isStringNull(txtAddress) == false)) //all valid
            {
                Technician obj1 = new Technician(name);
                MessageBox.Show(obj1.updateTechProfileContactDetails(txtContact.Text, txtEmail.Text, txtAddress.Text));
            }
            else
            {
                if (objval.isPhoneNum(txtContact.Text) == false)
                {
                    MessageBox.Show("Invalid Contact Number!");
                }
                if (objval.isEmailAddress(txtEmail) == false) //emailaddress not valid
                {
                    MessageBox.Show("Invalid Email!");
                }
                if (objval.isStringNull(txtAddress)) //address not valid
                {
                    MessageBox.Show("Invalid Address!");
                }
            }
        }

        //reset password button: textboxes cleared
        private void btnResetPW_Click(object sender, EventArgs e)
        {
            txtCurrentPW.Text = String.Empty;
            txtNewPW.Text = String.Empty;
            txtConfirmNewPW.Text = String.Empty;
        }
        
        //save password button: update users table
        private void btnSavePW_Click(object sender, EventArgs e)
        {
            //validation part 1: check if password matches original password
            Technician obj1 = new Technician(name);
            Technician.viewTechProfile(obj1);
            if (txtCurrentPW.Text == obj1.TechPassword)
            {
                DataValidation objpassval = new DataValidation();
                if (objpassval.isPassword(txtNewPW.Text)) //if newpw is valid
                {
                    if (txtNewPW.Text == txtConfirmNewPW.Text) //if newpw and confirm are the same
                    {
                        MessageBox.Show(obj1.updateTechProfilePassword(txtNewPW.Text)); //update users table
                    }
                    else //if newpw and confirm are not the same
                    {
                        MessageBox.Show("Your new passwords do not match. Please try again.");
                    }
                }
                else //if newpw is not valid
                {
                    MessageBox.Show("The new password you have entered is not valid. Please try again.");
                    
                }
            }
            else
            {
                MessageBox.Show("The password you have entered does not match your current password. Please try again.");
            }
        }

        //close window button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianProfile tp = new TechnicianProfile(name);
            tp.ShowDialog();
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

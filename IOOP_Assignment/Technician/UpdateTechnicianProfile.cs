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
        public UpdateTechnicianProfile()
        {
            InitializeComponent();
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

        //reset contact details button
        private void btnResetContactDetails_Click(object sender, EventArgs e)
        {

        }
    }
}

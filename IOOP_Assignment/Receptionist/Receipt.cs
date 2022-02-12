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

    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime=DateTime.Now;
            this.lblDateTime.Text = dateTime.ToString();

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}

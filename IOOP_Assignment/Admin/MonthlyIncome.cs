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
    public partial class MonthlyIncome : Form
    {
        public MonthlyIncome()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj =  new Registration();
            obj.ShowDialog();
        }
    }
}

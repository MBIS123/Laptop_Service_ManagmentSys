using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IOOPAssignment
{
    public partial class change_service : Form
    {
        string Type;
        int index;

        public change_service()
        {
            InitializeComponent();
        }

        private void rdb_normal_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Normal";
        }

        private void rdb_urgent_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Urgent";
        }

        private void lstservices_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstservices.SelectedIndex; 
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string decide_change_service = lstservices.Text;
        
            if (lstservices.SelectedItems.Count == 1 && (rdb_normal.Checked || rdb_urgent.Checked))
            {
                lbl_decided_change_service.Text = "You have change service from " + decide_change_service + " with " + Type + " successfully";
                Customer obj1 = new Customer(index, Type);
                MessageBox.Show(obj1.changeservice());
            }
            else
                MessageBox.Show("You have not choose service / service type yet");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}

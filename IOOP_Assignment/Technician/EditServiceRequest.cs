using System;
using System.Collections;
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
    public partial class EditServiceRequest : Form
    {
        public static int technician_ID;

        public static DateTime collection_Date;

        public static string collection_Date_string;

        public static int orderid_forselection;

        public static string status;

        public EditServiceRequest()
        {
            InitializeComponent();
        }

        public EditServiceRequest(int t, int oid)
        {
            InitializeComponent();
            technician_ID = t;
            orderid_forselection = oid;
        }

        //load existing data 
        private void EditServiceRequest_Load(object sender, EventArgs e)
        {
            ArrayList orderid = new ArrayList();
            orderid = Technician.viewOrderID();
            foreach (var item in orderid)
            {
                comboOrderID.Items.Add(item);
            }
        }

        private void comboOrderID_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ArrayList orderid = new ArrayList();
            orderid = Technician.viewOrderID();
            //MessageBox.Show(comboOrderID.SelectedIndex.ToString()); //for testing
            string combo_index_string = comboOrderID.SelectedIndex.ToString();
            int combo_index_int = Int32.Parse(combo_index_string);
            orderid_forselection = (int)orderid[combo_index_int];
            //MessageBox.Show(orderid_forselection.ToString());
            Technician obj1 = new Technician(technician_ID, orderid_forselection);
            Technician.viewOrderTableforEdit(obj1);
            if (obj1.Servicerequest_status == "Changes Required")
            {
                radioChangesRequired.Checked = true;
            }
            richServDescription.Text = obj1.Servdesc;
            //collection_Date = obj1.Collectiondate;
            //MessageBox.Show(collection_Date.ToString()); //for testing
            //CollectionDatePicker.Value = collection_Date.Date;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboOrderID.SelectedIndex = -1;
            richServDescription.Text = String.Empty;
            CollectionDatePicker.Value = DateTime.Today;
            radioChangesRequired.Checked = false;
            radioCompleted.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //take in value of orderid, string of change status, string of serv_desc,
            //and value of collection date
            if (comboOrderID.Items.Count > 0) //check if there are items
            {
                if (comboOrderID.SelectedIndex > 0) //check if there is a selection
                {
                    int flag = 1; //for radiobutton validation

                    ArrayList orderid = new ArrayList();
                    orderid = Technician.viewOrderID();
                    string combo_index_string = comboOrderID.SelectedIndex.ToString();
                    int combo_index_int = Int32.Parse(combo_index_string);
                    orderid_forselection = (int)orderid[combo_index_int];

                    //collection_Date_string = CollectionDatePicker.Value.ToString("dd/MM/yyyy");

                    if (radioChangesRequired.Checked)
                    {
                        status = "Changes Required";
                    }
                    else if (radioCompleted.Checked)
                    {
                        status = "Completed";
                    }
                    else
                    {
                        flag = 0;
                    }

                    if (flag == 1)
                    {
                        Technician obj1 = new Technician();
                        MessageBox.Show(obj1.updateEditServReq(orderid_forselection, status, richServDescription.Text, CollectionDatePicker.Value.Date));
                    }
                    else
                    {
                        MessageBox.Show("You need to select a status.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid. Please select an OrderID.");
                }
            }
            else
                MessageBox.Show("Invalid. There are no service requests to be edited.");

          
        }

        //for ui colour changes
        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.LightSkyBlue;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.SteelBlue;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightSkyBlue;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.SteelBlue;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightSkyBlue;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.SteelBlue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioChangesRequired_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }
        //close window button
    }
}

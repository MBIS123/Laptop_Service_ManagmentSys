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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            //users obj1 = new User(username, password);
            Users obj1 = new Users(txtUsername.Text, txtPwd.Text); //calling constructor on line19 in users.cs
            stat = obj1.login(txtUsername.Text);
            if (stat == "Incorrect username or password entered!")
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = String.Empty;
            txtPwd.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}

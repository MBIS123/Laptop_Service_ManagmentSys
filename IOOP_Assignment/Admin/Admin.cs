using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Admin
    {

        private string position;

        public Admin() { 
        }


    
    
    internal void regisPosition(RadioButton technician ,RadioButton receptionist)
        {
            if (technician.Checked == true)
                position = "technician";
            else if (receptionist.Checked == true)
                position = "receptionist";
            MessageBox.Show(position);
        }
    
    
      /// INSIDE THE ADMIN CLASS I DECLARE A METHOD FIRST
    
    }


}

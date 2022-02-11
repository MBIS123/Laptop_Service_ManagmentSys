using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Admin
    {
        DataValidation objValidt = new DataValidation();
        

        private string position;
        private string name;
        private string gender;
        private int dateOfBirth;
        private string ethnicity;
        private string address;
        private string emailAddress;
        private int noIC;
        private int phoneNumber;
        private bool allInfoFilled = true;  // used for validation purpose


        public Admin() { 
        }

        public string Position { get => position; set => position = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Ethnicity { get => ethnicity; set => ethnicity = value; }
        public string Address { get => address; set => address = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public int NoIC { get => noIC; set => noIC = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public bool AllInfoFilled { get => allInfoFilled; set => allInfoFilled = value; }

        internal void validateRegisPosition(RadioButton technician ,RadioButton receptionist)
        {
            if (technician.Checked == true)
                position = "technician";
            else if (receptionist.Checked == true)
                position = "receptionist";
            else 
                allInfoFilled = false;
               
        }
        internal void validateRegisCheckComboBx(ComboBox gender, ComboBox ethnic )
        {

            if (gender.SelectedIndex == -1 && ethnic.SelectedIndex == -1) // ensure admin select something (validation for gender)
                allInfoFilled = false;
        
            else if (ethnic.SelectedIndex == -1 )
                allInfoFilled = false;
            else if (gender.SelectedIndex == -1)
                allInfoFilled = false;
            else
            {
                this.gender = gender.SelectedItem.ToString();
                ethnicity = ethnic.SelectedItem.ToString();
            }
             
        
        }

        internal void askToReenter()
        { 
            if (!allInfoFilled) //some infor are not filled
            {
                MessageBox.Show("dl ui", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        internal void checking()
        {
            MessageBox.Show(position + " " + ethnicity + " " + gender );
            
        }

        // messagebox.show("message","title" , MessageBoxButton, ... , MessageBoxIcon,Warning)
        /// INSIDE THE ADMIN CLASS I DECLARE A METHOD FIRST

    }


}

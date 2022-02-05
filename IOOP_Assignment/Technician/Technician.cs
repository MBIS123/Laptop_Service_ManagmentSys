using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Technician
    {
        private int technicianID;
        private string technicianName;
        private string technicianGender;
        private DateOnly technicianDOB;
        private string technicianEthnicity;
        private string technicianIC;
        private string technicianContact;
        private string technicianEmail;
        private string technicianAddress;
        private string technicianPassword;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        //static used to use 'con' object multiple times

        //methods for 'auto-filling' fields when viewing technician profile + update profile
        public string TechnicianName { get => technicianName; set => technicianName = value; }
        public string TechnicianGender { get => technicianGender; set => technicianGender = value; }
        public DateOnly TechnicianDOB { get => technicianDOB; set => technicianDOB = value; }
        public string TechnicianEthnicity { get => technicianEthnicity; set => technicianEthnicity = value; }
        public string TechnicianIC { get => technicianIC; set => technicianIC = value; }
        public string TechnicianContact { get => technicianContact; set => technicianContact = value; }
        public string TechnicianEmail { get => technicianEmail; set => technicianEmail = value; }
        public string TechnicianAddress { get => technicianAddress; set => technicianAddress = value; }
        public string TechnicianPassword { get => technicianPassword; set => technicianPassword = value; }


        /*public Technician*/
    }
}

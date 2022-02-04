using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace IOOP_Assignment
{


    public class DataValidation
    {
            
        bool isString(string input)
        {
            if (new Regex(input).IsMatch("^[a-zA-Z]$")) 
                return true;
            else
                return false;
        }

        bool isPhoneNum(string input)
        {
            if (new Regex(input).IsMatch("^(+60)[0-9]{11}$"))
                return true;
            else
                return false ;
        }
    }
}

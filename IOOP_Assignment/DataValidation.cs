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
            
        internal bool isString(string input)
        {
            if (input.All(Char.IsLetter))
            {
                return true;
            }
            else
                return false;
        }

        internal bool isPhoneNum(string input)
        {
            if ( Regex.IsMatch(input, @"^[0-9]{1,11}$"))
                return true;
            else
                return false ;
            
        }

        internal bool isInt(string input)
        {
            int i;
            if (int.TryParse(input, out i))
                return true;
            else
                return false;
        }

        internal bool isIcNum(string input)
        {
            if (Regex.IsMatch(input, @"^[0-9]{3}$"))
                return true;
            else
                return false;

        }


    }
}

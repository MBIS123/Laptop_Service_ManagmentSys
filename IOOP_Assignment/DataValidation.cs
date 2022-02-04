using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace IOOPAssignment
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


    }
}

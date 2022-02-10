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
        private string[] partOfIC = new string[3];

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
            if ( Regex.IsMatch(input, @"^(\+?6?01)[02-9]-*[0-9]{7}$|^(\+?6?01)[1]-*[0-9]{8}$"))
                return true;
            else
                return false ;
            
        }

        internal bool isPassword(string input)
            // 1) It must contain at least a number
            // 2) at least one upper case letter
            // 3) at least one special character
            // 4) min. 8 characters long
        {
            var containsNumber = new Regex(@"[0-9]+");
            var containsUpperCase = new Regex(@"[A-Z]+");
            var contains1SpecialChar = new Regex("^[A-Za-z0-9]+"); //negation of normal characters
            var containsMin8Char = new Regex(@".{8,}"); //. means any character, while , means 8 or more

            var isValidPassword = containsNumber.IsMatch(input) && containsUpperCase.IsMatch(input) && contains1SpecialChar.IsMatch(input) && containsMin8Char.IsMatch(input);
            if (isValidPassword)
            {
                return isValidPassword; //true
            }
            else
            {
                return false;
            }
        }

        internal bool isInt(string input)
        {
            int temp;
            if (int.TryParse(input, out temp))
                return true;
            else
                return false;
        }

        internal bool isIcNum(TextBox input)
        {
            int icNum;

            if (!(input.Text.Contains('-')))
                return false;
            for (int i =0; i <3; i++)
            {
                partOfIC[i] = input.Text.Split('-')[i];
            }
            for (int i = 0; i < 3; i++)
            {
                if(!(int.TryParse(partOfIC[i] , out icNum)))
                {
                    return false;
                }
            }

            if (Regex.IsMatch(partOfIC[0], @"^[0-9]{6}$"))
                return true;
            else
                return false;
            if (Regex.IsMatch(partOfIC[1], @"^[0-9]{2}$"))
                return true;
            else
                return false;
            if (Regex.IsMatch(partOfIC[2], @"^[0-9]{4}$"))
                return true;
            else
                return false;

        }

        internal bool isStringNull(TextBox input) //return true if the text box has null or empty or whispace value
        {
            if(string.IsNullOrWhiteSpace(input.Text))
                return true ;
            else
                return false;
        }

        internal bool isDate(TextBox input)
        {
            DateTime tempDate;
            if (DateTime.TryParse(input.Text, out tempDate))
                return true;
            else
                return false ;

        }

      


    }
}

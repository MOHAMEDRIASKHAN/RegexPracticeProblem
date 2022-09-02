using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPracticeProblem
{
    public class Pattern
    {
        //UC 1 and 2
        //public static string REGEX_PINCODE = "^[A-Z]{5}[' '][A-Z]{4}";
        // UC 3 --EmailId
        //public static string REGEX_PINCODE = "^[a-z]{5}[.][a-z]{4}[@][a-z]{2}[.][a-z]{2}";
        //UC 4 --PhoneNumber
        //public static string REGEX_PINCODE = "^[1-9]{2}[' '][1-9]{10}";
        //UC 5 -- Password
        public static string REGEX_PINCODE = "^[A-Z]{1}[a-z]{5}[@][1-9]{1}";
        
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, REGEX_PINCODE);
        }

    }
}

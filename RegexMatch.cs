using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class RegexMatch
    {
        public static string firstName = "^[A-Z]{1}[A-Za-z]{2,}$";//defined reguler Expression.
        public bool firstRegex(string fname)//will return true or false.
        {
            return Regex.IsMatch(fname, firstName);//predefined Regex class will Validate the pattern.
        }
    }
}

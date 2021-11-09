﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class RegexMatch
    {
        //public static string firstName = "^[A-Z]{1}[A-Za-z]{2,}$";//defined reguler Expression.
        //public static string lastName = "^[A-Z]{1}[A-Za-z]{2,}$";//defined reguler Expression.
        public static string emailId = @"^([a-z]+)(\.[a-z0-9_\+\-]+?@{[a-z]+}\.{[a-z]{2-4}}{\.[a-z]{2}}?&";//defined reguler Expression.
        //public bool firstRegex(string fname)//will return true or false.
        //{
        //return Regex.IsMatch(fname, firstName);//predefined Regex class will Validate the pattern.
        //}
        //public bool lastRegex(string lname)//will return true or false.
        //{
        //return Regex.IsMatch(lname, lastName);//predefined Regex class will Validate the pattern.
        //}
        public bool emailIDRegex(string email)//will return true or false.
        {
            return Regex.IsMatch(email, emailId);//predefined Regex class will Validate the pattern.
        }
    }
}

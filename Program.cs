using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Last Name Starting with Capital Letter and 3 Characters Long");
            int Mobile = Convert.ToInt32(Console.ReadLine());//user will input the Mobile Number.
            RegexMatch regexMatch = new RegexMatch();//object of the Class
            Console.WriteLine(regexMatch.mobileRegex(Convert.ToString(Mobile)));//will print true if the pattern matches.
        }
    }
}

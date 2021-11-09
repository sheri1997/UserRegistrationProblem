using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Password");
            string PassWord = Console.ReadLine();//user will input the Mobile Number.
            RegexMatch regexMatch = new RegexMatch();//object of the Class
            Console.WriteLine(regexMatch.passwordRegex(PassWord));//will print true if the pattern matches.
        }
    }
}

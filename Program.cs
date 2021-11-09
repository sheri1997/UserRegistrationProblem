using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Name Starting with Capital Letter and 3 Characters Long");
            string FirstName = Console.ReadLine();//user will input the First Name.
            RegexMatch regexMatch = new RegexMatch();//object of the Class
            Console.WriteLine(regexMatch.firstRegex(FirstName));//will print true if the pattern matches.
        }
    }
}

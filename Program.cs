using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Last Name Starting with Capital Letter and 3 Characters Long");
            string LastName = Console.ReadLine();//user will input the Last Name.
            RegexMatch regexMatch = new RegexMatch();//object of the Class
            Console.WriteLine(regexMatch.lastRegex(LastName));//will print true if the pattern matches.
        }
    }
}

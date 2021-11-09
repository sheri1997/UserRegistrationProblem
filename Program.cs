using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string PassWord1 = "abc@yahoo.com";
            string PassWord2 = "abc - 100@yahoo.com";
            string PassWord3="abc.100@yahoo.com";
            string PassWord4 = "abc111@abc.com";
            string PassWord5 = "abc-100@abc.net";
            string PassWord6 = "abc@1.com";
            string PassWord7 = "abc@gmail.com.com";
            string PassWord8 = "100@gmail.com";
            RegexMatch regexMatch = new RegexMatch();//object of the Class
            Console.WriteLine(regexMatch.passwordRegex(PassWord1));//will print true if the pattern matches.
            Console.WriteLine(regexMatch.passwordRegex(PassWord2));
            Console.WriteLine(regexMatch.passwordRegex(PassWord3));
            Console.WriteLine(regexMatch.passwordRegex(PassWord4));
            Console.WriteLine(regexMatch.passwordRegex(PassWord5));
            Console.WriteLine(regexMatch.passwordRegex(PassWord6));
            Console.WriteLine(regexMatch.passwordRegex(PassWord7));
            Console.WriteLine(regexMatch.passwordRegex(PassWord8));
        }
    }
}

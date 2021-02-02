using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\b(?<=\s|^)(?<name>[a-zA-Z0-9]([.\-_]?[a-zA-Z0-9])*)?@(?<host>[a-zA-Z][a-zA-Z-.]+)\.[a-zA-Z]+\b");

            MatchCollection matches = pattern.Matches(input);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}

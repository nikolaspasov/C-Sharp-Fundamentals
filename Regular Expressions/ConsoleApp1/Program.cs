using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex newRegex = new Regex(pattern);

            MatchCollection newCollection = newRegex.Matches(input);

            foreach (Match name in newCollection)
            {

                Console.Write($"{ name.Value} ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex passPattern = new Regex
                (@"^(\S+)>(?<numbers>\d{3})\|(?<lower>[a-z]+)\|(?<upper>[A-Z]{3})\|(?<symbols>[^<>]{3})<(\1)$");

            int numberOfPasswords = int.Parse(Console.ReadLine());
            string password = "";

            for (int i = 0; i < numberOfPasswords; i++)
            {
                password = Console.ReadLine();

                Match passMatch = passPattern.Match(password);
                if (!passMatch.Success)
                {
                    Console.WriteLine("Try another password!");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(passMatch.Groups["numbers"].Value);
                    sb.Append(passMatch.Groups["lower"].Value);
                    sb.Append(passMatch.Groups["upper"].Value);
                    sb.Append(passMatch.Groups["symbols"].Value);
                    Console.WriteLine("Password: " + sb);
                }
            }

        }
    }
}

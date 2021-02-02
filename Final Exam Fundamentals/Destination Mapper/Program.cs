using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"([=\/])(?<location>[A-Z][a-zA-Z]{2,})(\1)");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);
            List<string> matchesList = new List<string>();
            int travelPoints = 0;

            foreach (Match destination in matches)
            {
                var destinationName = destination.Groups["location"].Value;
                matchesList.Add(destinationName);
                travelPoints += destinationName.Length;
            }

            Console.WriteLine("Destinations: " + string.Join(", ", matchesList));
            Console.WriteLine("Travel Points: "+travelPoints);
        }
    }
}

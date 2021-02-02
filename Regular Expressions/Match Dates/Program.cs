﻿using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>[\d]{2})(.)(?<month>[A-Z][a-z]{2})(\1)(?<year>[\d]{4})\b";

            Regex newRegex = new Regex(pattern);

            MatchCollection newCollection = newRegex.Matches(input);

            foreach (Match date in newCollection)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

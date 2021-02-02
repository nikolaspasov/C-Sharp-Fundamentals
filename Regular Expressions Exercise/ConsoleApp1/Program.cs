using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string input = "";
            List<string> attackList = new List<string>();
            List<string> destroyList = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                StringBuilder changedString = new StringBuilder();
                int specialCount = 0;
                input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 's' | input[j] == 't' | input[j] == 'a' | input[j] == 'r'
                        | input[j] == 'S' | input[j] == 'T' | input[j] == 'A' | input[j] == 'R')
                    {
                        specialCount++;
                    }
                }

                for (int k = 0; k < input.Length; k++)
                {
                    char changedChar = (char)((int)(input[k]) - specialCount);
                    changedString.Append(changedChar);
                }
                Regex pattern = new Regex(@"^[^@!\-:>]*?@(?<name>[A-Z][a-z]+)[^@!\-:>]*?:[^@!\-:>]*?\d+[^@!\-:>]*?!(A|D)![^@!\-:>]*?->\d+[^@!\-:>]*?$");

                Match newMatch = pattern.Match(changedString.ToString());
                var name = newMatch.Groups["name"].Value;
                var action = newMatch.Groups[1].Value.ToString();
                if (newMatch.Success)
                {
                    if (action == "A")
                    {
                        attackList.Add(name);
                    }
                    else
                    {
                        destroyList.Add(name);
                    }
                }
            }
            attackList = attackList.OrderBy(x => x).ToList();
            destroyList = destroyList.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attackList.Count}");
            foreach (var name in attackList)
            {
                Console.WriteLine("-> " + name);
            }
            Console.WriteLine($"Destroyed planets: {destroyList.Count}");
            foreach (var name in destroyList)
            {
                Console.WriteLine("-> " + name);
            }
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            input = input.OrderBy(x => x).ToArray();
            Regex healthRegex = new Regex(@"[^0-9+\-*\/\.]+?");
            Regex damageRegex = new Regex(@"-?\+?\d+\.?\d*");
            Regex operationRegex = new Regex(@"(?<action>[*\/])");

            for (int i = 0; i < input.Length; i++)
            {
                string currentName = input[i];
                MatchCollection healthMatch = healthRegex.Matches(currentName);
                int currHealth = 0;
                foreach (Match healthSymbol in healthMatch)
                {
                    char symbol = char.Parse(healthSymbol.ToString());
                    currHealth += (int)symbol;
                }

                MatchCollection damageMatch = damageRegex.Matches(currentName);
                double currDamage = 0;
                foreach (var damageSymbol in damageMatch)
                {
                    currDamage += double.Parse(damageSymbol.ToString());
                }

                MatchCollection operationMatch = operationRegex.Matches(currentName);
                foreach (var currOperator in operationMatch)
                {
                    if(currOperator.ToString()=="*")
                    {
                        currDamage = currDamage * 2;
                    } 
                    if(currOperator.ToString()=="/")
                    {
                        currDamage = currDamage / 2;
                    }
                }
                Console.WriteLine($"{input[i]} - {currHealth} health, {currDamage:f2} damage");
               

            }
        }

    }

}


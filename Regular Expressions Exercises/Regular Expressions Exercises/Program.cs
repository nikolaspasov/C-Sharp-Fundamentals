using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex newPattern = new Regex(@">>(?<name>[\w]+)<<(?<price>[\d]+[.]?[\d]+)!(?<quantity>[\d]+)");

            MatchCollection newCollection = newPattern.Matches(input);

            decimal totalSum = 0m;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                newCollection = newPattern.Matches(input);
                foreach (Match item in newCollection)
                {
                    var price = item.Groups["price"].Value;
                    var quantity = item.Groups["quantity"].Value;
                    totalSum += decimal.Parse(price) * int.Parse(quantity);
                    Console.WriteLine(item.Groups["name"].Value);
                }
                input = Console.ReadLine();
                
            }
            
            Console.WriteLine($"Total money spend: {totalSum:f2}");
            
        }

    }
}

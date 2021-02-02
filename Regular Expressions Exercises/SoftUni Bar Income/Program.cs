using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            Regex newRegex = new Regex
                (@"^\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$");

            
            double totalIncome = 0;
            while (input!="end of shift")
            {
                Match newCollection = newRegex.Match(input);

                if (newCollection.Success)
                {
                    string name = newCollection.Groups["name"].Value;
                    string productName = newCollection.Groups["product"].Value;
                    int quantity = int.Parse(newCollection.Groups["quantity"].Value);
                    double price = double.Parse(newCollection.Groups["price"].Value);
                    double totalPricePerProduct = quantity * price;
                totalIncome+= totalPricePerProduct;
                    Console.WriteLine($"{name}: {productName} - {totalPricePerProduct:f2}");
                }

              
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}

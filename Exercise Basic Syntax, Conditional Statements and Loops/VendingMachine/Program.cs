using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coins = 0;
            double sum = 0;

            while (input != "Start")
            {
                coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else { Console.WriteLine($"Cannot accept {coins}"); }
                input = Console.ReadLine();

            }

            string product = Console.ReadLine();

            double price = 0;
            string productName = "";
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts": price = 2.0; productName = "nuts"; break;
                    case "Water": price = 0.7; productName = "water"; break;
                    case "Crisps": price = 1.5; productName = "crisps"; break;
                    case "Soda": price = 0.8; productName = "soda"; break;
                    case "Coke": price = 1.0; productName = "coke"; break;
                    default: Console.WriteLine("Invalid product"); break; ; ;
                }
                if (sum - price >= 0.0 && productName!="")
                {
                    Console.WriteLine($"Purchased {productName}");
                    sum -= price;
                }
                else if (sum - price < 0.0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
                
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

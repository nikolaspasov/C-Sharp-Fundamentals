using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Regex pattern = new Regex(@"@#+([A-Z][a-zA-Z0-9]{4,}[A-Z])@#+");


            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                Match newMatch = pattern.Match(input);
                if (!newMatch.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    StringBuilder productGroup = new StringBuilder();
                    for (int j = 0; j < input.Length; j++)
                    {
                        if(char.IsDigit(input[j]))
                        {
                            productGroup.Append(input[j]);
                        }
                    }
                    if (productGroup.ToString() == string.Empty)
                    {
                        Console.WriteLine("Product group: " + "00");
                    }
                    else
                    {
                        Console.WriteLine("Product group: " + productGroup);
                    }
                }
            }
        }
    }
}

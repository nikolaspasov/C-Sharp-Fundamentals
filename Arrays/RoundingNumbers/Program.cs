using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();
            double[] numbers = arr.Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double result = numbers[i];
                
                
                {
                    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(result, MidpointRounding.AwayFromZero)}");
                }

            }

        }
    }
}

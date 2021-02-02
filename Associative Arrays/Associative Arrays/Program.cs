using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> numberDictionary = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numberDictionary.ContainsKey(numbers[i]))
                {
                    numberDictionary[numbers[i]]++;
                }
                else
                {
                    numberDictionary.Add(numbers[i], 1);
                }
            }
            foreach (var number in numberDictionary)
            {
                Console.WriteLine(number.Key + " -> "+ number.Value);
            }

        }
    }
}

using System;
using System.Diagnostics.Tracing;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 1; counter < n; i=i+2)
            {
                Console.WriteLine(i);
                sum += i;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

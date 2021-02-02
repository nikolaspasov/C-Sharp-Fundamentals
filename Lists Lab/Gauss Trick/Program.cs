using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            
            for (int i = 0; i < numbers.Count/2; i++)
            {
                numbers[0+i] = numbers[0+i] + numbers[Math.Abs(numbers.Count-1 - i)];
                
               
            }
            int listMiddle = (numbers.Count / 2);
            if (numbers.Count % 2 == 0)
            {
                for (int i = numbers.Count - 1; i >= listMiddle; i--)
                {
                    numbers.RemoveAt(i);
                }
            }
            else
            {
                for (int i = numbers.Count - 1; i >listMiddle; i--)
                {
                    numbers.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

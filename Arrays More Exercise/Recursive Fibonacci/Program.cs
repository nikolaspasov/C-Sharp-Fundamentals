using System;
using System.Collections.Generic;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int> {1,1};
            int currNum = 0;
            int count = 0;
            while (count<n-2)
            {
                currNum = numbers[count] + numbers[1 + count];
                numbers.Add(currNum);
                count++;
                if(count==n-2)
                {
                    Console.WriteLine(numbers[numbers.Count-1]);
                }
            }
            
        }
    }
}

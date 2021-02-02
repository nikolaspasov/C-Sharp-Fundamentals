using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] initialArray = new int[] {1};
            
            for (int i = 1; i <= n; i++)
            {
                int[] currentArray = new int[i];
                currentArray[0] = 1;
                currentArray[currentArray.Length - 1] = 1;

                for (int j = 1; j < i-1; j++)
                {
                    currentArray[0] = 1;
                    currentArray[j] = initialArray[j - 1] + initialArray[j];
                    
                }
                Console.WriteLine(string.Join(" ", currentArray));

                initialArray = currentArray;
                
            }



        }
    }
}

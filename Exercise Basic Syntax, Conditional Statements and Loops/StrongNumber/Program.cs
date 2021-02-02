using System;
using System.Diagnostics.CodeAnalysis;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); ;
            int num = int.Parse(input);
            int startNum = int.Parse(input);
            int currentNum = 0;
            int sum = 1;
            int finalSum = 0;

            for (int i = 0 ; i <= input.Length-1; i++)
            {
                currentNum = num % 10;
                num = num / 10;
                for (int j = currentNum; j > 0; j--)
                {
                    sum *= j;
                }
                finalSum += sum;
                sum = 1;
                
            }
            if(startNum==finalSum)
            {
                Console.WriteLine("yes");
            }
            else if(startNum!=finalSum)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}

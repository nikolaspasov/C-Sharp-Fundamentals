using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetSumOfEven(number);
            int oddSum = GetSumOfOdd(number);
            Console.WriteLine(evenSum * oddSum);
        }
        static int GetSumOfEven(int input)
        {
            int number =Math.Abs(input);
            int currNum = 0;
            int evenSum = 0; ;
            while (number > 0)
            {
                currNum = (number % 10);
                number = number / 10;
                if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
            }

            return evenSum;
        }
        static int GetSumOfOdd(int input)
        {
            int number =Math.Abs(input);
            int oddSum = 0;
            int currNum = 0;
            while (number > 0)
            {
                currNum = (number % 10);
                number = number / 10;
                if (currNum % 2 != 0)
                {
                    oddSum += currNum;
                }

            }
            return oddSum;
        }
    }
}

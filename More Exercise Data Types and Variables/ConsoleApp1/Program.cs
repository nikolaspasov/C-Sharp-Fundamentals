using System;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            string firstInput = "";
            string secondInput = "";
            decimal firstNum = 0m;
            decimal secondNum = 0m;
            decimal sumFirst = 0m;
            decimal sumSecond = 0m;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                firstInput = input.Split(" ")[0];
                secondInput = input.Split(" ")[1];
                firstNum = decimal.Parse(firstInput);
                secondNum = decimal.Parse(secondInput);
                if (firstNum > secondNum)
                {
                    for (int j = 0; j < firstInput.Length; j++)
                    {
                        sumFirst += (firstNum % 10);
                        firstNum = (firstNum *0.100m);
                    }
                    Console.WriteLine(sumFirst);
                }
                else if (firstNum <= secondNum)
                {
                    for (int j = 0; j < secondInput.Length; j++)
                    {
                        sumSecond += (secondNum % 10);
                        secondNum = (secondNum * 0.100m);
                    }
                    Console.WriteLine(sumSecond);
                }
                firstNum = 0m;
                secondNum = 0m;
                sumFirst = 0m;
                sumSecond = 0m;

            }
        }
    }
}

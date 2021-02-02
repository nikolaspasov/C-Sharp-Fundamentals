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
            BigInteger firstNum = (BigInteger)0;
            BigInteger secondNum = (BigInteger)0;
            BigInteger sumFirst = (BigInteger)0;
            BigInteger sumSecond = (BigInteger)0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                firstInput = input.Split(" ")[0];
                secondInput = input.Split(" ")[1];
                firstNum = long.Parse(firstInput);
                secondNum =long.Parse(secondInput);
                if(firstNum>secondNum)
                {
                    for (int j = 0; j < firstInput.Length; j++)
                    {
                        sumFirst += firstNum % 10;
                        firstNum = firstNum / 10;
                    }
                    Console.WriteLine(BigInteger.Abs(sumFirst));
                }
                else if(firstNum<=secondNum)
                {
                    for (int j = 0; j < secondInput.Length; j++)
                    {
                        sumSecond += (secondNum % 10);
                        secondNum = secondNum / 10;
                    }
                    Console.WriteLine(BigInteger.Abs(sumSecond));
                }
               firstNum = (BigInteger)0;
                 secondNum = (BigInteger)0;
               sumFirst = (BigInteger)0;
                 sumSecond = (BigInteger)0;

            }
        }
    }
}

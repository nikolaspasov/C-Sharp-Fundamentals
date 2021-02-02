using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
            double firstFactorial = GetFirstFactorial(numA);
            double secondFactorial = GetSecondFactorial(numB);
            Console.WriteLine($"{firstFactorial/secondFactorial:f2}");

        }
        static double GetFirstFactorial(double numA)
        {
            double firstFact = 1;

            while (numA > 0)
            {
                firstFact *=numA;
                numA -= 1;
            }
            return firstFact;
        }
        static double GetSecondFactorial(double numB)
        {
            double secondFact = 1;
            while (numB > 0)
            {

                secondFact *= numB ;
                numB -= 1;

            }
            return secondFact;
        }
        
    }
}

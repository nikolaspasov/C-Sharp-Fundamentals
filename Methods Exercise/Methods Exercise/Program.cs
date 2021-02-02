using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());
            PrintSmallest(numberA, numberB, numberC);
        }
        static void PrintSmallest(int numberA, int numberB, int numberC)
        {
            Console.WriteLine(Math.Min(numberA, Math.Min(numberB, numberC)));
        }
    }
}

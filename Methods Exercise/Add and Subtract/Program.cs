using System;
using System.Net.Http.Headers;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());
            int firstSum = GetSum(numberA, numberB);
            int subtract = GetSubract(firstSum, numberC);
            Console.WriteLine(subtract);
        }
        static int GetSum(int numberA, int numberB)
        {
           int sum = numberA + numberB;
            return sum;
        }
        static int GetSubract(int sum, int numberC)
        {
            int subtract = sum - numberC;
            return subtract;
        }
    }
}

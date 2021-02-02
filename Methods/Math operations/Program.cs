
using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double numberB = double.Parse(Console.ReadLine());
            double output = ReturnResult(numberA, command, numberB);
            Console.WriteLine(output);
        }
        static double ReturnResult(double numberA, string command, double numberB)
        {
            double result = 0;
            switch (command)
            {
                case "/": result = numberA / numberB; break;
                case "*": result = numberA * numberB; break;
                case "+": result = numberA + numberB; break;
                case "-": result = numberA - numberB; break;

            }
            return result;
        }
    }
}

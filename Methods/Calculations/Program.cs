using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if(command =="add")
            {
                PrintAdd(num1, num2);
            }
            else if(command=="multiply")
            {
                PrintMultiply(num1, num2);
            }
            else if (command == "subtract")
            {
                PrintSubtract(num1, num2);
            }
            else if (command == "divide")
            {
                PrintDivide(num1, num2);
            }
        }
        static void PrintAdd(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void PrintMultiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void PrintSubtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void PrintDivide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}

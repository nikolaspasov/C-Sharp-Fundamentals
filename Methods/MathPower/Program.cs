using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = PrintResult(num,power);
            Console.WriteLine(result);

        }
        static double PrintResult(double num, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result =result*num;
            }
            return result;
        }
    }
}

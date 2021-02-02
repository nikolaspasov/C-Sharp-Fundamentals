using System;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal km = meters / 1000.00M;
            Console.WriteLine($"{km:f2}");

        }
    }
}

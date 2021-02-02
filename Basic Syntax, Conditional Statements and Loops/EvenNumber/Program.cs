using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(true)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else { Console.WriteLine("Please write an even number."); }
            }
        }
    }
}

using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double difference = 0;

            if(first>second)
            {
                difference = first - second;
                if(difference<=0.000001)
                {
                    Console.WriteLine("True");
                }
                else { Console.WriteLine("False"); }
            }
            else if(second>first)
            {
                difference = second - first;
                if(difference<= 0.000001)
                {
                    Console.WriteLine("True");
                }
                else { Console.WriteLine("False"); }
            }
        }
    }
}

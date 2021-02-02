using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalVolume = 255;
            int liters = 0;
            int totalLiters = 0;

            for (int i = 0; i < n; i++)
            {


                liters = int.Parse(Console.ReadLine());
                if (liters + totalLiters > totalVolume)
                {
                    Console.WriteLine("Insufficient capacity!");
                   
                }
                else
                {
                    totalLiters += liters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}

using System;
using System.Globalization;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double snowballSnow = 0;
            double snowballTime = 0;
            double snowballQuality = 0;
            BigInteger snowballValue = 1;
            BigInteger topValue = 0;
            double topSnow = 0;
            double topTime = 0;
            double topQuality = 0;

            for (int i = 0; i < n; i++)
            {
                snowballSnow = double.Parse(Console.ReadLine());
                snowballTime = double.Parse(Console.ReadLine());
               
                snowballQuality = double.Parse(Console.ReadLine());

                snowballValue = Math.Pow(snowballSnow / snowballTime, snowballQuality);
                    if(snowballValue>topValue)
                {
                    topValue = snowballValue;
                    topSnow = snowballSnow;
                    topTime = snowballTime;
                    topQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{Math.Round(topSnow)} : {Math.Round(topTime)} = {Math.Round(topValue)} ({Math.Round(topQuality)})");

        }
    }
}

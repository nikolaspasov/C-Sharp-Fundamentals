using System;
using System.Reflection;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = "";
            double radius = 0;
            double height = 0;
            string biggestModel = "";
            double volume = 0;
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                volume = 3.14159265359 * radius * radius * height;
                if(volume>biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = model;
                }


            }
            Console.WriteLine(biggestModel);
        }
    }
}

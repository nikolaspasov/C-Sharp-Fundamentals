using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());
            PrintArea(width, height);
            Console.WriteLine(PrintArea(width,height));
        }
        static double PrintArea(double width, double height)
        {
            return(width*height);
        }
    }
}

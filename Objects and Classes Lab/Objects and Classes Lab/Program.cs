using System;
using System.Globalization;

namespace Objects_and_Classes_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var time = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(time.DayOfWeek);
        }
    }
}

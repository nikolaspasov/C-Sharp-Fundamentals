using System;

namespace CenturiestoMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = 0;
            decimal days = 0;
            decimal hours = 0;
            decimal minutes = 0;

            years = Math.Floor(centuries * 100M);
            days = Math.Floor(years * 365.2422M);
            hours = Math.Floor(days * 24M);
            minutes = Math.Floor(hours * 60M);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            
        }
    }
}

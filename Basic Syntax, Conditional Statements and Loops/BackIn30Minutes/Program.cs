using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int finalMinutes = minutes + 30;
            if(finalMinutes>59)
            {
                hours++;
                finalMinutes = finalMinutes - 60;
            }
            if(hours>23)
            {
                hours = hours - 24;
            }
            if(finalMinutes<9)
            {
                Console.WriteLine($"{hours}:0{finalMinutes}");
                return;
            }
            Console.WriteLine($"{hours}:{finalMinutes}");
        }
    }
}

using System;
using System.Net.WebSockets;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int extracted = 0;
            int days = 0;
            while (yield >= 100)
            {
                days++;
                extracted += yield;
                yield = yield - 10;
                if(extracted>26)
                { extracted -= 26; }

            }
            if (extracted > 26)
            { extracted -= 26; }
            Console.WriteLine(days);
            Console.WriteLine(extracted);
        }
    }
}

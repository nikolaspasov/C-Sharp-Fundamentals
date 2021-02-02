
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine());
            int stepsTime = int.Parse(Console.ReadLine());

            string hoursString = input.Split(":")[0];
            string minutesString = input.Split(":")[1];
            string secondsString = input.Split(":")[2];

            int hours = Int32.Parse(hoursString);
            int minutes = Int32.Parse(minutesString);
            int seconds = Int32.Parse(secondsString);

            int timeToHome = steps * stepsTime;
            if (timeToHome + seconds > 59)
            {
                for (int i = timeToHome; i > 59; i -= 60)
                {
                    minutes++;
                    timeToHome -= 60;
                }
                seconds += timeToHome;
                if (seconds > 59)
                {
                    for (int i = seconds; i > 59; i -= 60)
                    {
                        minutes++;
                        seconds -= 60;
                    }
                }
                if (minutes > 59)
                {
                    for (int i = minutes; i > 59; i -= 60)
                    {
                        hours++;
                        minutes -= 60;
                    }

                }
                hoursString = hours.ToString();
                minutesString = minutes.ToString();
                secondsString = seconds.ToString();
                if (hours > 23)
                {
                    hours = hours - 24;

                }
                if (hours < 10)
                {
                    hoursString = $"0{hours}";
                }
                if (minutes < 10)
                {
                    minutesString = $"0{minutes}";
                }
                if (seconds < 10)
                {
                    secondsString = $"0{seconds}";
                }
                Console.WriteLine($"{hoursString}:{minutesString}:{secondsString}");

            }

        }
    }
}

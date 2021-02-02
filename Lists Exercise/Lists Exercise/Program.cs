using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine(); 
            while (command != "end")
            {
                
                if (command.Contains("Add"))
                {
                    int wagonSize = int.Parse(command.Split()[1]);
                    wagons.Add(wagonSize);
                }
                else
                {
                    int passengers = int.Parse(command);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            passengers = 0;

                            break;
                        }
                        if (passengers <= 0)
                        {
                            break;
                        }

                    }

                }
                command = Console.ReadLine();




            }
            Console.WriteLine(string.Join(' ', wagons));
        }


    }
}

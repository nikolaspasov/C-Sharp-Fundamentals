using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command ="" ;
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();

                if (command.Contains("not") == false)
                {
                    if (guests.Contains(command.Split()[0]))
                    {
                        Console.WriteLine($"{command.Split()[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command.Split()[0]);
                    }
                }
                else if (command.Contains("not"))
                {
                    if(guests.Contains(command.Split()[0])==false)
                    {
                        Console.WriteLine($"{command.Split()[0]} is not in the list!");
                        
                    }
                    guests.Remove(command.Split()[0]);
                }
                

            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
                
            }
        }
    }
}

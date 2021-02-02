using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = "";
            string username = "";
            string licensePlate = "";
            Dictionary<string, string> userDict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                if (command.Contains("unregister"))
                {
                    username = command.Split()[1];
                    if (!userDict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    userDict.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
                else if(command.Contains("register"))
                {
                    username = command.Split()[1];
                    licensePlate = command.Split()[2];
                    if(userDict.ContainsKey(username))
                    {
                        Console.WriteLine
                            ($"ERROR: already registered with plate number {licensePlate}");
                        continue;
                    }

                    userDict.Add(username, licensePlate);
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
               
            }
            foreach (var user in userDict)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}

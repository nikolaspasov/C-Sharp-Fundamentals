using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;
            Dictionary<string, int> resourceDict = new Dictionary<string, int>();
            string currResourse = "";
            while (input != "stop")
            {
               
                
                if(counter%2!=0)
                {
                    if (resourceDict.ContainsKey(input))
                    {
                        currResourse = input;

                    }
                    else
                    {
                        resourceDict.Add(input, 0);
                        currResourse = input;
                    }
                }
                else
                {
                    if (resourceDict.ContainsKey(currResourse))
                    {
                        resourceDict[currResourse] += int.Parse(input);
                    }
                    else
                    {

                        resourceDict[currResourse] = int.Parse(input);
                    }
                }
                counter++;
                input = Console.ReadLine();
            }
            foreach (var resource in resourceDict)
            {
                Console.WriteLine(resource.Key +" -> "+resource.Value);
            }
        }
    }
}

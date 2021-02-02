using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            string command = Console.ReadLine();
            while(command!="End")
            {
                if(command.Contains("Add"))
                {
                    
                    double numberToAdd = double.Parse(command.Split()[1]);
                    numbers.Add(numberToAdd);

                }
                else if(command.Contains("Insert"))
                {
                    
                    double numberToInsert = double.Parse(command.Split()[1]);
                    int indexToInsert = int.Parse(command.Split()[2]);
                    if (indexToInsert >= numbers.Count || indexToInsert < 0)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                }
                else if (command.Contains("Remove"))
                {
                    int indexToRemove = int.Parse(command.Split()[1]);
                    if (indexToRemove >= numbers.Count || indexToRemove < 0)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                }
                else if (command.Contains("left"))
                {
                    int leftCount = int.Parse(command.Split()[2]);

                    for (int i = 0; i < leftCount; i++)
                    {
                        double current = numbers[0];
                        numbers.Remove(numbers[0]);
                        numbers.Add(current);

                    }
                }
                else if (command.Contains("right"))
                {
                    int rightCount = int.Parse(command.Split()[2]);
                    for (int i = 0; i < rightCount; i++)
                    {
                        double current = numbers[numbers.Count - 1];
                        
                        numbers.Insert(0, current);
                        numbers.RemoveAt(numbers.Count - 1);

                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                
                if (command.Contains("Add"))
                {
                    AddNumber(numbers, command);
                }
                else if (command.Contains("RemoveAt"))
                {
                    RemoveIndex(numbers, command);
                }
                else if (command.Contains("Remove"))
                {
                    RemoveNumber(numbers, command);
                }
                
                else if (command.Contains("Insert"))
                {
                    InsertNumber(numbers, command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void AddNumber(List<double> numbers, string command)
        {
            int numberToAdd = int.Parse(command.Split()[1]);
            numbers.Add(numberToAdd);

        }
        static void RemoveNumber(List<double> numbers, string command)
        {
            int numberToRemove = int.Parse(command.Split()[1]);
            numbers.Remove(numberToRemove);
        }
        static void RemoveIndex(List<double> numbers, string command)
        {
            int indexToRemove = int.Parse(command.Split()[1]);
            numbers.RemoveAt(indexToRemove);
        }
        static void InsertNumber(List<double> numbers, string command)
        {
            int numberToInsert = int.Parse(command.Split()[1]);
            int index = int.Parse(command.Split()[2]);
            numbers.Insert(index,numberToInsert);
            
            
        }

    }
}

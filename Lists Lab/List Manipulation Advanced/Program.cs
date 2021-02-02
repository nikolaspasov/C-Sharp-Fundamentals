using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            string command = Console.ReadLine();
            int changeCount = 0;

            while (command != "end")
            {
                if (command.Contains("Contains"))
                {
                    ListContains(numbers, command);
                }
                else if (command.Contains("PrintEven"))
                {
                    PrintEven(numbers, command);
                }
                else if (command.Contains("PrintOdd"))
                {
                    PrintOdd(numbers, command);
                }
                else if (command.Contains("GetSum"))
                {
                    PrintSum(numbers, command);
                }
                else if (command.Contains("Filter"))
                {
                    GetFiltered(numbers, command);
                }
                else if (command.Contains("Add"))
                {
                    AddNumber(numbers, command);
                    changeCount++;
                }
                else if (command.Contains("RemoveAt"))
                {
                    RemoveIndex(numbers, command);
                    changeCount++;
                }
                else if (command.Contains("Remove"))
                {
                    RemoveNumber(numbers, command);
                    changeCount++;
                }

                else if (command.Contains("Insert"))
                {
                    InsertNumber(numbers, command);
                    changeCount++;
                }
               
                command = Console.ReadLine();
            }
            if (changeCount > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static void ListContains(List<double> numbers, string command)
        {
            int numberCommand = int.Parse(command.Split()[1]);

            if (numbers.Contains(numberCommand))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<double> numbers, string command)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");

                }
            }
            Console.WriteLine("");
        }
        static void PrintOdd(List<double> numbers, string command)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine("");
        }
        static void PrintSum(List<double> numbers, string command)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void GetFiltered(List<double> numbers, string command)
        {
            string condition = command.Split()[1];
            int numberCondition = int.Parse(command.Split()[2]);
            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < numberCondition)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine("");
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > numberCondition)
                    {
                        Console.Write(numbers[i] + " ");
                    }

                }
                Console.WriteLine("");
            }

            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= numberCondition)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine("");
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= numberCondition)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine("");
            }
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
            numbers.Insert(index, numberToInsert);


        }



    }
}


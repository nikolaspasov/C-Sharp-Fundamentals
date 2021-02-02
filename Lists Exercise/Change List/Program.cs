using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while(command!="end")
            {
                if(command.Contains("Delete"))
                {
                    DeleteNumber(numbers, command);

                }
                else
                {
                    InsertNumber(numbers, command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers ));
        }
        static void DeleteNumber(List<int> number, string command)
        {
           int numberToDelete = int.Parse(command.Split()[1]);
            while (number.Contains(numberToDelete))
            {
                number.Remove(numberToDelete);
            }
        }
        static void InsertNumber(List<int> number,string command)
        {
            int numberToInsert = int.Parse(command.Split()[1]);
            int indexToInsert = int.Parse(command.Split()[2]);
            number.Insert( indexToInsert, numberToInsert);
        }
    }
}

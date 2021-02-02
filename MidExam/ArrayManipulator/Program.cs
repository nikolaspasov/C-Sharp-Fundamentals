using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while(command!="end")
            {
                if(command.Contains("swap"))
                {
                    int firstIndex= int.Parse(command.Split()[1]);
                    int secondIndex= int.Parse(command.Split()[2]);

                    int firstNum = array[firstIndex];
                    int secondNum = array[secondIndex];
                    array[firstIndex] = secondNum;
                    array[secondIndex] = firstNum;

                }
                else if(command.Contains("multiply"))
                {
                    int firstIndex = int.Parse(command.Split()[1]);
                    int secondIndex = int.Parse(command.Split()[2]);

                    int firstNum = array[firstIndex];
                    int secondNum = array[secondIndex];

                    array[firstIndex] = firstNum * secondNum;
                    
                }
                else if(command.Contains("decrease"))
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i]--;
                    }
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(i!=array.Length-1)
                Console.Write(array[i]+", ");
                else 
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();
            int[] numbers = arr.Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];

            int count = 0;



            if (numbers.Length <= 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            while (numbers.Length - 1 > count)
            {

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = condensed[i];

                }
                count++;
            }

            Console.WriteLine(condensed[0]);



        }
    }
}

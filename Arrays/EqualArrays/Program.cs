using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] arr1 = input1.Split();
            string[] arr2 = input2.Split();

            int[] num1 = arr1.Select(int.Parse).ToArray();
            int[] num2 = arr2.Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                if(num1[i]!=num2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                sum += num1[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

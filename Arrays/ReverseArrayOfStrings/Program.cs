using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split();
            string result = "";

            for (int i = arr.Length-1; i >=0; i--)
            {
                result += arr[i]+ " ";
            }
            Console.WriteLine(result);
        }
    }
}

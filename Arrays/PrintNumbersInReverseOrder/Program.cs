using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
               
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                output += arr[i]+" ";
                
            }
            Console.WriteLine(output);
        }
    }
}

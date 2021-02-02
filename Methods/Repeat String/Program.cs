using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintString(input,n));

            
        }
        static string PrintString(string input, int n )
        {
            string output = "";
            for (int i = 0; i < n; i++)
            {
                output +=input;
            }
            return output;
        }
    }
}

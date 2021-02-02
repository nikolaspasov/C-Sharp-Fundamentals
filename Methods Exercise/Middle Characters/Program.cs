using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = GetMiddleChar(input);
            Console.WriteLine(output);
        }
        static string GetMiddleChar(string input)
        {
            string middle = "";
            if (input.Length % 2 != 0)
            {
                middle = input[input.Length / 2].ToString();
            }
            else
            {
                middle = input[input.Length / 2-1].ToString() + input[input.Length / 2 ].ToString();
            }
            return middle;
        }
    }
}

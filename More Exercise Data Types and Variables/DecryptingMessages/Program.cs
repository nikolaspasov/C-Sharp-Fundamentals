using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string output = "";


            for (int i = 0; i < lines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int value = (int)ch;
                int firstValue=value;
                for (int j = firstValue; j < value+key; j++)
                {
                    firstValue++;
                }
                ch = (char)firstValue;
                output += ch;
            }
            Console.WriteLine(output);
        }
    }
}

using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintChar(first, second);
        }
        static void PrintChar(char firstChar, char secondChar)
        {
            int valueFirst = (int)firstChar;
            int valueSecond = (int)secondChar;
            string result = "";


            if (valueSecond > valueFirst)
            {
                for (int i = valueFirst + 1; i < valueSecond; i++)
                {
                    char currChar = (char)i;
                    result += currChar + " ";
                }
               
            }
            else
            {
                for (int i = valueSecond + 1; i < valueFirst; i++)
                {
                    char currChar = (char)i;
                    result += currChar + " ";
                }

            }
            Console.WriteLine(result);
        }
    }
}

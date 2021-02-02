using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintVowels(input);
        }
        static void PrintVowels(string input)
        {
            int vowelCount = 0;
            for (int i = 0; i < input.Length ; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'e' || input[i] == 'u' || input[i] == 'i' ||
                   input[i] == 'A' || input[i] == 'O' || input[i] == 'E' || input[i] == 'U' || input[i] == 'I')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}

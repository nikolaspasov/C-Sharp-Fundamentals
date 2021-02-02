using System;
using System.Collections.Generic;
using System.IO;

namespace Associative_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();

            Dictionary<char,int> charDictionary = new Dictionary<char, int>();

            
            for (int i = 0; i < charArray.Length; i++)
            {
                char key = charArray[i];
                if (key==' ')
                {
                    continue ;
                }
                else if(charDictionary.ContainsKey(key))
                {
                    charDictionary[key]++;
                }
                else
                {
                    charDictionary.Add(key, 1);
                }
            }
            foreach (var character in charDictionary)
            {
                Console.WriteLine(character.Key+" -> "+character.Value);
            }
        }
    }
}

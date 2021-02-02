using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < elements.Length; i++)
            {
                string elementLowerCase = elements[i].ToLower();
                if(dictionary.ContainsKey(elementLowerCase))
                {
                    dictionary[elementLowerCase]++;
                }
                else
                {
                    dictionary.Add(elementLowerCase, 1);
                }
            }
            foreach (var element in dictionary)
            {
                if(element.Value%2!=0)
                {
                    Console.Write(element.Key+" ");
                }
            }

        }
    }
}

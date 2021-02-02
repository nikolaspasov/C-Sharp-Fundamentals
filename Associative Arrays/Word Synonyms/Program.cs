using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymDict = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if(synonymDict.ContainsKey(key))
                {
                    synonymDict[key].Add(value);
                }
                else
                {
                    List<string> newList = new List<string> { value };
                    synonymDict.Add(key, newList);
                }
            }
            foreach (var synonyms in synonymDict)
            { 
                Console.WriteLine(synonyms.Key+ " - "+ string.Join(", ",synonyms.Value));
            }
        }
    }
}

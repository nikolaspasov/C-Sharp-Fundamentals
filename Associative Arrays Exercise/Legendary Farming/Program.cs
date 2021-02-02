using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyElements = new Dictionary<string, int>();
            keyElements.Add("motes", 0);
            keyElements.Add("fragments", 0);
            keyElements.Add("shards", 0);

            Dictionary<string, int> junkElements = new Dictionary<string, int>();



            int amount = 0;
            string element = "";
            string legendaryItem = "";
            bool exitLoop = false;
            while (legendaryItem == string.Empty)
            {
                string input = Console.ReadLine().ToLower();
                string[] inputString = input.Split();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        amount = int.Parse(inputString[i]);
                    }
                    else if (i % 2 != 0)
                    {
                        element = inputString[i];
                        if (keyElements.ContainsKey(element))
                        {
                            keyElements[element] += amount;
                            
                        }
                        if (junkElements.ContainsKey(element))
                        {
                            junkElements[element] += amount;
                        }

                        else if (!keyElements.ContainsKey(element))
                        {
                            switch (element)
                            {
                                case "shards":
                                case "motes":
                                case "fragments": keyElements.Add(element, amount);
                                    
                                         break;
                                default:
                                    junkElements.Add(element, amount); break;
                                    
                            }

                        }
                        if(keyElements.ContainsKey(element))
                        if (keyElements[element] >= 250)
                        {
                            exitLoop = true;
                                keyElements[element] -= 250;
                                switch (element)
                            {
                                case "shards": legendaryItem = "Shadowmourne"; break;
                                case "fragments": legendaryItem = "Valanyr"; break;
                                case "motes": legendaryItem = "Dragonwrath"; break;
                                        
                            }
                                break;

                        }
                    }
                }


            }
            keyElements = keyElements.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            Console.WriteLine(legendaryItem+" obtained!");
            junkElements = junkElements.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var var in keyElements)
            {
                Console.WriteLine(var.Key+": "+var.Value);
            }
            foreach (var var in junkElements)
            {
                Console.WriteLine(var.Key + ": " + var.Value);
            }
        }
    }
}

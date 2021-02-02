using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sidesDict = new Dictionary<string, List<string>>();
            List<string> namesList = new List<string>();
            string command = Console.ReadLine();
            string name = "";
            string newSide = "";
            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {//add
                    name = command.Split(" | ")[1];
                    newSide = command.Split(" | ")[0];

                    if (!sidesDict.ContainsKey(newSide))
                    {
                        sidesDict.Add(newSide, new List<string> { });
                    }
                    if (sidesDict.ContainsKey(newSide)&&sidesDict[newSide].Contains(name) == false &&
                      sidesDict.Values.Any(x => x.Contains(name)) == false)
                    {
                        sidesDict[newSide].Add(name);
                        namesList.Add(name);
                    }
                    //else if (!sidesDict[forceSide].Contains(name) && sidesDict.ContainsKey(forceSide))
                    //{
                    //   sidesDict[forceSide].Add(name);
                    //}
                }
                else
                {//change
                    name = command.Split(" -> ")[0];
                    newSide = command.Split(" -> ")[1];
                    bool nameExists = false; ;
                    if(sidesDict.ContainsKey(newSide))
                    {
                        if (sidesDict[newSide].Contains(name)) 
                        break;
                    }
                    foreach (var currSide in sidesDict)
                    {
                        if (currSide.Key != newSide)
                        {
                            if (currSide.Value.Contains(name))
                            {
                                if (!sidesDict.ContainsKey(newSide))
                                {
                                    sidesDict.Add(newSide, new List<string>());
                                }
                                sidesDict[newSide].Add(name);
                                namesList.Add(name);
                                currSide.Value.Remove(name);
                                Console.WriteLine(name + " joins the " + newSide + " side!");
                                nameExists = true;
                                break;

                            }
                            if (!sidesDict.Values.Any(x=>x.Contains(name)))
                            {
                                if (!sidesDict.ContainsKey(newSide))
                                {
                                    sidesDict.Add(newSide, new List<string>());
                                }
                                sidesDict[newSide].Add(name);
                                namesList.Add(name);
                                Console.WriteLine(name + " joins the " + newSide + " side!");
                                break;
                            }
                        }
                        
                    }
                    //if (nameExists == false && !sidesDict.ContainsKey(newSide))
                    //{
                    //    sidesDict.Add(newSide, new List<string> { name });
                    //}
                    //else if (nameExists == false&&sidesDict.ContainsKey(newSide))
                    //{
                    //    sidesDict[newSide].Add(name);
                    //    Console.WriteLine(name + " joins the " + newSide + " side!");
                    //}
                   
                    
                    
                }
                command = Console.ReadLine();
            }


            foreach (var side in sidesDict.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
                
            {
                if (side.Value.Count == 0)
                    continue;
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var member in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! " + member);
                }

            }
        }
    }
}

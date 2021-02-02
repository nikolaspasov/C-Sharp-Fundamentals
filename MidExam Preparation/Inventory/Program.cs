using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split(", "));

            string command = Console.ReadLine();

            while (command!="Craft!")
            {
                if (command.Contains("Collect"))
                {
                    string item = command.Split()[2];
                    if(list.Contains(item))
                    {
                        
                    }
                    else
                    {
                       list.Add(item);
                    }
                    
                }
                else if (command.Contains("Drop"))
                {
                    string item = command.Split()[2];
                    list.Remove(item);
                } 
                else if (command.Contains("Combine"))
                {
                    string items = command.Split()[3];
                    string item1 = items.Split(":")[0];
                    string item2 = items.Split(":")[1];
                    if(list.Contains(item1))
                    {
                        list.Insert(list.IndexOf(item1)+1, item2);
                    }
                } 
                else if (command.Contains("Renew"))
                {
                    
                    string item = command.Split()[2];
                    if (list.Contains(item))
                    {
                        string currItem = item;
                        list.Remove(item);

                        list.Add(currItem);
                    }
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                if(i==list.Count-1)
                {
                    Console.Write(list[i]) ;
                    break;
                }
                Console.Write(list[i]+", ");
                
            }
        }
    }
}

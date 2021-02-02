using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeeDict = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while(command!="End")
            {
                string company = command.Split(" -> ")[0];
                string employeeID = command.Split(" -> ")[1];
                if(employeeDict.ContainsKey(company))
                {
                    if(employeeDict[company].Contains(employeeID))
                    {
                        
                    }
                    else
                    employeeDict[company].Add(employeeID);
                }
                else
                {
                    employeeDict.Add(company, new List<string> { employeeID });
                }
                command = Console.ReadLine();

            }
            employeeDict = employeeDict.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var currCompany in employeeDict)
            {
                Console.WriteLine(currCompany.Key);
                foreach (var employee in currCompany.Value)
                {
                    Console.WriteLine("-- "+ employee);
                }
            }
        }
    }
}

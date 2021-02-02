using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> finalList = new List<double>();
            int firstCount = 0;
            int secondCount = 0;
            for (int i = 0; i <numbers1.Count + numbers2.Count; i++)
            {
                
                 if (i % 2 == 0&&numbers1.Count>firstCount)
                {
                    finalList.Add(numbers1[firstCount]);
                    firstCount++;
                }
                else if (i % 2 != 0&&numbers2.Count>secondCount)
                {
                    finalList.Add(numbers2[secondCount]);
                    secondCount++;
                }
               else if (firstCount >= numbers1.Count)
                {
                    finalList.Add(numbers2[secondCount]);
                    secondCount++;
                }
                else if (secondCount >= numbers2.Count)
                {
                    finalList.Add(numbers1[firstCount]);
                    firstCount++;
                }

            }
            Console.WriteLine(string.Join(" ", finalList ));
        }
    }
}

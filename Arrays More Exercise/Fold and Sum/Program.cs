using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = firstList.Count / 4;

            List<int> upperList = new List<int> { };
            List<int> lowerList = new List<int> { };

            for (int i = k-1; i >=0; i--)
            {
                upperList.Add(firstList[i]);
            }

            for (int i = firstList.Count - 1; i >= firstList.Count - k; i--)
            {
                upperList.Add(firstList[i]);
            }

            for (int i = k; i <firstList.Count-k; i++)
            {
                lowerList.Add(firstList[i]);
            }
           

           

            for (int i = 0; i < upperList.Count; i++)
            {
                int currNum = upperList[i] + lowerList[i];
                upperList[i] = currNum;
            }
            Console.WriteLine(string.Join(" ", upperList));
        }
    }
}

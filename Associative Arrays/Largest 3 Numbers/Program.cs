using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList(); ;

            numbersList = numbersList.OrderByDescending(x => x).ToList();

            if (numbersList.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbersList[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < numbersList.Count; i++)
                {
                    Console.Write(numbersList[i]+" ");
                }
            }
        }
    }
}

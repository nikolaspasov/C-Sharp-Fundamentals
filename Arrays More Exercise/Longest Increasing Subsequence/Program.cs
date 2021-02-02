using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> longest = new List<int> { };
            List<int> current = new List<int> { };
            int currentNum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                
                current.Add(list[i]);

                for (int j = i+1; j < list.Count; j++)
                {
                    
                  if(list[j]>currentNum)
                  {
                     current.Add(list[j]);
                     currentNum = list[j];
                  }
              }
            } 
              
              
        }     
    }         
}             

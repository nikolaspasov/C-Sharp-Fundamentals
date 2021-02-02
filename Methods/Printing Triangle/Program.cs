﻿using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintLine(start, i);
            }
            for (int i = n-1; i >=1; i--)
            {
                PrintLine2(start, i);
            }
            
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("");            
        }
        static void PrintLine2(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("");
        }
    }
}

﻿using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if(char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
            else { Console.WriteLine("lower-case"); }
        }
    }
}

﻿using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string output = $"{first}{second}{third}";
            Console.WriteLine(output);
        }
    }
}

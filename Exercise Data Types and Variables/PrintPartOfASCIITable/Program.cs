using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            string output = "";


            for (int i = start; i <= end; i++)
            {
               
                char ch = Convert.ToChar(i);
                output += ch + " ";

            }
            Console.WriteLine(output);
        }
    }
}

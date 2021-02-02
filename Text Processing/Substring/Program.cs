using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string result = second;
            while (result.Contains(first))
            {
                int index = second.IndexOf(first);
                result= second.Remove(index, first.Length);
            }
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Threading.Tasks.Sources;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                char newChar = (char)((int)input[i] + 3);
                output += newChar;
            }
            Console.WriteLine(output);
        }
    }
}

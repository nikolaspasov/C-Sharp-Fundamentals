using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string lastSymbol = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if(lastSymbol==input[i].ToString())
                {
                    
                }
                else
                {
                    sb.Append(input[i]);
                    lastSymbol = input[i].ToString();
                }
            }
            Console.WriteLine(sb);
        }
    }
}

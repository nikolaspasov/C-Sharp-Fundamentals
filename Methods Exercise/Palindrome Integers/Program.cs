using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while(input!="END")
            {
               
                bool isBackward = GetBackward(input);
                if(isBackward==true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }

        }
        static bool GetBackward(string input)
        {
            string numberBackwards = "";
            for (int i = input.Length-1; i >=0; i--)
            {
                numberBackwards += input[i];
            }
            if(numberBackwards==input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

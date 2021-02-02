using System;
using System.Linq;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] inputArray = Console.ReadLine().ToCharArray();
            string digits = string.Empty;
            string letters = string.Empty;
            string otherChars = string.Empty;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if(char.IsDigit(inputArray[i]))
                {
                    digits += inputArray[i];
                }
                else if(char.IsLetter(inputArray[i]))
                {
                    letters += inputArray[i];
                }
                else
                {
                    otherChars += inputArray[i];
                }
            }
            Console.WriteLine(digits+"\n"+letters+"\n"+otherChars);
        }
    }
}

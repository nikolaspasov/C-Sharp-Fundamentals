using System;
using System.Data;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
          //string[] delimeters = {" ", ", " , "! ", ". ","/"};
            string input = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                if(input.Contains(bannedWords[i]))
                {
                    string replacement = new string('*', bannedWords[i].Length);
                   input =  input.Replace(bannedWords[i], replacement);
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}

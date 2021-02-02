using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pairPattern = new Regex
                (@"([@#])(?<firstWord>[a-zA-Z]{3,})(\1)(\1)(?<secondWord>[a-zA-Z]{3,})(\1)");

            MatchCollection pairMatches = pairPattern.Matches(input);
            StringBuilder mirrorResult = new StringBuilder();

            foreach (Match pair in pairMatches)
            {
                var firstWord = pair.Groups["firstWord"].Value;
                var secondWord = pair.Groups["secondWord"].Value;

                StringBuilder stringBuilderSecondWord = new StringBuilder();
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    stringBuilderSecondWord.Append(secondWord[i]);
                }


                if (firstWord == stringBuilderSecondWord.ToString())
                {
                    if (mirrorResult.ToString() == string.Empty)
                    {
                        mirrorResult.Append($"{firstWord} <=> {secondWord}");
                    }
                    else
                    {
                        mirrorResult.Append($", {firstWord} <=> {secondWord}");
                    }
                }
            }
            if (pairMatches.Count== 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairMatches.Count} word pairs found!");
            }
            if (mirrorResult.ToString() == string.Empty)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(mirrorResult);
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

            string pattern = @"\+359([ ,-])2(\1)[\d]{3}(\1)[\d]{4}\b";

            //+359 2 222 2222,  +359-2-222-2222
            Regex newRegex = new Regex(pattern);

            MatchCollection newCollection = newRegex.Matches(phoneNumber);
            string result = "";
            foreach (Match number in newCollection)
            {
                if (result == "")
                {
                    result += number.Value;
                }
                else
                {
                    result += ", "+number.Value ;
                }
            }
            Console.WriteLine(string.Join("",result));
        }

    }
}

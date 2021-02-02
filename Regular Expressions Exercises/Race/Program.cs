using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> participantsDict = new Dictionary<string, int>();

            for (int i = 0; i < participants.Count; i++)
            {
                participantsDict.Add(participants[i], 0);
            }

            string input = Console.ReadLine();
            Regex namePattern = new Regex(@"(?<name>[a-zA-Z])");
            Regex distancePattern = new Regex(@"(?<distance>[1-9])");

            MatchCollection nameCollection = namePattern.Matches(input);
            MatchCollection distanceCollection = distancePattern.Matches(input);
            while (input != "end of race")
            {
                nameCollection = namePattern.Matches(input);
                distanceCollection = distancePattern.Matches(input);
                string matchedName = "";
                for (int i = 0; i < nameCollection.Count; i++)
                {
                    matchedName += (nameCollection[i]);
                }
                if (participantsDict.ContainsKey(matchedName))
                {
                    int distanceSum = 0;
                    foreach (Match distance in distanceCollection)
                    {
                        var distanceString = distance.Groups["distance"].Value;

                        for (int i = 0; i < distanceString.Length; i++)
                        {
                            distanceSum += int.Parse(distanceString[i].ToString());
                        }

                    }
                    participantsDict[matchedName] += distanceSum;
                }

                input = Console.ReadLine();
            }
            participantsDict = participantsDict.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            int count = 1;
            foreach (var item in participantsDict)
            {
                if(count==1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                count++;

            }


        }
    }
}

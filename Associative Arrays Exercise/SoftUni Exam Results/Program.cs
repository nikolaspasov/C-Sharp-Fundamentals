using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentsDict = new Dictionary<string, int>();
            Dictionary<string, int> languageDict = new Dictionary<string, int>();


            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                if (input.Contains("banned"))
                {
                    string studentToBan = input.Split("-")[0];
                    if (studentsDict.ContainsKey(studentToBan))
                    {
                        studentsDict.Remove(studentToBan);
                    }
                }
                else
                {
                    string language = input.Split("-")[1];
                    string username = input.Split("-")[0];
                    int points = int.Parse(input.Split("-")[2]);

                    if (!studentsDict.ContainsKey(username))
                    {
                        studentsDict.Add(username, points);
                    }
                    else if (studentsDict.ContainsKey(username) && studentsDict[username] < points)
                    {
                        studentsDict[username] = points;
                    }

                    if (!languageDict.ContainsKey(language))
                    {
                        languageDict.Add(language, 1);
                    }
                    else
                    {
                        languageDict[language]++;
                    }
                }

                input = Console.ReadLine();
            }
            studentsDict = studentsDict
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            languageDict = languageDict
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var student in studentsDict)
            {
                Console.WriteLine(student.Key + " | " + student.Value);
            }
            Console.WriteLine("Submissions:");
            foreach (var currLanguage in languageDict)
            {
                Console.WriteLine(currLanguage.Key + " - " + currLanguage.Value);
            }
        }
    }
}

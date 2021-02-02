using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseDict = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string course = input.Split(" : ")[0];
                string person = input.Split(" : ")[1];
                if (courseDict.ContainsKey(course))
                {
                    courseDict[course].Add(person);
                }
                else
                {
                    courseDict.Add(course, new List<string> { person });
                }
                input = Console.ReadLine();
            }
            foreach (var course in courseDict)
            {
                List<string> orderedList = course.Value.OrderBy(x => x.Split()[0]).ToList();
                courseDict[course.Key] = orderedList;
            }
            courseDict = courseDict.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var course in courseDict)
            {
                Console.WriteLine(course.Key + ": " + course.Value.Count);
                foreach (var person in course.Value)
                {
                    Console.WriteLine("-- " + string.Join(" ", person));
                }

            }
        }
    }
}

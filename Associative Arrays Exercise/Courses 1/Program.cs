using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses_1
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
            List<string> orderedlist = new List<string>();
            foreach (var course in courseDict.ToList())
            {
                orderedlist= course.Value.OrderBy(x => x.Split()[0]).ThenBy(x => x.Split()[1]).ToList();
                courseDict[course.Key] = orderedlist;
            }
            //courseDict = courseDict.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var course in courseDict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(course.Key + ": " + course.Value.Count);
                foreach (var person in course.Value)
                {
                    Console.WriteLine("-- " + string.Join(" ", person));
                }
                //    foreach (var course in courseDict.OrderByDescending(x => x.Value.Count))
                //{
                //    Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                //    foreach (var name in course.Value.OrderBy(x => x))
                //    {
                //        Console.WriteLine($"-- {name}");
                //    }
                //}
            }
        }
    }
}


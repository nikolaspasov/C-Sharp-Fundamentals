using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>> studentDict = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(studentDict.ContainsKey(name))
                {
                    studentDict[name].Add(grade);
                }
                else
                {
                    studentDict.Add(name, new List<double> { grade });
                }

            }
            
            foreach (var student in studentDict)
            {
                double averageGrade = 0;
                for (int i = 0; i < student.Value.Count; i++)
                {
                    averageGrade += student.Value[i];
                }
                averageGrade = averageGrade / student.Value.Count;
                if(averageGrade<4.50)
                {
                    studentDict.Remove(student.Key);
                }
                else
                {
                    student.Value.Clear();
                    student.Value.Add(averageGrade);
                }
            }
             
            foreach (var student in studentDict.OrderByDescending(x=>x.Value[0]))
            {
                Console.WriteLine($"{student.Key} -> {student.Value[0]:f2}");
            }

        }
    }
}

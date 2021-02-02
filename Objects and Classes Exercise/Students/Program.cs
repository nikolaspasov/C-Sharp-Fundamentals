using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{

    class Student
    {
        public string FirstName;
        public string LastName;
        public decimal Grade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());
            string input = "";
            List<Student> studentList = new List<Student>();

            for (int i = 0; i < studentsNumber; i++)
            {
                input = Console.ReadLine();

                Student newStudent = new Student();
                newStudent.FirstName = input.Split()[0];
                newStudent.LastName = input.Split()[1];
                newStudent.Grade =decimal.Parse(input.Split()[2]);

                studentList.Add(newStudent);
            }
            studentList = studentList.OrderByDescending(o => o.Grade).ToList();
            foreach (var newStudent in studentList)
            {
                Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName}: {newStudent.Grade}" );
            }
            


        }
    }
}

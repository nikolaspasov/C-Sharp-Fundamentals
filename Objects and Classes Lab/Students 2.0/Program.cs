using System;
using System.Collections.Generic;
using System.Data;

namespace Students
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string hometown;

    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> studentList = new List<Student>();

            while (command != "end")
            {
                Student newStudent = new Student();
                newStudent.firstName = command.Split()[0];
                newStudent.lastName = command.Split()[1];
                newStudent.age = int.Parse(command.Split()[2]);
                newStudent.hometown = command.Split()[3];
                bool existing = false;
                for (int i = studentList.Count-1; i >= 0; i--)
                {
                    if(studentList[i].firstName==newStudent.firstName&& studentList[i].lastName==newStudent.lastName)
                    {
                        studentList[i].age = newStudent.age;
                        existing = true;
                        continue;
                    }
                    
                }
                if(existing==false)
                {
                    studentList.Add(newStudent);
                    
                }
                command = Console.ReadLine();
            }

            string hometownFilter = Console.ReadLine();
            foreach (Student newStudent in studentList)
            {
                if (newStudent.hometown == hometownFilter)
                {
                    Console.WriteLine
                        ($"{newStudent.firstName} {newStudent.lastName} is {newStudent.age} years old.");
                }
            }

        }
    }
}

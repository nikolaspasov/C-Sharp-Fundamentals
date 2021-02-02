using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Objects_and_Classes_More_Exercises
{
    class Employee
    {
        public string Name;
        public double Salary;
        public string Department;
    }
    class Departments
    {
        //public string Name;
        //public double Salary;
        public List<string> NameAndSalaryList = new List<string>();
        public double TotalSalary;
        public string DepartmentName;
        public double averageSalary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            List<Departments> departmentList = new List<Departments>();
            int n = int.Parse(Console.ReadLine());
            string input = "";

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string employeeName = input.Split()[0];
                double employeeSalary = double.Parse(input.Split()[1]);



                string employeeDepartment = input.Split()[2];
                bool exists = false;

                Departments newDepartment = new Departments();
                foreach (var department in departmentList)
                {


                    // if (employeeList.Any(x => x.Department == employeeDepartment))
                    if (department.DepartmentName == employeeDepartment)
                    {


                        newDepartment.DepartmentName = employeeDepartment;
                        //newDepartment.Salary = employeeSalary;
                        //newDepartment.Name = employeeName;
                        string salaryAsString = employeeSalary.ToString();
                        string nameAndSalaryString = employeeName + " " + salaryAsString;
                        //List<string> nameAndSalaryList = new List<string> { nameAndSalaryString };
                        department.NameAndSalaryList.Add(nameAndSalaryString);

                        exists = true;
                    }
                }
                if (exists == false)
                {
                    newDepartment.DepartmentName = employeeDepartment;
                    //newDepartment.Salary = employeeSalary;
                    //newDepartment.Name = employeeName;
                    string salaryAsString = employeeSalary.ToString();
                    string nameAndSalaryString = employeeName + " " + salaryAsString;
                    // List<string> nameAndSalaryString = new List<string> { employeeName, salaryAsString };
                    newDepartment.NameAndSalaryList.Add(nameAndSalaryString);
                    departmentList.Add(newDepartment);
                }
                Employee newEmployee = new Employee();
                newEmployee.Name = employeeName;
                newEmployee.Salary = employeeSalary;
                newEmployee.Department = employeeDepartment;

                employeeList.Add(newEmployee);
            }


            List<double> salaryList = new List<double>();
            int counter = 0;
            double nameSalary = 0;
            foreach (var department in departmentList)
            {
                for (int i = 0; i < department.NameAndSalaryList.Count; i++)
                {
                    nameSalary += double.Parse(department.NameAndSalaryList[i].Split()[1]);

                }
                salaryList.Add(nameSalary); //.Split()[1]));
                nameSalary = 0;
            }
            foreach (var department in departmentList)
            {
                department.TotalSalary += (double)salaryList[counter];
                counter++;
            }
            foreach (var department in departmentList)
            {
                department.averageSalary = (department.TotalSalary / department.NameAndSalaryList.Count);
            }

            departmentList = departmentList.OrderByDescending(x => x.averageSalary).ToList();

            Console.WriteLine($"Highest Average Salary: {departmentList[0].DepartmentName}");

            foreach (var department in departmentList)
            {
                department.NameAndSalaryList = department.NameAndSalaryList.OrderByDescending(x => double.Parse(x.Split()[1])).ToList();

                for (int i = 0; i < department.NameAndSalaryList.Count; i++)
                {

                    Console.WriteLine
                        ($"{department.NameAndSalaryList[i].Split()[0]} {double.Parse(department.NameAndSalaryList[i].Split()[1]):F2}");

                }
                break;

            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class People
    {
        public string Name;
        public string ID;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peopleList = new List<People>();
            string input = Console.ReadLine();

            while (input!="End")
            {
                People newPerson = new People();
                newPerson.Name = input.Split()[0];
                newPerson.ID = input.Split()[1];
                newPerson.Age = int.Parse(input.Split()[2]);

                input = Console.ReadLine();

                peopleList.Add(newPerson);
            }

            peopleList = peopleList.OrderBy(x => x.Age).ToList();

            foreach (var newPerson in peopleList)
            {
                Console.WriteLine($"{newPerson.Name} with ID: {newPerson.ID} is {newPerson.Age} years old.");
            }
        }
    }
}

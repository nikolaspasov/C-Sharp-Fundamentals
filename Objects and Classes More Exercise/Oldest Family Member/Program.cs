using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Family
    {
        public List<Person> peopleList = new List<Person>();
        
        public void AddMember(Person newPerson)
        {
            peopleList.Add(newPerson);
        }
        public Person GetOldestMember(List<Person> peopleList)
        {
            peopleList  = peopleList.OrderByDescending(x => x.Age).ToList();
            var oldest = peopleList[0];
            return oldest;
        }
    }
    class Person
    {
        public string Name;
        public int Age;

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string personInput = "";
            Family newFamily = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                Person newPerson = new Person();

                personInput = Console.ReadLine();
                newPerson.Name = personInput.Split()[0];
                newPerson.Age = int.Parse(personInput.Split()[1]);

                newFamily.AddMember(newPerson);


            }
          var oldest = newFamily.GetOldestMember(newFamily.peopleList);
            Console.WriteLine(oldest.Name+ " " + oldest.Age);
            
        }
    }
}

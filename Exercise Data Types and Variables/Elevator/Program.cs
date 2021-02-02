using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            while(people>capacity)
            {
                courses = people / capacity;
                people = people - capacity * courses;
            }
            if(people>0)
            {
                courses++;
            }
            Console.WriteLine(courses);
            
        }
    }
}

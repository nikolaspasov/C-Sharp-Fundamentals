using System;
using System.Collections.Generic;

namespace Objects_and_Classes_Exercise
{
    class RandomNumber
    {
        public int randomPhrase;
        public int randomEvent;
        public int randomAuthor;
        public int randomCity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
            { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[]
            { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!","I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[]
            { "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva" };
            string[] city = new string[]
            { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            List<RandomNumber> randomList = new List<RandomNumber>();
            for (int i = 0; i < people; i++)
            {
                RandomNumber newNumber = new RandomNumber();

                Random random = new Random();
             newNumber.randomPhrase= random.Next(0, phrases.Length);
                newNumber.randomEvent = random.Next(0, events.Length);
                newNumber.randomAuthor = random.Next(0, authors.Length);
                newNumber.randomCity = random.Next(0, city.Length);
                randomList.Add(newNumber);
            }
            foreach (var newNumber in randomList)
            {
                Console.Write(phrases[newNumber.randomPhrase]);
                
                Console.Write(events[newNumber.randomEvent]);
                
                Console.Write($" {authors[newNumber.randomAuthor]} - ");
                
                Console.Write($"{city[newNumber.randomCity]}");

                Console.WriteLine();
            }


        }
    }
}

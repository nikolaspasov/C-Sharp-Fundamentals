using System;

namespace ProblemSolving
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Blue", "Yellow", "White" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Dane", "Swede", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main(string[] args)
        {
            Random random = new Random();
            Shuffle(random);

        }
        static void Shuffle(Random random)
        {

        }
    }
}

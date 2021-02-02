using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split("\\");

            string data = array[array.Length-1];
            string fileName = data.Split('.')[0];
            string fileType = data.Split('.')[1];

            Console.WriteLine("File name: "+fileName);
            Console.WriteLine("File extension: "+fileType);

            
        }
    }
}

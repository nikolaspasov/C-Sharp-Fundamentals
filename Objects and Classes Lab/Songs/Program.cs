using System;
using System.Collections.Generic;

namespace Songs
{
   public class Song
    {
        public string type ;
        public string name ;
        public string time ;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            string input = "";
            List<Song> songsList = new List<Song>();

            string type;
            string name;
            string time;
            for (int i = 0; i < numSongs; i++)
            {
                input = Console.ReadLine();

                 type = input.Split("_")[0];
                 name = input.Split("_")[1];
                 time = input.Split("_")[2];

                Song song = new Song();

                song.type = type;
                song.name = name;
                song.time = time;

                songsList.Add(song);
            }

            string typeList = Console.ReadLine();
            if(typeList=="all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                foreach  (Song song in songsList)
                {
                    if(song.type==typeList)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }

        }

    }
    
}

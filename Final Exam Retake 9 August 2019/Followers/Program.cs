using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class LikesAndComments
    {
        public int Likes;
        public int Comments;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, LikesAndComments> userDict = new Dictionary<string, LikesAndComments>();
            string command = Console.ReadLine();
            while (command != "Log out")
            {
                if (command.Contains("New"))
                {
                  
                    if (userDict.ContainsKey(command.Split()[2]))
                    {
                        
                    }
                    else
                    {
                        LikesAndComments newUser = new LikesAndComments() { Likes = 0, Comments = 0 };
                        userDict.Add(command.Split()[2], newUser);
                    }
                }
                if (command.Contains("Like"))
                {
                    LikesAndComments newUser = new LikesAndComments() { Likes = 0, Comments = 0 };
                    if (!userDict.ContainsKey(command.Split(": ")[1]))
                    {
                        newUser.Likes = int.Parse(command.Split(": ")[2]);
                        userDict.Add(command.Split(": ")[1], newUser);
                    }
                    else
                    {
                        var user = command.Split(": ")[1];
                        userDict[user].Likes += int.Parse(command.Split(": ")[2]);

                    }

                }
                if (command.Contains("Comment"))
                {
                    LikesAndComments newUser = new LikesAndComments() { Likes = 0, Comments = 0 };
                    if (!userDict.ContainsKey(command.Split()[1]))
                    {
                        newUser.Comments = 1;
                        userDict.Add(command.Split()[1], newUser);
                    }
                    else
                    {
                        var user = command.Split()[1];
                        userDict[user].Comments += 1;

                    }

                }
                if (command.Contains("Blocked"))
                {
                    var username = command.Split()[1];
                    if (userDict.ContainsKey(username))
                    {
                        userDict.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine(username + " doesn't exist.");
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(userDict.Count + " followers");

            ////            In the end, you have to print the count of followers, 
            //                each follower with his / her likes and comments(the sum of likes and comments)
            //                sorted in descending order by the likes and then by their
            //                username in ascending order
            //                in the following format:
            ////            { count}
            ////            followers
            ////{ username}: { likes + comments}
            ////            { username}: { likes + comments}
            ///
            userDict = userDict.OrderByDescending(x => x.Value.Likes)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var user in userDict)
            {
                Console.WriteLine(user.Key+": " +(user.Value.Likes+user.Value.Comments));
            }



        }
    }
}

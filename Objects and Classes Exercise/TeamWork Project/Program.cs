using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWork_Project
{
    public class Team
    {
        public string TeamName;
        public string Creator;
        public List<string> Members;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<Team> teamsList = new List<Team>();
            

            while (input != "end of assignment")
            {
                
                if (input.Contains("->"))
                {
                    string member = input.Split("-")[0];
                    string name = input.Split("-")[1];
                    if (teamsList.Any(x => x.TeamName==name))
                    {
                        Console.WriteLine("does not exist");
                        continue;
                    }
                    else if (teamsList.Any(x => x.Members.Contains(member)))
                    {
                        Console.WriteLine("cannot join another team");
                        continue;
                    }
                    int index = teamsList.FindIndex(x => x.TeamName == name);
                    teamsList[index].Members.Add(member);
                    
                        
                }
                else
                {            
                   string creator = input.Split("-")[0];
                   string name  = input.Split("-")[1];
                    if (teamsList.Any(x => x.TeamName == name))
                    {
                        Console.WriteLine("Already exists!");
                    }
                    else if(teamsList.Any(x=>x.Creator==creator))
                    {
                        Console.WriteLine("Cannot create another team");
                    }

                    Team newTeam = new Team();
                    newTeam.Creator = creator;
                    newTeam.TeamName = name;

                    teamsList.Add(newTeam);
                }

                input = Console.ReadLine();


            }
            foreach (var newTeam in teamsList)
            {
                if(newTeam.Members.Count==0)
                {
                    Console.WriteLine($"{newTeam } dismantled");
                }
            }
        }
    }
}

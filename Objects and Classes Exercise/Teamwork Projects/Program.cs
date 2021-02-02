using System;
using System.Collections.Generic;

namespace Teamwork_Projects
{

    class Team
    {
        public string Creator;
        public string TeamName;
        public string Member;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int teamsNumber = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<Team> teamList = new List<Team>();
            

            while (input != "end of assignment")
            {
                Team newTeam = new Team();

                if (input.Contains("->"))
                {
                    newTeam.Member += input.Split("->")[0];
                    newTeam.TeamName = input.Split("->")[1];
                    teamList.Add(newTeam);

                }
                else
                {
                    newTeam.Creator = input.Split("-")[0];
                    newTeam.TeamName = input.Split("-")[1];
                    teamList.Add(newTeam);
                }
                input = Console.ReadLine();
            }
            foreach (var newTeam in teamList)
            {
                Console.WriteLine(newTeam.Creator);
                Console.WriteLine(newTeam.TeamName);
                Console.WriteLine(newTeam.Member);
            }
        }
        

    }
}

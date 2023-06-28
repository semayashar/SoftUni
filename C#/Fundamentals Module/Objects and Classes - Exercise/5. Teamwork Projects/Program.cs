using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}

class Program
{
    static void Main()
    {
        int numTeams = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        for (int i = 0; i < numTeams; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string creator = input[0];
            string teamName = input[1];

            if (teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (teams.Any(t => t.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            Team team = new Team(teamName, creator);
            teams.Add(team);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        string joinInput;
        while ((joinInput = Console.ReadLine()) != "end of assignment")
        {
            string[] input = joinInput.Split("->");
            string user = input[0];
            string teamName = input[1];

            if (!teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Creator == user) || teams.Any(t => t.Members.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            Team team = teams.First(t => t.Name == teamName);
            team.Members.Add(user);
        }

        List<Team> validTeams = teams
            .Where(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        List<Team> disbandedTeams = teams
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.Name)
            .ToList();

        foreach (Team team in validTeams)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (string member in team.Members.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (Team team in disbandedTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
}

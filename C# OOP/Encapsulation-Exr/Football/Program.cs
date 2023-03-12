using System;
using System.Collections.Generic;
using System.Linq;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();


            while (command != "END")
            {
                string[] data = command.Split(";");
                string operation = data[0];
                if (operation == "Team")
                {
                    try
                    {
                        Team team = new Team(data[1]);
                        if (!teams.Contains(team))
                        {
                            teams.Add(team);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (operation == "Add")
                {
                    try
                    {
                        string team = data[1];
                        if (!teams.Any(t => t.Name == team))
                        {
                            Console.WriteLine($"Team {team} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }
                        Team teamToAdd = teams.First(t => t.Name == team);
                        string playerName = data[2];
                        int endurance = int.Parse(data[3]);
                        int sprint = int.Parse(data[4]);
                        int dribble = int.Parse(data[5]);
                        int passing = int.Parse(data[6]);
                        int shooting = int.Parse(data[7]);
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teamToAdd.AddPlayer(player);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (operation == "Remove")
                {
                    try
                    {
                        string teamName = data[1];
                        string playerName = data[2];
                        Team targetTeam = teams.First(t => t.Name == teamName);
                        if (!targetTeam.Players.Any(p => p.Name == playerName))
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                            command = Console.ReadLine();
                            continue;
                        }
                        var player = targetTeam.Players.First(p => p.Name == playerName);
                        targetTeam.RemovePlayer(player);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        command = Console.ReadLine();
                        continue;
                    }

                }
                else if (operation == "Rating")
                {
                    try
                    {
                        string teamName = data[1];
                        if (!teams.Any(t => t.Name == teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }
                        var team = teams.First(t => t.Name == teamName);
                        decimal rating = team.GetRating();
                        Console.WriteLine($"{teamName} - {rating}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        command = Console.ReadLine();
                        continue;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}

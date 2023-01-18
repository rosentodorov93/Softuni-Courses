using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] data = input.Split(":");
                string contest = data[0];
                string password = data[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, string.Empty);
                }
                contests[contest] = password;

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "end of submissions")
            {
                string[] parts = command.Split("=>");
                string contestName = parts[0];
                string contestPass = parts[1];
                string userName = parts[2];
                int userPoints = int.Parse(parts[3]);

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName] == contestPass)
                    {
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, new Dictionary<string, int>());
                        }
                        if (!users[userName].ContainsKey(contestName))
                        {
                            users[userName].Add(contestName, 0);
                        }
                        if (userPoints > users[userName][contestName])
                        {
                            users[userName][contestName] = userPoints;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var user in users.OrderByDescending(u => u.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {user.Key} with total {user.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

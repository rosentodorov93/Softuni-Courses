using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> following = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] parts = command.Split();

                string name = parts[0];
                string operation = parts[1];

                if (operation == "joined")
                {
                    if (!followers.ContainsKey(name))
                    {
                        followers.Add(name, new List<string>());
                        following.Add(name, new List<string>());
                    }
                }
                else if (operation == "followed")
                {
                    string secondName = parts[2];

                    if (followers.ContainsKey(name) && followers.ContainsKey(secondName) && secondName != name && !following[name].Contains(secondName))
                    {
                        following[name].Add(secondName);
                        followers[secondName].Add(name);  
                    }
                }

                command = Console.ReadLine();
            }
            int count = 1;
            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            bool finish = false;
            foreach (var vlogger in followers.OrderByDescending(v => v.Value.Count).ThenBy(f => following[f.Key].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");
                count++;
                if (vlogger.Value.Count > 0)
                {
                    foreach (var follower in vlogger.Value.OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                    finish = true;
                }

                followers.Remove(vlogger.Key);
                following.Remove(vlogger.Key);
                if (finish)
                {
                    break;
                }
            }

            foreach (var vlogger in followers.OrderByDescending(v => v.Value.Count).ThenBy(f => following[f.Key].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");
                count++;
                                
            }
        }
    }
}

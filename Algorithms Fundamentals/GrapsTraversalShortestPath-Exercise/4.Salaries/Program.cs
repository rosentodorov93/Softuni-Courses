using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.Salaries
{
    public class Program
    {
        private static List<int>[] graph;
        private static HashSet<int> visited;
        private static Dictionary<int, int> foundSelaries;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            graph = new List<int>[n];
            visited = new HashSet<int>();
            foundSelaries = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();

                string line = Console.ReadLine();

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'Y')
                    {
                        graph[i].Add(j);
                    }
                }
            }
            int totalSalaries = 0;
            for (int i = 0; i < graph.Length; i++)
            {
                totalSalaries += DFS(i);
            }

            Console.WriteLine(totalSalaries);
        }

        private static int DFS(int node)
        {
            if (foundSelaries.ContainsKey(node))
            {
                return foundSelaries[node];
            }

            visited.Add(node);

            if (graph[node].Count == 0)
            {
                return 1;
            }

            int current = 0;
            foreach (var child in graph[node])
            {
                current += DFS(child);
            }

            return current;
        }
    }
}
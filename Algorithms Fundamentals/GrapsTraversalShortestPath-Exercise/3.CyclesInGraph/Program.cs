using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.CyclesInGraph
{
    public class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static List<string> cycles;
        private static List<string> visited;
        static void Main(string[] args)
        {
            graph = new Dictionary<string, List<string>>();
            visited = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] edge = line.Split("-");

                string first = edge[0];
                string second = edge[1];

                if (!graph.ContainsKey(first))
                {
                    graph[first] = new List<string>();
                }

                if (!graph.ContainsKey(second))
                {
                    graph[second] = new List<string>();
                }

                graph[first].Add(second);
            }

            try
            {
                foreach (var node in graph.Keys)
                {
                    cycles = new List<string>();
                    DFS(node);
                }

                Console.WriteLine("Acyclic: Yes");
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine("Acyclic: No");
            }
        }

        private static void DFS(string node)
        {
            if (cycles.Contains(node))
            {
                throw new InvalidOperationException();
            }

            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            cycles.Add(node);

            foreach (var child in graph[node])
            {
                DFS(child);
            }

            cycles.Remove(node);
        }
    }
}
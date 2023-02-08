using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.DistanceBetweenVertices
{
    public class Program
    {
        static Dictionary<int, List<int>> graph;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            graph = new Dictionary<int, List<int>>();


            List<string> results = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] edges = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int node = int.Parse(edges[0]);

                if (!graph.ContainsKey(node))
                {
                    graph[node] = new List<int>();
                }

                if (edges.Length > 1)
                {
                    int[] childs = edges[1].Split(" ").Select(int.Parse).ToArray();

                    foreach (var child in childs)
                    {
                        graph[node].Add(child);
                    }
                    
                }
            }

            for (int i = 0; i < p; i++)
            {
                int[] parts = Console.ReadLine().Split("-").Select(int.Parse).ToArray();
                int start = parts[0];
                int destination = parts[1];

                results.Add($"{{{start}, {destination}}} -> {ShortestPath(start, destination)}");
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static int ShortestPath(int start, int destination)
        {

            HashSet<int> visited = new HashSet<int>() { start };
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> parent = new Dictionary<int, int>();
            parent[start] = - 1;

            queue.Enqueue(start);

            while (queue.Count > 0)
            {

                int current = queue.Dequeue();

                if (current == destination)
                {
                    return GetSteps(parent, destination);
                }

                foreach (var child in graph[current])
                {
                    if (visited.Contains(child))
                    {
                        continue;
                    }

                    visited.Add(child);
                    queue.Enqueue(child);
                    parent[child] = current;
                }
            }

            return -1;
        }
        private static int GetSteps(Dictionary<int,int> parent, int destination)
        {
            int steps = 0;
            int index = destination;

            while (index != - 1)
            {
                index = parent[index];
                steps++;

            }

            return steps - 1;
        }
    }
}
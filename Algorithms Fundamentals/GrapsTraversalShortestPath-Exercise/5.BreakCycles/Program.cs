using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.BreakCycles
{
    public class Edge
    {
        public string First { get; set; }
        public string Second { get; set; }
    }
    public class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static List<Edge> edges;
        private static List<Edge> edgesToRemove;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = new Dictionary<string, List<string>>();
            edges = new List<Edge>();
            edgesToRemove = new List<Edge>();

            for (int i = 0; i < n; i++)
            {
                var edgeLine = Console.ReadLine().Split(" -> ");

                string node = edgeLine[0];
                var childs = edgeLine[1].Split().ToList();

                graph[node] = childs;

                foreach (var child in childs)
                {
                    edges.Add(new Edge { First = node, Second = child});
                }
            }

            edges = edges.OrderBy(e => e.First).ThenBy(e => e.Second).ToList();

            foreach(var edge in edges)
            {
                var removedEdge = graph[edge.First].Remove(edge.Second) && graph[edge.Second].Remove(edge.First);
                
                if (!removedEdge)
                {
                    continue;
                }

                if (BFS(edge.First, edge.Second))
                {
                    edgesToRemove.Add(edge);
                }
                else
                {
                    graph[edge.First].Add(edge.Second);
                    graph[edge.Second].Add(edge.First);
                }

            }

            Console.WriteLine($"Edges to remove: {edgesToRemove.Count}");
            foreach (var edge in edgesToRemove)
            {
                Console.WriteLine($"{edge.First} - {edge.Second}");
            }
        }

        private static bool BFS(string start, string destination)
        {
            var queue = new Queue<string>();

            queue.Enqueue(start);

            var visited = new HashSet<string>() { start };

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();

                if (current == destination)
                {
                    return true;
                }

                foreach (var child in graph[current])
                {
                    if (visited.Contains(child))
                    {
                        continue;
                    }

                    visited.Add(child);
                    queue.Enqueue(child);
                }

            }

            return false;
        }
    }
}
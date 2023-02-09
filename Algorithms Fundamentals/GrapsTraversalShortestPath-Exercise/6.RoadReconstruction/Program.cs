namespace _6.RoadReconstruction
{
    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
    public class Program
    {
        private static List<int>[] graph;
        private static List<Edge> edges;
        private static bool[] visited;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            graph = new List<int>[n];
            edges = new List<Edge>();

            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                var edgeLine = Console.ReadLine().Split(" - ");

                int node = int.Parse(edgeLine[0]);
                int child = int.Parse(edgeLine[1]);

                graph[node].Add(child);
                graph[child].Add(node);

                edges.Add(new Edge { First = node, Second = child });
            }

            Console.WriteLine($"Important streets:");
            foreach (var edge in edges)
            {
                graph[edge.First].Remove(edge.Second);
                graph[edge.Second].Remove(edge.First);

                visited = new bool[graph.Length];

                DFS(0);

                if (visited.Contains(false))
                {
                    Console.WriteLine($"{edge.First} {edge.Second}");
                }

                graph[edge.First].Add(edge.Second);
                graph[edge.Second].Add(edge.First);

            }
        }

        private static void DFS(int node)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var child in graph[node])
            {
                DFS(child);
            }
        }
    }
}
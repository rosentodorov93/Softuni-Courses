using System;
using System.Linq;
using System.Collections.Generic;
namespace _8.SetCover
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int[]> sets = new List<int[]>();
            List<int[]> usedSets = new List<int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] currentSet = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sets.Add(currentSet);
            }

            while (universe.Count > 0)
            {
                int[] currentSet = sets.OrderByDescending(s => s.Count(x => universe.Contains(x))).FirstOrDefault();

                usedSets.Add(currentSet);
                sets.Remove(currentSet);

                foreach (var item in currentSet)
                {
                    universe.Remove(item);
                }
            }

            Console.WriteLine($"Sets to take ({usedSets.Count}):");
            foreach (var set in usedSets)
            {
                Console.WriteLine(String.Join(", ",set));
            }
        }
    }
}
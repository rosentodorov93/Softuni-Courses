using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {



        Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string color = input[0];
            string[] clothArgs = input[1].Split(",");

            if (!clothes.ContainsKey(color))
            {
                clothes.Add(color, new Dictionary<string, int>());
            }

            foreach (var item in clothArgs)
            {
                if (!clothes[color].ContainsKey(item));
                clothes[color].Add(item, 0);
                clothes[color][item]++;

            }

        }

        string[] target = Console.ReadLine().Split(" ");

        foreach (var item in clothes)
        {
            Console.WriteLine($"{item.Key} clothes:");
            foreach (var (clothe, value) in item.Value)
            {
                if (clothe == target[1] && item.Key == target[0])
                {
                    Console.WriteLine($"* {clothe} - {value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {clothe} - {value}");
                }
            }
        }


    }
}
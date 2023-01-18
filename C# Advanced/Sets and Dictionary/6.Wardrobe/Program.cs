using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string color = data[0];
                string[] currClothes = data[1].Split(",");
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < currClothes.Length; j++)
                {
                    string cloth = currClothes[j].Trim();
                    if (!clothes[color].ContainsKey(cloth))
                    {
                        clothes[color].Add(cloth, 0);
                    }
                    clothes[color][cloth]++;
                }
            }

            string[] target = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string targetColor = target[0].Trim();
            string targetCloth = target[1].Trim();

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key.Trim()} clothes:");

                foreach (var cloth in item.Value)
                {
                    if (item.Key.Trim() == targetColor && cloth.Key.Trim() == targetCloth)
                    {
                        Console.WriteLine($"* {cloth.Key.Trim()} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key.Trim()} - {cloth.Value}");
                    }
                }
            }
        }
    }
}

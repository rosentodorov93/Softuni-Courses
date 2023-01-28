using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4.Cinema
{
    internal class Program
    {
        static List<string> names;
        static string[] variations;
        static string[] result;
        static List<string> visited;
        static void Main(string[] args)
        {
            names = Console.ReadLine().Split(", ").ToList();
            variations = new string[names.Count];
            result = new string[names.Count];
            visited = new List<string>();

            string command = Console.ReadLine();

            while (command != "generate")
            {
                var parts = command.Split(" - ").ToArray();
                result[int.Parse(parts[1]) - 1] = parts[0];
                names.Remove(parts[0]);

                command = Console.ReadLine();
            }

            GenereatePlaces(0);
        }
        private static void GenereatePlaces(int index)
        {
            if (index >= names.Count)
            {
                Print();
                return;
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (!visited.Contains(names[i]))
                {
                    visited.Add(names[i]); 
                    variations[index] = names[i];
                    GenereatePlaces(index + 1);
                    visited.Remove(names[i]);
                }
            }
        }

        private static void Print()
        {
            int count = 0;
            var sb = new StringBuilder();

            foreach (var item in result)
            {
                if (item == null)
                {
                    sb.Append(variations[count++] + " ");
                }
                else
                {
                    sb.Append(item + " ");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
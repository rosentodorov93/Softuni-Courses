using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.VariationsWithoutrepetitions
{
    public class Program
    {
        static string[] elements;
        static bool[] used;
        static string[] variations;
        static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split().ToArray();
            k = int.Parse(Console.ReadLine());
            variations = new string[k];

            used = new bool[elements.Length];

            GenereateVariations(0);
        }

        private static void GenereateVariations( int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(String.Join(" ", variations));
                return;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    GenereateVariations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
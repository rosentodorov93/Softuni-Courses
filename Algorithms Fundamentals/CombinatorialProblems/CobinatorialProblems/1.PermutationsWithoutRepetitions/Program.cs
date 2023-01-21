using System;
using System.Linq;

namespace _1.PermutationsWithoutRepetitions
{
    public class Program
    {
        static string[] elements;
        static bool[] used;
        static string[] permutations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split().ToArray();
            used = new bool[elements.Length];
            permutations = new string[elements.Length];

            //GenereatePermutations(elements, 0);
            GenereatePermutationsWithSwap(0);
        }

        private static void GenereatePermutationsWithSwap(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(String.Join(" ", elements));
                return;
            }

            GenereatePermutationsWithSwap(index + 1);

            for (int i = index + 1; i < elements.Length; i++)
            {
                Swap(index, i);
                GenereatePermutationsWithSwap(index + 1);
                Swap(index, i);
            }
        }

        private static void Swap(int first, int second)
        {
            string temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        private static void GenereatePermutations(string[] elements, int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(String.Join(" ", permutations));
                return;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = elements[i];
                    GenereatePermutations(elements, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
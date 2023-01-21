using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.PermutationsWithRepetitions
{
    public class Program
    {
        static string[] elements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split().ToArray();

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
            var used = new HashSet<string>() { elements[index] };

            for (int i = index + 1; i < elements.Length; i++)
            {
                if (!used.Contains(elements[i]))
                {
                    Swap(index, i);
                    GenereatePermutationsWithSwap(index + 1);
                    Swap(index, i);
                    used.Add(elements[i]);
                }
            }
        }

        private static void Swap(int first, int second)
        {
            string temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

       
    }
}
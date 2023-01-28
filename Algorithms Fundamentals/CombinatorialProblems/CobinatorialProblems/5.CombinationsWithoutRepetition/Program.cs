using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.CombinationsWithoutRepetition
{
    public class Program
    {
        static string[] elements;
        static bool[] used;
        static string[] combinations;


        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split().ToArray();
            int k = int.Parse(Console.ReadLine());
            combinations = new string[k];



            GenereateCombinations(0, 0);
        }

        private static void GenereateCombinations(int index, int start)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(String.Join(" ", combinations));
                return;
            }
            for (int i = start; i < elements.Length; i++)
            {

                combinations[index] = elements[i];
                GenereateCombinations(index + 1, i);
            }
        }
    }
}
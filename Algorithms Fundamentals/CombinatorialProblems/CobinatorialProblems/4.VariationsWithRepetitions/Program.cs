using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.VariationsWithRepetitions
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

    

            GenereateVariations(0);
        }

        private static void GenereateVariations(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(String.Join(" ", variations));
                return;
            }
            for (int i = 0; i < elements.Length; i++)
            {

                variations[index] = elements[i];
                GenereateVariations(index + 1);


            }
        }
    }
}
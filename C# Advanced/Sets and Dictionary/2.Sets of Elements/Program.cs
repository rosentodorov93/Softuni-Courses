using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                n.Add(currNum);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                m.Add(currNum);
            }

            n.IntersectWith(m);

            foreach (var num in n)
            {
                Console.Write(num + " ");
            }
        }
    }
}

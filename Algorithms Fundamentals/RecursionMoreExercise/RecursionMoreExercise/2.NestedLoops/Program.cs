using System;
using System.Linq;

namespace _2.NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] loops = new int[n];

            RecursiveLoops(loops, 0);
        }

        private static void RecursiveLoops(int[] loops, int index)
        {
            if (index >= loops.Length)
            {
                Console.WriteLine(String.Join(" ", loops));
                return;
            }

            for (int i = 1; i <= loops.Length; i++)
            {
                loops[index] = i;
                RecursiveLoops(loops, index + 1);
            }
        }
    }
}
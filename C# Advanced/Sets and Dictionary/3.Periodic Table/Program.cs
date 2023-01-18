using System;
using System.Collections.Generic;

namespace _3.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currChemicals = Console.ReadLine().Split();

                for (int j = 0; j < currChemicals.Length; j++)
                {
                    chemicals.Add(currChemicals[j]);
                }
            }
            foreach (var chemical in chemicals)
            {
                Console.Write(chemical + " ");
            }
        }
    }
}

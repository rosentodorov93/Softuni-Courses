using System;
using System.Collections.Generic;

namespace _5.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> list = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!list.ContainsKey(input[i]))
                {
                    list.Add(input[i], 0);
                }
                list[input[i]]++;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}

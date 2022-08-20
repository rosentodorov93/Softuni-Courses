using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Fashion_Botique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(box);
            int racks = 0;
            int value = 0;

            if (capacity == 0)
            {
                racks = 0;
            }
            else
            {
                for (int i = 0; i < clothes.Count; i++)
                {
                    value += clothes.Peek();
                   
                    if (value < capacity)
                    {
                        clothes.Pop();
                        i--;
                    }
                    else if (value == capacity && clothes.Count > 0)
                    {
                        racks++;
                        clothes.Pop();
                        i--;
                        value = 0;
                    }
                    else if (value > capacity)
                    {
                        value = clothes.Pop();
                        racks++;
                        i--;
                    }

                }
            }
            if (value > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int bulletCount = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bullets = new Stack<int>(input);
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> locks = new Queue<int>(input2);

            int intelligence = int.Parse(Console.ReadLine());
            int currShotCount = 0;
            int totalShotCount = 0;
            bool isOpen = false;
            while (bullets.Count > 0)
            {
                currShotCount++;
                totalShotCount++;

                if (bullets.Pop() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();    
                }
                else
                {
                    Console.WriteLine("Ping!");    
                }

                if (currShotCount == bulletCount && bullets.Count > 0)
                {
                    currShotCount = 0;
                    Console.WriteLine("Reloading!");
                }

                if (locks.Count == 0)
                {
                    isOpen = true;
                    break;
                }
            }
            if (isOpen)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (totalShotCount * bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}

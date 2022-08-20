using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedWater = 0;

            while (bottles.Count > 0)
            {
                int currCup = cups.Dequeue();
                if (bottles.Peek() >= currCup)
                {
                    int currWater = bottles.Pop() - currCup;
                    if (currWater > 0 )
                    {
                        wastedWater += currWater;

                    }
                }
                else 
                {
                    while (currCup > 0)
                    {

                        currCup -= bottles.Peek();

                        if (currCup < 0)
                        {
                            wastedWater += Math.Abs(currCup);
                            bottles.Pop();
                        }
                        else
                        {
                            bottles.Pop();
                        }
                    }
                }
                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }
            }

            Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}

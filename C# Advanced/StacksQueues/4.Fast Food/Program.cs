using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orderList = new Queue<int>(orders);
            Queue<int> test = new Queue<int>(orders);
            int biggestOrder = int.MinValue;

            for (int i = 0; i < orderList.Count; i++)
            {
                

                if (test.Peek() > biggestOrder)
                {
                    biggestOrder = test.Dequeue();
                }
                else
                {
                    test.Dequeue();
                }
            }
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList.Peek() <= food)
                {
                    food -= orderList.Dequeue();
                    i--;

                    if (food == 0)
                    {
                        break;
                    }
                }
            }
            if (orderList.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orderList)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

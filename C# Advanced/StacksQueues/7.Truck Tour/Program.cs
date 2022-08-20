using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> fuel = new Queue<int>(); 
            Queue<int> distance = new Queue<int>(); 
            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                fuel.Enqueue(data[0]);
                distance.Enqueue(data[1]);
            }
            int totalFuel = 0;
            int tank = 0;
            int count = 0;
            int currStop = 0;
            while (count != n)
            {               
                totalFuel += fuel.Peek();

                if (totalFuel < distance.Peek())
                {
                    int currfuel = fuel.Dequeue();
                    int currdistance = distance.Dequeue();
                    fuel.Enqueue(currfuel);
                    distance.Enqueue(currdistance);
                    currStop++;
                    tank = currStop;
                    totalFuel = 0;
                    count = 0;
                }
                else
                {
                    int currfuel = fuel.Dequeue();
                    int currdistance = distance.Dequeue();
                    fuel.Enqueue(currfuel);
                    distance.Enqueue(currdistance);
                    totalFuel -= currdistance;
                    count++;
                    currStop++;
                }
            }

            Console.WriteLine(tank);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = parts[0];
            int s = parts[1];
            int x = parts[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> num = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                num.Pop();
            }

            if (num.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (num.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int smallestNum = int.MaxValue;

                for (int i = 0; i < num.Count; i++)
                {
                    
                    if (num.Peek() < smallestNum)
                    {
                        smallestNum = num.Peek();                      
                    }
                    
                    
                }

                Console.WriteLine(smallestNum);
            }
        }
    }
}

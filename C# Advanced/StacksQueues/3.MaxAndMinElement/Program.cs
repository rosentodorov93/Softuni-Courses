using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> collection = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command.Contains(1))
                {
                    collection.Push(command[1]);
                }
                else if (command.Contains(2) && collection.Count > 0)
                {
                    collection.Pop();
                }
                else if (command.Contains(3))
                {
                    if (collection.Count > 0)
                    {
                        int maxElement = int.MinValue;
                        Stack<int> test = new Stack<int>(collection);

                        for (int j = 0; j < collection.Count; j++)
                        {
                            if (test.Peek() > maxElement)
                            {
                                maxElement = test.Pop();
                            }
                            else
                            {
                                test.Pop();
                            }
                        }
                        Console.WriteLine(maxElement);
                    }
                }
                else if (command.Contains(4))
                {
                    if (collection.Count > 0)
                    {
                        int minElement = int.MaxValue;
                        Stack<int> test = new Stack<int>(collection);


                        for (int j = 0; j < collection.Count; j++)
                        {
                            if (test.Peek() < minElement)
                            {
                                minElement = test.Pop();
                            }
                            else
                            {
                                test.Pop();
                            }
                        }
                        Console.WriteLine(minElement);
                    }                   
                }
            }

            Console.WriteLine(string.Join(", ",collection));
        }
    }
}

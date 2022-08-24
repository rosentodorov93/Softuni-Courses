using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ").ToArray();

            var queue = new Queue<string>(songs);

            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("No more Songs");
                    break;
                }
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var commandParts = command.Split().ToArray();

                    var song = string.Join(" ", commandParts.Skip(1));

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
        }
    }
}

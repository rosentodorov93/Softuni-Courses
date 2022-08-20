using System;
using System.Collections.Generic;

namespace _11.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int greenOriginal = greenLight;
            int freeOriginal = freeWindow;

            string command = Console.ReadLine();
            int passedCars = 0;

            Queue<string> cars = new Queue<string>();

            while (command != "END")
            {
                if (command == "green")
                {
                    greenLight = greenOriginal;
                    while (greenLight > 0)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        greenLight -= cars.Peek().Length;

                        if (greenLight >= 0)
                        {
                            cars.Dequeue();
                            passedCars++;
                        }                     
                        else if (greenLight < 0)
                        {
                            int difrenece = Math.Abs(greenLight);
                            int test = (cars.Peek().Length - difrenece) + freeOriginal;
                            freeWindow -= difrenece;
                            if (freeWindow < 0)
                            {
                                
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{cars.Peek()} was hit at {cars.Peek()[test]}.");
                                return;
                            }
                            else
                            {
                                passedCars++;
                                cars.Dequeue();
                                freeWindow = freeOriginal;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}

using System;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationary = new StationaryPhone();

            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    stationary.Call(number);
                }
                else
                {
                    smartphone.Call(number);
                }
            }
            foreach (var site in websites)
            {
                smartphone.Browzing(site);
            }
        }
    }
}

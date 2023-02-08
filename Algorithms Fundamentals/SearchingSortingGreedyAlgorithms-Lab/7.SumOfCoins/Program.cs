using System;
using System.Linq;
using System.Collections.Generic;
namespace _7.SumOfCoins
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> coins = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).OrderBy(c => c));
            int targetSum = int.Parse(Console.ReadLine());
            Dictionary<int, int> result = new Dictionary<int, int>();

            int totalCoinsCount = 0;

            while (coins.Count > 0 && targetSum > 0)
            {
                int currentCoin = coins.Pop();

                if (currentCoin > targetSum)
                {
                    continue;
                }

                int timesUsed = targetSum / currentCoin;
                targetSum -= currentCoin * timesUsed;
                totalCoinsCount += timesUsed;
                result.Add(currentCoin, timesUsed);
            }

            if (targetSum > 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {totalCoinsCount}");

                foreach (var coin in result)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            

        }
    }
}
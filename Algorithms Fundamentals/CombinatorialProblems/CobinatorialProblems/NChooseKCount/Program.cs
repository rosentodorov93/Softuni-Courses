﻿namespace NChooseKCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Binom(n, k));
        }

        private static int Binom(int n, int k)
        {
            if (n <= 1)
            {
                return 1;
            }
            if (k == 0 || k == n)
            {
                return 1;
            }

            return Binom(n - 1, k) + Binom(n - 1, k - 1);
        }
    }
}
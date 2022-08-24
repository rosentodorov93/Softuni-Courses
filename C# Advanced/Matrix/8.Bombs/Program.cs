using System;
using System.Linq;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int bombRow = 0; bombRow < n; bombRow++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int bombCol = 0; bombCol < n; bombCol++)
                {
                    matrix[bombRow, bombCol] = data[bombCol];
                }
            }

            string[] bombsCordinates = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < 3; i++)
            {
                int[] currbomb = bombsCordinates[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = currbomb[0];
                int bombCol = currbomb[1];
               
                if (bombRow - 1 >= 0)
                {
                    if (matrix[bombRow - 1, bombCol] > 0)
                    {
                        matrix[bombRow - 1, bombCol] -= matrix[bombRow, bombCol];
                    }

                    if (bombCol - 1 >= 0 && matrix[bombRow - 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol - 1] -= matrix[bombRow, bombCol];
                    }
                    if (bombCol + 1 < n && matrix[bombRow - 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol + 1] -= matrix[bombRow, bombCol];
                    }
                }
                if (bombRow + 1 < n)
                {
                    if (matrix[bombRow + 1, bombCol] > 0)
                    {
                        matrix[bombRow + 1, bombCol] -= matrix[bombRow, bombCol];
                    }
                    if (bombCol - 1 >= 0 && matrix[bombRow + 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol - 1] -= matrix[bombRow, bombCol];

                    }
                    if (bombCol + 1 < n && matrix[bombRow + 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol + 1] -= matrix[bombRow, bombCol];

                    }
                }
                if (bombCol + 1 < n && matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol];
                }
                if (bombCol - 1 >= 0 && matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol];
                }

                matrix[bombRow, bombCol] = 0;
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }

                }
            }

            int[] first = bombsCordinates[0].Split(",").Select(int.Parse).ToArray();
            int[] second = bombsCordinates[1].Split(",").Select(int.Parse).ToArray();
            int[] third = bombsCordinates[2].Split(",").Select(int.Parse).ToArray();
            matrix[first[0], first[1]] = 0;
            matrix[second[0], second[1]] = 0;
            matrix[third[0], third[1]] = 0;
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.AreasInMatrix
{
    public class Program
    {
        private static char[,] matrix;
        private static bool[,] visited;
        private static Dictionary<char, int> areas;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            matrix = new char[n, m];
            visited = new bool[n,m]; 
            areas = new Dictionary<char, int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col]; 
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (visited[row,col])
                    {
                        continue;
                    }

                    char currenSymbol = matrix[row, col];
                    DFS(row, col, currenSymbol);

                    if (!areas.ContainsKey(currenSymbol))
                    {
                        areas.Add(currenSymbol, 0);
                    }

                    areas[currenSymbol]++;
                }
            }

            Console.WriteLine($"Areas: {areas.Sum(s => s.Value)}");
            foreach (var area in areas.OrderBy(a => a.Key))
            {
                Console.WriteLine($"Letter '{area.Key}' -> {area.Value}");
            }
        }

        private static void DFS(int row, int col, char symbol)
        {
            if (!IsValid(row,col,symbol))
            {
                return;
            }

            visited[row, col] = true;

            DFS(row + 1, col, symbol);
            DFS(row - 1, col, symbol);
            DFS(row, col + 1, symbol);
            DFS(row, col - 1, symbol);
        }

        private static bool IsValid(int row, int col, char symbol)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[row,col] != symbol)
            {
                return false;
            }

            if (visited[row,col] == true)
            {
                return false;
            }

            return true;
        }
    }
}
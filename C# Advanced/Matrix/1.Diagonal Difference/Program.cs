using System;
using System.Linq;

namespace _1.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {   
                    if (matrix[row,col] == matrix[row, (n -1) - row])
                    {
                        secondDiagonal += matrix[row, col];
                    }
                    if (row == col)
                    {
                        firstDiagonal += matrix[row, col];
                    }            
                }
            }
            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}

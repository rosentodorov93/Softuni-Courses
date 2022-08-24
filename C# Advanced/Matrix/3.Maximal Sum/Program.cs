using System;
using System.Linq;

namespace _3.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int n = 3;
            int sum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < rows - (n - 1); row++)
            {
                for (int col = 0; col < cols - (n -1); col++)
                {
                    int currSum = 0;
                   
                    for (int i =row ; i < row + n ; i++)
                    {
                        for (int j = col; j < col + n ; j++)
                        {
                            currSum += matrix[i, j];       
                        }
                    }
                    if (currSum > sum)
                    {
                        sum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int row = maxRow; row < maxRow + n; row++)
            {
                for (int col = maxCol; col < maxCol + n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}

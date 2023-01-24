using System;
using System.Linq;

namespace _3.ConnectedAreasInMatrix
{
    internal class Program
    {
        static char[,] matrix;
        static int size;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            matrix = new char[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRowInput = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRowInput[col];
                }
            }

            size = 0;
            GetAreas(0, 8);

            Console.WriteLine(size);
        }

        private static void GetAreas(int row, int col)
        {
            matrix[row , col] = 'v';

            if (CanMove(row + 1, col))
            {
                
                GetAreas(row + 1, col);
                

            }
            if (CanMove(row - 1, col))
            {
                
                GetAreas(row - 1, col);
                
            }
            if (CanMove(row , col + 1))
            {
                
                GetAreas(row , col + 1);
                
            }
            if (CanMove(row, col - 1))
            {
                
                GetAreas(row, col - 1);
                
            }

            size++;
            return;
        }

        private static bool CanMove(int row, int col)
        {
            if (row < 0 || col < 0 || row>= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }
            if (matrix[row,col] == 'v' || matrix[row,col] == '*')
            {
                return false;
            }

            return true;
        }
    }
}
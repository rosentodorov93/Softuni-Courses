using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _3.ConnectedAreasInMatrix
{
    public class Program
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
            var areas = new List<Area>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row, col] == '-')
                    {
                        size = 0;
                        GetAreas(row, col);
                        areas.Add(new Area(row, col, size));
                    }
                }
            }
            Console.WriteLine($"Total areas found: {areas.Count}");
            int count = 1;
            foreach (var area in areas.OrderByDescending(a => a.Size).ThenBy(a => a.Row).ThenBy(a => a.Col))
            {
                Console.WriteLine($"Area #{count++} at ({area.Row}, {area.Col}), size: {area.Size}");
            }
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
    public class Area
    {
        public Area(int row, int col, int size)
        {
            Row = row;
            Col = col;
            Size = size;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int Size { get; set; }
    }

}
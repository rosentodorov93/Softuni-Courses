using System;
using System.Linq;

namespace _4.Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] parts = command.Split().ToArray();

                if (parts.Contains("swap") && parts.Length == 5)
                {
                    int row1 = int.Parse(parts[1]);
                    int col1 = int.Parse(parts[2]);
                    int row2 = int.Parse(parts[3]);
                    int col2 = int.Parse(parts[4]);

                    if (row1 >= 0 && row1 < rows &&
                        col1 >= 0 && col1 < cols &&
                        row2 >= 0 && row2 < rows &&
                        col2 >= 0 && col2 < cols )
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}

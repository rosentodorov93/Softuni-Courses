using System;

namespace _7.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col] == 'K')
                    {
                        if (col - 1 >= 0 && row + 2 < n)
                        {
                            if (matrix[row, col] == matrix[row + 2, col - 1])
                            {
                                counter++;
                                matrix[row + 2, col - 1] = '0';
                            }

                        }
                         if (col - 1 >= 0 && row - 2 >= 0)
                        {
                            if (matrix[row, col] == matrix[row - 2, col - 1])
                            {
                                counter++;
                                matrix[row - 2, col - 1] = '0';
                            }
                        }

                         if (col + 1 < n && row + 2 < n)
                        {
                            if (matrix[row, col] == matrix[row + 2, col + 1])
                            {
                                counter++;
                                matrix[row + 2, col + 1] = '0';
                            }
                        }
                         if (col + 1 < n && row - 2 >= 0)
                        {
                            if (matrix[row, col] == matrix[row - 2, col + 1])
                            {
                                counter++;
                                matrix[row - 2, col + 1] = '0';
                            }
                        }
                         if (col - 2 >= 0 && row - 1 >= 0)
                        {
                            if (matrix[row, col] == matrix[row - 1, col - 2])
                            {
                                counter++;
                                matrix[row - 1, col - 2] = '0';
                            }
                        }
                         if (col - 2 >= 0 && row + 1 < n)
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 2])
                            {
                                counter++;
                                matrix[row + 1, col - 2] = '0';
                            }
                        }
                         if (col + 2 < n && row - 1 >= 0)
                        {
                            if (matrix[row, col] == matrix[row - 1, col + 2])
                            {
                                counter++;
                                matrix[row - 1, col + 2] = '0';
                            }
                        }
                         if (col + 2 < n && row + 1 < n)
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 2])
                            {
                                counter++;
                                matrix[row + 1, col + 2] = '0';
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

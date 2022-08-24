using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            int pRow = 0;
            int pCol = 0;
            for (int row = 0; row < rows; row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col].ToString();
                    if (matrix[row,col] == "P")
                    {
                        pRow = row;
                        pCol = col;
                    }
                }
            }
            string directions = Console.ReadLine();
            Queue<int> bunnyCordinates = new Queue<int>();
            bool won = false;
            bool dead = false;
            matrix[pRow, pCol] = ".";
            for (int i = 0; i < directions.Length; i++)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row,col] == "B")
                        {
                            bunnyCordinates.Enqueue(row);
                            bunnyCordinates.Enqueue(col);
                        }
                    }
                }
                
                while (bunnyCordinates.Count > 0)
                {
                    int curRow = bunnyCordinates.Dequeue();
                    int curCol = bunnyCordinates.Dequeue();

                    if (curRow - 1 >= 0 && matrix[curRow -1,curCol] != "B")
                    {
                        matrix[curRow - 1, curCol] = "B";
                    }
                    if (curRow + 1 < rows && matrix[curRow + 1, curCol] != "B")
                    {
                        matrix[curRow + 1, curCol] = "B";
                    }
                    if (curCol - 1 >= 0 && matrix[curRow, curCol - 1] != "B")
                    {
                        matrix[curRow, curCol - 1] = "B";
                    }
                    if (curCol + 1 < cols && matrix[curRow, curCol + 1] != "B")
                    {
                        matrix[curRow, curCol + 1] = "B";
                    }
                }
                
                if (directions[i] == 'U')
                {
                    if (pRow - 1 < 0)
                    {
                        won = true;
                        break;
                    }
                    else
                    {
                        pRow--;
                        if (matrix[pRow,pCol] == "B")
                        {
                            dead = true;
                            break;
                        }
                    }
                }
                else if (directions[i] == 'D')
                {
                    if (pRow + 1 >= rows)
                    {
                        won = true;
                        break;
                    }
                    else
                    {
                        pRow++;
                        if (matrix[pRow, pCol] == "B")
                        {
                            dead = true;
                            break;
                        }
                    }
                }
                else if (directions[i] == 'R')
                {
                    if (pCol + 1 >= cols)
                    {
                        won = true;
                        break;
                    }
                    else
                    {
                        pCol++;
                        if (matrix[pRow, pCol] == "B")
                        {
                            dead = true;
                            break;
                        }
                    }
                }
                else if (directions[i] == 'L')
                {
                    if (pCol - 1 < 0)
                    {
                        won = true;
                        break;
                    }
                    else
                    {
                        pCol--;
                        if (matrix[pRow, pCol] == "B")
                        {
                            dead = true;
                            break;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
            if (won)
            {
                Console.WriteLine($"won: {pRow} {pCol}");
            }
            if (dead)
            {
                Console.WriteLine($"dead: {pRow} {pCol}");
            }
        }
    }
}

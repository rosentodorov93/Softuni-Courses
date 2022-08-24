using System;
using System.Linq;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split();
            string[,] matrix = new string[n, n];
            int sRow = 0;
            int sCol = 0;
            int coalCount = 0;
            for (int row = 0; row < n; row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                    if (matrix[row,col] == "s")
                    {
                        sRow = row;
                        sCol = col;
                    }
                    else if (matrix[row, col] == "c")
                    {
                        coalCount++;
                    }
                }
            }
            bool gameOver = false;
            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "up" && sRow - 1 >= 0)
                {
                    sRow--;
                    if (matrix[sRow,sCol] == "c")
                    {
                        coalCount--;
                        matrix[sRow, sCol] = "*";  
                    }
                    else if (matrix[sRow, sCol] == "e")
                    {                    
                        gameOver = true;
                        break;
                    }
                }
                else if (directions[i] == "down" && sRow + 1 < n)
                {
                    sRow++;
                    if (matrix[sRow, sCol] == "c")
                    {
                        coalCount--;
                        matrix[sRow, sCol] = "*";
                    }
                    else if (matrix[sRow, sCol] == "e")
                    {
                        gameOver = true;
                        break;
                    }
                }
                else if (directions[i] == "right" && sCol + 1 < n)
                {
                    sCol++;
                    if (matrix[sRow, sCol] == "c")
                    {
                        coalCount--;
                        matrix[sRow, sCol] = "*";  
                    }
                    else if (matrix[sRow, sCol] == "e")
                    {
                        gameOver = true;
                        break;
                    }
                    
                }
                else if (directions[i] == "left" && sCol - 1 >= 0)
                {
                    sCol--;
                    if (matrix[sRow, sCol] == "c")
                    {
                        coalCount--;
                        matrix[sRow, sCol] = "*";
                    }
                    else if (matrix[sRow, sCol] == "e")
                    {
                        gameOver = true;
                        break;
                    }
                }
                if (coalCount == 0)
                {
                    break;
                }
            }
            if (gameOver)
            {
                Console.WriteLine($"Game over! ({sRow}, {sCol})");
            }
            else if (coalCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
            }
            else
            {
                Console.WriteLine($"{coalCount} coals left. ({sRow}, {sCol})");
            }
    
        }
    }
}

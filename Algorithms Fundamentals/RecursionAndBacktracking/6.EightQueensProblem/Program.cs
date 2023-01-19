
const int BoardSize = 8;
HashSet<int> attackeRows = new HashSet<int>();
HashSet<int> attackeCols = new HashSet<int>();
HashSet<int> attackeLeftDiagonals = new HashSet<int>();
HashSet<int> attackeRightDiagonals = new HashSet<int>();


char[,] board = new char[BoardSize, BoardSize];

for (int row = 0; row < board.GetLength(0); row++)
{
    for (int col = 0; col < board.GetLength(1); col++)
    {
        board[row, col] = '-';
    }
}

SolveQueens(0);


void SolveQueens(int row)
{
    if (row >= board.GetLength(0))
    {
        PrintBoard();
        count++;
        return;

    }
    for (int col = 0; col < board.GetLength(1); col++)
    {
        if (CanPlaceQueen(row,col))
        {
            board[row,col] = '*';
            attackeRows.Add(row);
            attackeCols.Add(col);
            attackeLeftDiagonals.Add(col - row);
            attackeRightDiagonals.Add(row + col);

            SolveQueens(row + 1);

            attackeRows.Remove(row);
            attackeCols.Remove(col);
            attackeLeftDiagonals.Remove(col - row);
            attackeRightDiagonals.Remove(row + col);
            board[row, col] = '-';
        }
    }
}

void PrintBoard()
{
    for (int row = 0; row < board.GetLength(0); row++)
    {
        for (int col = 0; col < board.GetLength(1); col++)
        {
            Console.Write(board[row,col] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

bool CanPlaceQueen(int row, int col)
{
    if (attackeRows.Contains(row) || attackeCols.Contains(col))
    {
        return false;
    }
    if (attackeLeftDiagonals.Contains(col - row) || attackeRightDiagonals.Contains(row + col))
    {
        return false;
    }

    return true;
}
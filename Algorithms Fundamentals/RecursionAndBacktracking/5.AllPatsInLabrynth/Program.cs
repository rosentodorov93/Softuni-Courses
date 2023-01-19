int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

char[,] maze = new char[n, m];

for (int row = 0; row < n; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < m; col++)
    {
        maze[row, col] = currentRow[col];
    }
}

FindAllPaths(maze, 0, 0, "");

void FindAllPaths(char[,] maze, int row, int col, string path)
{
    if (maze[row,col] == 'e')
    {
        Console.WriteLine(path);
        return;
    }

    maze[row,col] = 'v';

    if (IsSafe(maze,row + 1 ,col))
    {
        FindAllPaths(maze, row + 1, col, path + "D");
    }
    if (IsSafe(maze, row - 1, col))
    {
        FindAllPaths(maze, row - 1, col, path + "U");
    }
    if (IsSafe(maze, row, col + 1))
    {
        FindAllPaths(maze, row, col + 1, path + "R");
    }
    if (IsSafe(maze, row, col - 1))
    {
        FindAllPaths(maze, row, col - 1, path + "L");
    }

    maze[row, col] = '-';
}

bool IsSafe(char[,] maze, int row, int col)
{
    if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
    {
        return false;
    }
    if (maze[row,col] == '*' || maze[row,col] == 'v')
    {
        return false;
    }

    return true;
}


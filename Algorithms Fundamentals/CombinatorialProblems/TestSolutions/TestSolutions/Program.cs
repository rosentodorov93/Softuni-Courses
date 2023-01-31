//var input = Console.ReadLine().Split().Select(int.Parse).ToArray();


int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < n; row++)
{
    int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = currentRow[col];
    }

}

solution(matrix);



void solution(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(0)];

    for (int row = 0; row < result.GetLength(0); row++)
    {
        int count = 0;
        for (int col = 0; col < result.GetLength(1); col++)
        {
            result[col, (matrix.GetLength(1) - 1) - row] = matrix[row, col];
        }
    }

    Print(result);
}

void Print(int[,] result)
{
    for (int row = 0; row < result.GetLength(0); row++)
    {
        for (int col = 0; col < result.GetLength(1); col++)
        {
            Console.Write(result[row,col] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
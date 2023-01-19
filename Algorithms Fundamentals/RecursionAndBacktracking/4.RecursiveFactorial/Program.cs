int n = int.Parse(Console.ReadLine());

Console.WriteLine(RecursiveFactorial(n));

int RecursiveFactorial(int n)
{
    if (n == 0)
    {
        return 1;
    }

    return n * RecursiveFactorial(n-1);
}
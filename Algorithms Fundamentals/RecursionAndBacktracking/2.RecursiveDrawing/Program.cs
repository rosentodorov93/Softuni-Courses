int n = int.Parse(Console.ReadLine());

RecursiveDraw(n);

void RecursiveDraw(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.WriteLine(new String('*',n));
    RecursiveDraw(n-1);
    Console.WriteLine(new String('#',n));
}
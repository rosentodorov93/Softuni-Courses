int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

GenerateVectors(array, 0);


void GenerateVectors(int[] array, int index)
{
    if (index >= array.Length)
    {
        Console.WriteLine(String.Join(" ", array));
        return;
    }
    for (int i = 0; i < 2; i++)
    {
        array[index] = i;
        GenerateVectors(array, index + 1);
    }
}
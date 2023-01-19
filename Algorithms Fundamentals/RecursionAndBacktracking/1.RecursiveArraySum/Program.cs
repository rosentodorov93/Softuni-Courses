
int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine(RecursiveSum(inputArray, 0));

int RecursiveSum(int[] inputArray, int index)
{
    if (index == inputArray.Length)
    {
        return 0;
    }

    return inputArray[index] + RecursiveSum(inputArray, index + 1);
}
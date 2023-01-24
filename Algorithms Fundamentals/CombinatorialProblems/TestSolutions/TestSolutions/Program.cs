var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Reverse(input, 0);

void Reverse(int[] input, int n)
{
    if (n >= input.Length)
    {
        return;
    }
    Reverse(input, n + 1);
    Console.Write(input[n] + " ");
}

int solution(int[] inputArray)
{
    int maxProduct = int.MinValue;
    int currentProduct = int.MinValue;

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        currentProduct = inputArray[i] * inputArray[i + 1];
        if (currentProduct > maxProduct)
        {
            maxProduct = currentProduct;
        }
    }

    return maxProduct;
}

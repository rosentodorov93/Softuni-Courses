//var input = Console.ReadLine().Split().Select(int.Parse).ToArray();


int[] a = new int[6] { 1,  2, 3, 4, 3, 6 };

solution(a);


bool solution(int[] sequence)
{
    int left = 0;
    int right = sequence.Length - 1;
    bool result = true;
    while (true)
    {
        if (left + 1 == right)
        {
            if (left + 2 > sequence.Length - 1 || sequence[left + 2] > sequence[left])
            {
                break;
            }
            if (left - 1 >= 0 && sequence[left - 1] >= sequence[right])
            {
                result = false;
            }
            break;
        }
        if (sequence[left + 1] <= sequence[left] && sequence[right - 1] >= sequence[right])
        {
            result = false;
            break;
        }

        if (sequence[left + 1] > sequence[left])
        {
            left++;
        }
        if (sequence[right - 1] < sequence[right])
        {
            right--;
        }
    }
    return result;
}
//var input = Console.ReadLine().Split().Select(int.Parse).ToArray();


int[] array = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };


Console.WriteLine(string.Join(" ", DailyTemperatures(array)));


int FindMin(int[] nums)
{
    if (nums.Length == 1)
    {
        return 1;
    }

    int left = 0;
    int right = nums.Length - 1;
    int min = int.MaxValue;

    while (left <= right)
    {
        if (nums[left] < nums[right])
        {
            min = Math.Min(nums[left], min);
            break;
        }

        int middle = (left + right) / 2;

        min = Math.Min(nums[middle], min);

        if (nums[left] <= nums[middle])
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }

    }

    return min;
}


 int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
    {
        return 0;
    }

    Array.Sort(nums);
    int count = 1;
    int maxCount = 1;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] + 1 == nums[i + 1])
        {
            count++;
            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        if (nums[i + 1] > nums[i])
        {
            count = 1;
        }
    }
    return maxCount;
}

 int[] DailyTemperatures(int[] temperatures)
{
    int[] result = new int[temperatures.Length];

    for (int i = 0; i < temperatures.Length - 1; i++)
    {
        int pointer = i + 1;
        int count = 1;

        while (temperatures[pointer] <= temperatures[i])
        {
            count++;
            pointer++;

            if (pointer >= temperatures.Length)
            {
                count = 0;
                break;
            }
        }

        result[i] = count;
    }

    return result;
}

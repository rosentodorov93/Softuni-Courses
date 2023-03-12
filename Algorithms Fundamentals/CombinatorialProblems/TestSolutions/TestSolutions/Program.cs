int[][] matrix = new int[3][]
{
    new int[] { 1, 3, 5,7 },
    new int[] { 10,11,16,20 },
    new int[] { 23,30,34,60 },
};

Console.WriteLine((int)Math.Ceiling(11.00 / 6));

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
bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    var dic = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        if (!dic.ContainsKey(s[i]))
        {
            dic.Add(s[i], 0);
        }

        dic[s[i]]++;
    }

    for (int i = 0; i < t.Length; i++)
    {
        if (dic.ContainsKey(t[i]) && dic[t[i]] > 1)
        {
            dic[t[i]]--;
        }
        else if (dic.ContainsKey(t[i]) && dic[t[i]] == 1)
        {
            dic.Remove(t[i]);
        }
        else
        {
            return false;
        }
    }

    return dic.Count == 0;
}
IList<IList<string>> GroupAnagrams(string[] strs)
{
    if (strs == null || strs.Length == 0)
    {

        return new List<IList<string>>();
    }

    var map = new Dictionary<string, IList<string>>();

    for (int i = 0; i < strs.Length; i++)
    {
        int[] count = new int[26];

        for (int j = 0; j < strs[i].Length; j++)
        {
            int value = (int)strs[i][j];
            int index = value - 97;
            count[index]++;
        }

        string key = string.Join("#", count);

        if (!map.ContainsKey(key))
        {
            map.Add(key, new List<string>());
        }

        map[key].Add(strs[i]);
    }


    return map.Values.ToList();
}
int[] ProductExceptSelf(int[] nums)
{
    int[] result = new int[nums.Length];
    var leftSums = new List<int>() { 1 };
    int currentSum = 1;

    for (int i = 0; i < nums.Length; i++)
    {

        currentSum *= nums[i];
        leftSums.Add(currentSum);
    }


    int rightSum = 1;
    for (int i = nums.Length - 1; i >= 0; i--)
    {

        result[i] = leftSums[i] * rightSum;
        rightSum *= nums[i];
    }

    return result;
}
bool IsPalindrome(string s)
{

    if (s.Length == 2)
    {
        return s[0] == s[1];
    }
    int left = 0;
    int right = s.Length - 1;

    while (left <= right)
    {

        if (!char.IsLetterOrDigit(s[left]))
        {
            left++;
            if (left == right && char.IsLetterOrDigit(s[left]))
            {
                return true;
            }
            continue;
        }
        if (!char.IsLetterOrDigit(s[right]))
        {
            right--;
            if (left == right && char.IsLetterOrDigit(s[left]))
            {
                return true;
            }
            continue;
        }
        if (char.ToLower(s[left]) != char.ToLower(s[right]))
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}
int[] TwoSum(int[] numbers, int target)
{

    int[] array = new int[2];
    for (int i = 0; i < numbers.Length; i++)
    {

        int secondNumber = target - numbers[i];

        if (secondNumber >= numbers[i])
        {
            int result = BinarySearch(i + 1, numbers.Length - 1, numbers, secondNumber);
            if (result != -1)
            {
                array[0] = i;
                array[1] = result;
            }
        }
        else
        {
            int result = BinarySearch(0, i - 1, numbers, secondNumber);
            if (result != -1)
            {
                array[0] = i;
                array[1] = result;
            }
        }
    }

    return array;
}
int BinarySearch(int start, int end, int[] numbers, int target)
{

    while (start <= end)
    {
        int middle = (start + end) / 2;

        if (numbers[middle] == target)
        {
            return middle;
        }

        if (numbers[middle] > target)
        {
            end = middle - 1;
        }
        else
        {
            start = middle + 1;
        }
    }

    return -1;
}
IList<IList<int>> ThreeSum(int[] nums)
{
    Array.Sort(nums);
    var result = new List<IList<int>>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (i > 0 && nums[i - 1] == nums[i])
        {
            continue;
        }

        int left = i + 1;
        int right = nums.Length - 1;

        while (left <= right)
        {

            int currentSum = nums[i] + nums[left] + nums[right];
            if (currentSum == 0)
            {
                var set = new List<int>() { nums[i], nums[left], nums[right] };

                result.Add(set);

                left++;

                while (nums[left] == nums[left - 1] && left < right)
                {
                    left++;
                }

            }
            if (currentSum > 0)
            {
                right--;
            }
            if (currentSum < 0)
            {
                left++;
            }
        }
    }

    return result;
}
int LengthOfLongestSubstring(string s)
{

    if (s == null || s.Length == 0)
    {
        return 0;
    }

    var visited = new HashSet<char>();
    int maxSubstring = 0;
    int l = 0;

    for (int r = 0; r < s.Length; r++)
    {
        while (visited.Contains(s[r]))
        {
            visited.Remove(s[l++]);

        }

        visited.Add(s[r]);
        maxSubstring = Math.Max(maxSubstring, r - l + 1);

    }

    return maxSubstring;
}
int CharacterReplacement(string s, int k)
{
    int l = 0;
    char[] chars = new char[26];
    int maxCount = 0;
    int result = 0;

    for (int r = 0; r < s.Length; r++)
    {

        chars[s[r] - 'A']++;
        int currentCharCount = chars[s[r] - 'A'];
        maxCount = Math.Max(maxCount, currentCharCount);

        while (r - l - maxCount + 1 > k)
        {
            chars[s[l] - 'A']--;
            l++;
        }

        result = Math.Max(result, r - l + 1);
    }

    return result;
}
bool CheckInclusion(string s1, string s2)
{
    if (s1.Length > s2.Length)
    {
        return false;
    }

    var s1Map = new char[26];
    var s2Map = new char[26];

    for (int i = 0; i < s1.Length; i++)
    {
        s1Map[s1[i] - 'a']++;
        s2Map[s2[i] - 'a']++;
    }

    int matches = 0;

    for (int i = 0; i < 26; i++)
    {

        if (s1Map[i] == s2Map[i])
        {
            matches++;
        }
    }

    int l = 0;

    for (int i = s1.Length; i < s2.Length; i++)
    {

        if (matches == 26)
        {
            return true;
        }

        int index = s2[i] - 'a';

        s2Map[index]++;

        if (s1Map[index] == s2Map[index])
        {
            matches++;
        }
        else if (s1Map[index] + 1 == s2Map[index])
        {
            matches--;
        }

        s2Map[l]--;
        if (s1Map[l] == s2Map[l])
        {
            matches++;
        }
        else if (s1Map[l] - 1 == s2Map[l])
        {
            matches--;
        }
        l++;
    }
    return matches == 26;
}
bool SearchMatrix(int[][] matrix, int target)
{
    int rowStart = 0;
    int rowEnd = matrix.GetLength(0);
    int rowIndex = 0;
    while (rowStart <= rowEnd)
    {
        int middle = (rowEnd - rowStart) / 2;

        if (matrix[middle][0] < target && matrix[middle + 1][0] > target)
        {
            rowIndex = middle;
            break;
        }

        if (matrix[middle][0] > target)
        {
            rowEnd = middle - 1;
        }
        else
        {
            rowStart = middle + 1;
        }
    }

    int l = 0;
    int r = matrix[rowIndex].Length - 1;

    while (l <= r)
    {
        int middle = (r - l) / 2;

        if (matrix[rowIndex][middle] == target)
        {
            return true;
        }

        if (matrix[rowIndex][middle] > target)
        {
            r = middle - 1;
        }
        else
        {
            l = middle + 1;
        }
    }

    return false;
}

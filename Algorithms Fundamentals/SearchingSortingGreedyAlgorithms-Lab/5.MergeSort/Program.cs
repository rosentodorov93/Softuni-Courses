namespace _5.MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sortedArray = MergeSort(array);

            Console.WriteLine(String.Join(" ", sortedArray));
        }

        private static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] leftArray = array.Take(array.Length / 2).ToArray();
            int[] rightArray = array.Skip(array.Length / 2).ToArray();

            return Merge(MergeSort(leftArray), MergeSort(rightArray));
        }

        private static int[] Merge(int[] leftArr, int[] rightArr)
        {
            int[] resultArr = new int[leftArr.Length + rightArr.Length];

            int left = 0;
            int right = 0;
            int merged = 0;

            while (left < leftArr.Length && right < rightArr.Length)
            {
                if (leftArr[left] < rightArr[right])
                {
                    resultArr[merged++] = leftArr[left++];
                }
                else
                {
                    resultArr[merged++] = rightArr[right++];
                }
            }

            for (int i = left; i < leftArr.Length; i++)
            {
                resultArr[merged++] = leftArr[i];
            }

            for (int i = right; i < rightArr.Length; i++)
            {
                resultArr[merged++] = rightArr[i];
            }

            return resultArr;
        }
    }
}
namespace _4.QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            QuickSort(array, 0 , array.Length - 1);

            Console.WriteLine(String.Join(" ", array));
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = start;
            int left = start + 1;
            int right = end;

            while (left <= right)
            {
                if (array[left] > array[pivot] && array[right] < array[pivot])
                {
                    Swap(array, left, right);
                }
                if (array[left] <= array[pivot])
                {
                    left++;
                }
                if(array[right] >= array[pivot])
                {
                    right--;
                }
            }

            Swap(array, pivot, right);

            bool isLeftSmaller = right - 1 - start < end - (right + 1);

            if (isLeftSmaller)
            {
                QuickSort(array, start, right - 1);
                QuickSort(array, right + 1, end);
            }
            else
            {
                QuickSort(array, right + 1, end);
                QuickSort(array, start, right - 1);
            }
            
        }

        private static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
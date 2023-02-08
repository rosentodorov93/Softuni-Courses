namespace _6.BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, target));
        }

        private static int BinarySearch(int[] array, int target)
        {

            int middle = 0;
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (array[middle] == target)
                {
                    return middle;
                }

                if (array[middle] < target)
                {
                    left = middle + 1;
                }

                if (array[middle] > target)
                {
                    right = middle - 1;
                }
            }

            return - 1;
        }
    }
}
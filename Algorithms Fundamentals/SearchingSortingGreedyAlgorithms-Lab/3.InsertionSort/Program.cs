namespace _3.InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            InsertionSort(array);

            Console.WriteLine(String.Join(" ", array));
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int index = i;

                while(index > 0 && array[index] < array[index - 1])
                {
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;

                    index--;
                }

            }
        }
    }
}
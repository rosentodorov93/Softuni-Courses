using System;
using System.Linq;

namespace _1.SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort(array);

            Console.WriteLine(String.Join(" ", array));

        }

        private static void SelectionSort(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;

                for (int j = index + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                       minIndex = j;
                    }
                }

                if (array[minIndex] < array[index])
                {
                    int temp = array[index];
                    array[index] = array[minIndex];
                    array[minIndex] = temp;
                }

            }
        }
    }
}
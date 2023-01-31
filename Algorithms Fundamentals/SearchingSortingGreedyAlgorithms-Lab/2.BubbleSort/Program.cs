using System;
using System.Linq;

namespace _2.BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(array);

            Console.WriteLine(String.Join(" ", array));
        }

        private static void BubbleSort(int[] array)
        {
            int sortedCount = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < (array.Length - 1) - sortedCount; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

                sortedCount++;
            }
        }
    }
}
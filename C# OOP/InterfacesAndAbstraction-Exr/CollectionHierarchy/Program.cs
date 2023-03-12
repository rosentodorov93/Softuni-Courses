using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] inputAdd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            List<int> AddCollectionResult = new List<int>();
            List<int> AddRemCollectionResult = new List<int>();
            List<int> myListResult = new List<int>();

            foreach (var item in inputAdd)
            {
                AddCollectionResult.Add(addCollection.Add(item));
                AddRemCollectionResult.Add(addRemoveCollection.Add(item));
                myListResult.Add(myList.Add(item));
            }
            List<string> addRemoveElements = new List<string>();
            List<string> myListRemoveElements = new List<string>();
            for (int i = 0; i < n; i++)
            {
                addRemoveElements.Add(addRemoveCollection.Remove());
                myListRemoveElements.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", AddCollectionResult));
            Console.WriteLine(string.Join(" ", AddRemCollectionResult));
            Console.WriteLine(string.Join(" ", myListResult));
            Console.WriteLine(string.Join(" ", addRemoveElements));
            Console.WriteLine(string.Join(" ", myListRemoveElements));

        }
    }
}

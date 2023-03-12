using CollectionHierarchy.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IRemovable
    {
        private List<string> collection;
        public AddRemoveCollection()
        {
            collection = new List<string>();
        }
        public IReadOnlyCollection<string> Collection => collection;
        public int Add(string element)
        {
            collection.Insert(0, element);
            return collection.IndexOf(element);
        }

        public string Remove()
        {
            string element = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            return element;
        }
    }
}

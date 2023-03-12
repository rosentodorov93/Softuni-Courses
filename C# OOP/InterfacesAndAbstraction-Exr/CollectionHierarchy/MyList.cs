using CollectionHierarchy.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IUsable
    {
        private List<string> collection;
        public MyList()
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
            string element = collection[0];
            collection.RemoveAt(0);
            return element;
        }

        public int Used()
        {
            return collection.Count;
        }
    }
}

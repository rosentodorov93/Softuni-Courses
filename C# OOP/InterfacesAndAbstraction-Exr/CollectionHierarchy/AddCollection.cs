using CollectionHierarchy.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAddable
    {
        private List<string> collection;
        public AddCollection()
        {
            collection = new List<string>();
        }
        public IReadOnlyCollection<string> Collection => collection;
        public int Add(string element)
        {
            collection.Add(element);
            return Collection.Count - 1;
        }
    }
}

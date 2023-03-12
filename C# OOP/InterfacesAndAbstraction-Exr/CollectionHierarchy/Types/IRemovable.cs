using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Types
{
    public interface IRemovable : IAddable
    {
        public string Remove();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Types
{
    interface IUsable : IRemovable
    {
        public int Used();
    }
}

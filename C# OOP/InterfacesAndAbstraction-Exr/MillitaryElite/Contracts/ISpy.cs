using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface ISpy : ISoldier
    {
        public int CodeNumber { get;}
    }
}

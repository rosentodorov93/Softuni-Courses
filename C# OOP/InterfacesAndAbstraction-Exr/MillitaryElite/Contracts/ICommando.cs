using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        public IReadOnlyCollection<IMissions> Missions { get;}
        public void Add(IMissions mission);
       
    }
}

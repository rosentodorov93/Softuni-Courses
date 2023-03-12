using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public IReadOnlyCollection<IRepairs> Repairs{ get;}
        public void Add(IRepairs repair);
    }
}

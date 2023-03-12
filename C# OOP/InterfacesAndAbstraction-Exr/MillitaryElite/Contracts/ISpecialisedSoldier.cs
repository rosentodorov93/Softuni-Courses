using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get;}
    }
}

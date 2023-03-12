using MillitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        public IReadOnlyCollection<IPrivate> Set { get;}
        public void Add(IPrivate @private);
    }
}

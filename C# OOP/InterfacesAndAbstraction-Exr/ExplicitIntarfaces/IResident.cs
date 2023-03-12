using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitIntarfaces
{
    public interface IResident
    {
        public string Name { get;}
        public string Country { get; }
        string GetName();
    }
}

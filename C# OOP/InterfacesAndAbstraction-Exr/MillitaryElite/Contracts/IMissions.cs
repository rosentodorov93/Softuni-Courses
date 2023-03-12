using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface IMissions
    {
        public string CodeName { get;}
        public State State { get;}

        public void CompleteMission();
    }
}

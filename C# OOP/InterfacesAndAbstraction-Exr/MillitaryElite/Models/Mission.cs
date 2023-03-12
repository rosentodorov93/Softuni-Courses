using MillitaryElite.Contracts;
using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Models
{
    public class Mission : IMissions
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; }
        public State State { get; private set; }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}

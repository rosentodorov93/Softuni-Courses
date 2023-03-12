using MillitaryElite.Contracts;
using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps{ get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            return sb.ToString().TrimEnd();
        }
    }
}

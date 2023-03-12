using MillitaryElite.Contracts;
using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepairs> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepairs>();
        }

        public IReadOnlyCollection<IRepairs> Repairs => repairs.AsReadOnly();

        public void Add(IRepairs repair)
        {
            repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in repairs)
            {
                sb.AppendLine(" " + repair.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

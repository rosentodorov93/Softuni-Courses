using MillitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MillitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> set;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            set = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Set => set.AsReadOnly();

        public void Add(IPrivate @private)
        {
            set.Add(@private);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in this.set)
            {
                sb.AppendLine("  " + currentPrivate.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}

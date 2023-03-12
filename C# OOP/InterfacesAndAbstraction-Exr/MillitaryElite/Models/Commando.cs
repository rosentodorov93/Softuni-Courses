using MillitaryElite.Contracts;
using MillitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMissions> mission;
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.mission = new List<IMissions>();
        }

        public IReadOnlyCollection<IMissions> Missions => mission.AsReadOnly();

        public void Add(IMissions mission)
        {
            this.mission.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());           
            sb.AppendLine("Missions:");

            foreach (var currentMission in this.mission)
            {
                sb.AppendLine("  " + currentMission.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}

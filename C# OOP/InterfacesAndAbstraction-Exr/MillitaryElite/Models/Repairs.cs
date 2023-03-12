using MillitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Models
{
    public class Repairs : IRepairs
    {
        public Repairs(string partName, int workedHours)
        {
            PartName = partName;
            WorkedHours = workedHours;
        }

        public string PartName { get;}

        public int WorkedHours { get;}
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {WorkedHours}";
        }
    }
}

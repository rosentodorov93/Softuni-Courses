using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) 
            : base(name)
        {
            Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {Name} healed for {Power}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Tiger : Feline
    {
        private const double BaseModifier = 1.00;
        private static HashSet<string> tigerFood = new HashSet<string>
        {
            nameof(Meat),           

        };
        public Tiger(string name, double weight, 
             string region, string breed) 
            : base(name, weight, tigerFood, BaseModifier, region, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}

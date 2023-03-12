using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Dog : Mammal
    {
        private const double BaseModifier = 0.40;
        private static HashSet<string> dogFood = new HashSet<string>
        {
            nameof(Meat)
            
        };
        public Dog(string name, double weight, string region)
            : base(name, weight, dogFood, BaseModifier, region)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}

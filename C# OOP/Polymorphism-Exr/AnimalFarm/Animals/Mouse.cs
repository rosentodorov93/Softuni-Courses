using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double BaseModifier = 0.1;
        private static HashSet<string> miceFood = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(string name, double weight, string region)
            : base(name, weight, miceFood, BaseModifier, region)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}

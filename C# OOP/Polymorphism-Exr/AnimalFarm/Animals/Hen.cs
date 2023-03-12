using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Hen : Bird
    {
        private const double BaseModifier = 0.35;
        private static HashSet<string> henFood = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Seeds),
            nameof(Fruit)
        };
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, henFood, BaseModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}

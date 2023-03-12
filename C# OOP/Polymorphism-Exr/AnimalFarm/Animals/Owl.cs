using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Owl : Bird
    {
        private const double BaseModifier = 0.25;
        private static HashSet<string> owlFood = new HashSet<string>
        {
            nameof(Meat),

        };
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, owlFood, BaseModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}

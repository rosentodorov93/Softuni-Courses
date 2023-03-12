using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public class Cat : Feline
    {
        private const double BaseModifier = 0.30;
        private static HashSet<string> catFood = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable)

        };
        public Cat(string name, double weight, 
             string region, string breed) 
            : base(name, weight, catFood, BaseModifier, region, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

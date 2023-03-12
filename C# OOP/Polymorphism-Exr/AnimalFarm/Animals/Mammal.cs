using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, HashSet<string> allowedFood, double modifier,string region)
            : base(name, weight, allowedFood, modifier)
        {
            LivingRegion = region;
        }

        public string LivingRegion { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

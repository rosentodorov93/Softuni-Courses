using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight,
            HashSet<string> allowedFood, double modifier, string region, string breed) 
            : base(name, weight, allowedFood, modifier, region)
        {
            Breed = breed;
        }

        public string Breed { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

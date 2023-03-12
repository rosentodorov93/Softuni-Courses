using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight ,HashSet<string> allowedFood, double modifier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFood;
            FoodModifier = modifier;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public HashSet<string> AllowedFoods { get; private set; }
        public double FoodModifier { get; private set; }

        public abstract string ProduceSound();
      
        public virtual void FeedAnimal(Food food)
        {
            if (!AllowedFoods.Contains(food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * FoodModifier;
        }
    }
}

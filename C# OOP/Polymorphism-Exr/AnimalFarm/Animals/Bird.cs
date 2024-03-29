﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, HashSet<string> allowedFood, double modifier,double wingSize) 
            : base(name, weight, allowedFood, modifier)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}

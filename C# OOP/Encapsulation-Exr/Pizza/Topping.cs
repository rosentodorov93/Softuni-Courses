using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Topping
    {
        private const double defaultCaloriesPerGram = 2;
        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (value == "meat" || value == "veggies" || value == "cheese" || value == "sauce")
                {
                    type = value;
                }
                else
                {
                    string valueName = value[0].ToString().ToUpper() + value.Substring(1);
                    throw new ArgumentException($"Cannot place {valueName} on top of your pizza.");
                }
            }
        }

        public double Grams
        {
            get => grams;
            private set
            {
                if (value > 0 && value <= 50)
                {
                    grams = value;
                }
                else
                {
                    var name = Type[0].ToString().ToUpper() + Type.Substring(1);
                    throw new ArgumentException($"{name} weight should be in the range [1..50].");
                }
            }
        }
        public double CaloriesPerGram => GetToppingCaloriesPerGram();
        private double GetToppingCaloriesPerGram()
        {
            return  (defaultCaloriesPerGram * Grams) * Modifier();
        }
        private double Modifier()
        {
            double modifier = 0;
            if (Type == "meat")
            {
                modifier = 1.2;
            }
            else if (Type == "veggies")
            {
                modifier = 0.8;
            }
            else if (Type == "cheese")
            {
                modifier = 1.1;
            }
            else if (Type == "sauce")
            {
                modifier = 0.9;
            }
            return modifier;
        }
    }
}

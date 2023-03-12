using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Pizza
    {
        private string name;

        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();
        }

        private Dough pizzaDough;
        private List<Topping> toppings;

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length > 0 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public Dough PizzaDough { get => pizzaDough; set => pizzaDough = value; }
        public List<Topping> Toppings { get => toppings; set => toppings = value; }
        public int ToppingCount
        {
            get
            {
                
                return toppings.Count;
            }

        }

        public double TotalCalories => GetTotalCalories();

        
        public void AddTopping(Topping toping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(toping);
        }
        private double GetTotalCalories()
        {
            double result = 0;
            result += pizzaDough.CaloriesPerGram;
            foreach (var topping in toppings)
            {
                result += topping.CaloriesPerGram;
            }
            return result;
        }
    }
}

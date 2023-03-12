using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                string[] command = Console.ReadLine().Split();
                string pizzaName = command[1];
                Pizza pizza = new Pizza(pizzaName);

                string[] doughData = Console.ReadLine().Split();
                string doughType = doughData[1].ToLower();
                string doughBaiking = doughData[2].ToLower();
                int doughGrams = int.Parse(doughData[3]);
                Dough dough = new Dough(doughType,doughBaiking,doughGrams);
                pizza.PizzaDough = dough;

                string toppingCommand = Console.ReadLine();
                while (toppingCommand != "END")
                {
                    string[] data = toppingCommand.Split();
                    string type = data[1].ToLower();
                    int grams = int.Parse(data[2]);
                    Topping currentTopping = new Topping(type, grams);
                    pizza.AddTopping(currentTopping);


                    toppingCommand = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

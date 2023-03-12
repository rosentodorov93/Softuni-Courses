using AnimalFarm.Animals;
using System;
using System.Collections.Generic;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] animalData = input.Split();

                Animal animal = CreateAnimal(animalData);

                string[] foodData = Console.ReadLine().Split();

                Food food = CreateFood(foodData);

                Console.WriteLine(animal.ProduceSound());

                animals.Add(animal);
                try
                {
                    animal.FeedAnimal(food);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodData)
        {
            string type = foodData[0];
            int quantity = int.Parse(foodData[1]);
            Food food = null;
            if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            return food;
        }

        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];
            string name = parts[1];
            double weight = double.Parse(parts[2]);

            Animal animal = null;

            if (type == "Owl")
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == "Dog")
            {
                string region = parts[3];
                animal = new Dog(name, weight, region);
            }
            else if (type == "Mouse")
            {
                string region = parts[3];
                animal = new Mouse(name, weight, region);
            }
            else if (type == "Cat")
            {
                string region = parts[3];
                string breed = parts[4];
                animal = new Cat(name, weight, region, breed);
            }
            else if (type == "Tiger")
            {
                string region = parts[3];
                string breed = parts[4];
                animal = new Tiger(name, weight, region, breed);
            }

            return animal;
        }
    }
}

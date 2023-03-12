using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(carData[1]);
            double fuelConsuption = double.Parse(carData[2]);
            double capcity = double.Parse(carData[3]);
            Car car = new Car(fuelQuantity, fuelConsuption,capcity);

            string[] truckData = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckData[1]);
            double truckFuelConsuption = double.Parse(truckData[2]);
            double truckCapacity = double.Parse(truckData[3]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsuption,truckCapacity);

            string[] busData = Console.ReadLine().Split();
            double busFuelQuantity = double.Parse(busData[1]);
            double busFuelConsuption = double.Parse(busData[2]);
            double busCapacity = double.Parse(busData[3]);
            Bus bus = new Bus(busFuelQuantity, busFuelConsuption, busCapacity);

            Vehicle vehicle = null;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                if (parts[1] == "Car")
                {
                    vehicle = car;
                }
                else if (parts[1] == "Truck")
                {
                    vehicle = truck;
                }
                else if (parts[1] == "Bus")
                {
                    vehicle = bus;
                }
                
                if (parts[0] == "Drive")
                {
                    vehicle.Drive(double.Parse(parts[2]));
                }
                else if (parts[0] == "DriveEmpty" && vehicle is Bus)
                {
                    ((Bus)vehicle).DriveEmpty(double.Parse(parts[2]));
                }
                else
                {
                    vehicle.Refuel(double.Parse(parts[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsuption, double tankCapacity) 
            : base(fuelQuantity, fuelConsuption, tankCapacity)
        {
            Factor = 1.4;
        }

        public override void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + amount > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                return;
            }
            FuelQuantity += amount;
        }
        public void DriveEmpty(double distance)
        {
            double fuelNeeded = distance * FuelConsuptionPerKm;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
    }
}

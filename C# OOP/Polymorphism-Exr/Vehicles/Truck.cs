using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsuption,double tankCapacity) 
            : base(fuelQuantity, fuelConsuption,tankCapacity)
        {
            Factor = 1.6;
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
            FuelQuantity += amount * 0.95;
        }
    }
}

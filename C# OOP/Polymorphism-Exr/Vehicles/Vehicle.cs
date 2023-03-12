using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
       
        protected Vehicle(double fuelQuantity, double fuelConsuption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsuptionPerKm = fuelConsuption;
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                
                fuelQuantity = value;
            } 
        }
        public double FuelConsuptionPerKm { get; set; }
        public double Factor { get; set; }
        public double TankCapacity { get; set; }

        public virtual void Drive(double distance)
        {
            double fuelNeeded = distance * (FuelConsuptionPerKm + Factor);
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
        public abstract void Refuel(double amount);
    }
}

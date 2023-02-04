using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model { get { return model; } set { model=value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer;} set { fuelConsumptionPerKilometer= value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance= value; } }

        public void Drive(Car car,double movedKm)
        {
            if(movedKm*FuelConsumptionPerKilometer<=FuelAmount)
            {
                car.TravelledDistance += movedKm;
                car.FuelAmount -= movedKm * fuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}

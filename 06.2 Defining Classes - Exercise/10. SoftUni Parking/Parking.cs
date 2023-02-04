using SoftUniParking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car>cars= new List<Car>();
        private int capacity;

        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }
        public List<Car> Cars { get; set;}
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return cars.Count; } }

        public string AddCar(Car car) 
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if(cars.Count==capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }    
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (cars.Any(x => x.RegistrationNumber == RegistrationNumber))
            {
                Car currCar=cars.First(x => x.RegistrationNumber==RegistrationNumber);
                cars.Remove(currCar);
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
               return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string RegistrationNumber)
        {
            Car currCar = cars.First(x => x.RegistrationNumber == RegistrationNumber);
            return currCar;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var rn in RegistrationNumbers)
            {
                if (cars.Any(x => x.RegistrationNumber == rn))
                {
                    cars.RemoveAll(x=>x.RegistrationNumber== rn);
                }
            }
        }
    }
}

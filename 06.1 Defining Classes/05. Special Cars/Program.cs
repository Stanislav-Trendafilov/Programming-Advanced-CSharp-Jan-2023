using System.Data;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {

            List<Tire[]>tires= new List<Tire[]>();  
            List<Engine>engines= new List<Engine>();
            List<Car>cars=new List<Car>();
            string command=Console.ReadLine();
            while (command != "No more tires")
            {
                string[]info=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var currentTires = new Tire[4]
                {
                new Tire(int.Parse(info[0]),double.Parse(info[1])),
                new Tire(int.Parse(info[2]),double.Parse(info[3])),
                new Tire(int.Parse(info[4]),double.Parse(info[5])),
                new Tire(int.Parse(info[6]),double.Parse(info[7]))
                };
                tires.Add(currentTires);
                command=Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] engineInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currEngine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));
                engines.Add(currEngine);
                command = Console.ReadLine();
            }
            command=Console.ReadLine();
            while (command != "Show special")
            {
                string[] carInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int tireIndex = int.Parse(carInfo[5]);
                int engineIndex = int.Parse(carInfo[6]);
                Car currCar = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), double.Parse(carInfo[3]), double.Parse(carInfo[4]), engines[engineIndex], tires[tireIndex]);
                cars.Add(currCar);
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                if(car.Year<2017)
                {
                    continue;
                }
                if(car.Engine.HorsePower <= 330)
                {
                    continue;
                }
                double currTirePressureSum = 0;
                foreach (var tire in car.Tires)
                {
                    currTirePressureSum += tire.Pressure;
                }
                if (currTirePressureSum < 9 || currTirePressureSum > 10)
                {
                    continue;
                }
                car.Drive(0.2);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}



using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            List<Car>cars= new List<Car>();
            Dictionary<string,Car>listCars= new Dictionary<string,Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car car = new Car
                {
                    Model = carInfo[0],
                    FuelAmount = double.Parse(carInfo[1]),
                    FuelConsumptionPerKilometer = double.Parse(carInfo[2]),
                    TravelledDistance = 0
                };
                listCars.Add(car.Model,car);
                cars.Add(car);
            }
            string command=string.Empty;

            while((command=Console.ReadLine())!= "End")
            {
                string[] tokens = command.Split(" ");
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                Car currentCar = listCars[carModel];
                currentCar.Drive(currentCar,amountOfKm);           
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}

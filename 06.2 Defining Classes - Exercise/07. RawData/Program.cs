

using DefiningClasses;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int count=int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInfo[0], int.Parse(carInfo[1]), int.Parse(carInfo[2]), int.Parse(carInfo[3]), carInfo[4]
                    , double.Parse(carInfo[5]), int.Parse(carInfo[6]), double.Parse(carInfo[7]), int.Parse(carInfo[8])
                    , double.Parse(carInfo[9]), int.Parse(carInfo[10]), double.Parse(carInfo[11]), int.Parse(carInfo[12]));
                cars.Add(car);
            }
            string command=Console.ReadLine();
            List<Car> special=new List<Car>();
            List<string> specialModels = new List<string>();
            if (command=="fragile")
            {

                foreach (var car in cars)
                {
                    bool haveAnyTire = false;
                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure<1)
                        {
                            haveAnyTire = true;
                            break;
                        }
                    }
                    if (haveAnyTire)
                    {
                        special.Add(car);
                    }

                }
                specialModels = special
                    .Where(c => c.Cargo.Type == "fragile")
                    .Select(c => c.Model)
                    .ToList();            
            }
            else
            {
                specialModels = cars
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power>250)
                    .Select(c => c.Model)
                    .ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, specialModels));
        }
    }
}

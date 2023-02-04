

using DefiningClasses;


namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement = 0;
                    string efficiency = string.Empty;
                    bool wasParsed = int.TryParse(engineInfo[2], out displacement);
                    if (!wasParsed)
                    {
                        efficiency = engineInfo[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                    else
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }
            int m=int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                Engine engine = engines.First(e => e.Model == carInfo[1]);

                if (carInfo.Length == 4)
                {
                    cars.Add(new Car(model, engine, int.Parse(carInfo[2]), carInfo[3]));
                }
                else if (carInfo.Length == 3)
                {
                    int weight = 0;
                    string color = string.Empty;
                    bool wasParsed = int.TryParse(carInfo[2], out weight);
                    if (wasParsed)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        color = carInfo[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }
    }
}

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "MB";
            car.Model = "X3";
            car.Year = 1993;
            car.FuelQuantity = 200;
            car.FuelConsumption = 2;
            car.Drive(20);
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}

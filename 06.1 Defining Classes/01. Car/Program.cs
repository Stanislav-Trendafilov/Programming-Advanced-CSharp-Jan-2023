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

            Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
        }
    }
}

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(2,2),
                new Tire(3,3.5),
                new Tire(4,4.5)
            };
            var engine = new Engine(200, 250);

            var car= new Car("lamvo","aventa",12,23,34,engine,tires);
        }
    }
}

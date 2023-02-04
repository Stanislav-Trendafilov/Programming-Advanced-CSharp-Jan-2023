namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();
            Console.WriteLine($"{person.Age} {person.Name}");
        }
    }

}

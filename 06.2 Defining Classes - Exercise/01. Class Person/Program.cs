namespace DefiningClasses
{ 
    public class StartUp
    {
        static void Main()
        {
            Person person= new Person();
            person.Age = 10;
            person.Name= "Test";
            Console.WriteLine($"{person.Age} {person.Name}");
        }
    }

}


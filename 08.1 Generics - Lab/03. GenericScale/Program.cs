namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> check = new EqualityScale<int>(5, 5);
            Console.WriteLine(check.AreEqual());
        }
    }
}


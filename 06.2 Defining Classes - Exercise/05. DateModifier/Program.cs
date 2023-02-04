using _05._DateModifier;
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string date1=Console.ReadLine();
            string date2= Console.ReadLine();
            DateModifier a=new DateModifier();
            Console.WriteLine(a.TimeSpan(date1,date2));
        }
    }
}

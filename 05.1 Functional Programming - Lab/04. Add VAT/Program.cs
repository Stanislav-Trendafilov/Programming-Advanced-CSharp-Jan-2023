using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double,double>Vat= x => x+1/5*x;
            double[]nums=Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(Vat)
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,nums.Select(x=> $"{x:F2}")));
        }
    }
}

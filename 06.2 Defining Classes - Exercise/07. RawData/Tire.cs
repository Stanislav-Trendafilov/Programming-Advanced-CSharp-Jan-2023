using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Tire
    {
        private double pressure;
        private int years;

        public double Pressure { get { return pressure; } set { pressure = value; } }
        public int Years { get { return years; } set { years = value; } }
    }
}

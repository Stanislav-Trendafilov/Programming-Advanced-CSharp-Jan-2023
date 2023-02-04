using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Element { get { return element; } set { element = value; } }
        public int Health { get { return health; } set { health = value; } }
    }
}

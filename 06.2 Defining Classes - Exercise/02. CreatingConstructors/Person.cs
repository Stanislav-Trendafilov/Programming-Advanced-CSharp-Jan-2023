using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private int age;
        private string name;
        public Person()
        {
            age = 1;
            name = "No name";
        }

        public Person(int age) : this()
        {
            this.age = age;
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }

    }
}

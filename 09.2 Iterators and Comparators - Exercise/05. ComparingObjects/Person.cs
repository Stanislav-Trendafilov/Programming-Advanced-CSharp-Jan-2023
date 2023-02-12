using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person:IComparable<Person>
    {
        public int Age{ get; set; }
        public string Name{ get; set; }
        public string Town { get; set; }

        public Person(int age, string name, string town)
        {
            Age = age;
            Name = name;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result != 0) 
            {
                return result;
            }

            result = Age.CompareTo(other.Age);
            if (result!=0)
            {
                return result;
            }
            return Name.CompareTo(other.Name);
               
        }
    }
}

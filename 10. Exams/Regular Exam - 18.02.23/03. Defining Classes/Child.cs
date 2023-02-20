using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKindergarten
{
    public class Child
    {
        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Age = age;
           this.ParentName = parentName;
           this.ContactNumber = contactNumber;
        }

        //•	FirstName – string
        //•	LastName - string
        //•	Age - int
        //•	ParentName – string
        //•	ContactNumber - string
        //The class constructor should receive firstName, lastName, age, parentName, contactNumber.
        //Override the ToString() method in the following format:

        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ParentName { get; set; }
        public string ContactNumber { get; set; }

        public override string ToString()
        {
            return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}";
        }

    }
}

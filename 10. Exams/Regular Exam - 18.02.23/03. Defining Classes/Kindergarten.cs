using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount { get { return Registry.Count; } }
        public bool AddChild(Child child) 
        {
            if (Registry.Count == Capacity)
            {
                return false;
            }
            Registry.Add(child);
            return true;
        }
        public bool RemoveChild(string fullName)
        {
            string[] name = fullName.Split(' ');
            if (Registry.Any(x => x.FirstName == name[0] && x.LastName == name[1]))
            {
                foreach (var child in Registry)
                {
                    if (child.FirstName == name[0] && child.LastName == name[1])
                    {
                        Registry.Remove(child);
                        break;
                    }
                }
                return true;
            }
            return false;

        }
        //•	Method GetChild(string childFullName) – Returns the Child with the given full name. . The childFullName will be a composition
        //of the first name and the last name of the child,
        //separated by a single space. If no child with the given childFullName is found, return null.
        public Child GetChild(string childFullName)
        {
            string[] name = childFullName.Split(' ');
            if (Registry.Any(x => x.FirstName == name[0] && x.LastName == name[1]))
            {
                foreach (var child in Registry)
                {
                    if (child.FirstName == name[0] && child.LastName == name[1])
                    {
                        return child;
                    }
                }
            }
            return null ;
        }
        
        public string RegistryReport()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Registered children in {this.Name}:");
            foreach (var child in Registry.OrderByDescending(x=>x.Age).ThenBy(x=>x.LastName).ThenBy(x=>x.FirstName)) 
            { 
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

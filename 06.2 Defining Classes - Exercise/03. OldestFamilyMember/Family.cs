using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers= new List<Person>();
        public void AddMember(Person member)
        { 
           familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = familyMembers[0].Age;
            Person oldestMember = familyMembers[0];
            foreach (Person member in familyMembers)
            {
                if (maxAge < member.Age)
                {
                    maxAge = member.Age;
                    oldestMember = member;
                }
            }
            return oldestMember;
        }
    }
}

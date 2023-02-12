
using EqualityLogic;

HashSet<Person> hashSet = new();
SortedSet<Person> sortedSet = new();

int n=int.Parse(Console.ReadLine());

for(int i=0;i<n;i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Person person = new Person(int.Parse(tokens[1]), tokens[0]);
    hashSet.Add(person);
    sortedSet.Add(person);
}

Console.WriteLine(hashSet.Count);
Console.WriteLine(sortedSet.Count);
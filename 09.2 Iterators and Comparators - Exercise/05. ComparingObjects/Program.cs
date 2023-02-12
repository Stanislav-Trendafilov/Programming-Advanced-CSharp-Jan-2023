
using ComparingObjects;

List<Person>people= new List<Person>();

string command=string.Empty;
while((command=Console.ReadLine())!="END")
{
    string[]tokens=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    Person person=new Person(int.Parse(tokens[1]), tokens[0], tokens[2]);
    people.Add(person);

}
int nPerson=int.Parse(Console.ReadLine());
int equalToHim = 0;

foreach (var item in people)
{
    if (item.CompareTo(people[nPerson-1])==0)
    {
        equalToHim++;
    }
}
if (equalToHim >1)
{
    Console.WriteLine($"{equalToHim} {people.Count - equalToHim} {people.Count}");
}
else
{
    Console.WriteLine("No matches");
}
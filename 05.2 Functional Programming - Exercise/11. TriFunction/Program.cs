int n=int.Parse(Console.ReadLine());

Func<string, int, bool> filter = (name, num) => name.Sum(x=>x) >= num;

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

foreach (string name in names)
{
    if(filter(name,n))
    {
        Console.WriteLine(name);
        break;
    }
}
using GenericCountMethodStrings;

int n =int.Parse(Console.ReadLine());

GenericCountMethod<string> list = new GenericCountMethod<string>();

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    list.Add(s);
}
string value=Console.ReadLine();
Console.WriteLine(list.Compare(value));
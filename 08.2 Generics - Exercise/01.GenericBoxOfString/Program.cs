
using _01.GenericBoxOfString;

int n=int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    Box<string> box = new Box<string>(s);
    Console.WriteLine(box.ToString());
}
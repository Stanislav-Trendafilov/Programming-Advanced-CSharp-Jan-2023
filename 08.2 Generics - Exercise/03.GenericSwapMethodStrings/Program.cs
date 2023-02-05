
using GenericSwapMethodStrings;

int n=int.Parse(Console.ReadLine());
GenericList<string> list = new GenericList<string>();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    list.Add(s);
}

string[] swap = Console.ReadLine().Split();
int ind1 = int.Parse(swap[0]);
int ind2 = int.Parse(swap[1]);

list.Swap(ind1, ind2);

Console.WriteLine(list.ToString());
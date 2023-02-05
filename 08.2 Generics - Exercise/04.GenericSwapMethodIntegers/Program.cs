
using GenericSwapMethodIntegers;

int n = int.Parse(Console.ReadLine());
GenericList<int> list = new GenericList<int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    list.Add(num);
}

string[] swap = Console.ReadLine().Split();
int ind1 = int.Parse(swap[0]);
int ind2 = int.Parse(swap[1]);

list.Swap(ind1, ind2);

Console.WriteLine(list.ToString());
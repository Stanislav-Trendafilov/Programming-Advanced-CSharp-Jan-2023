using GenericCountMethodDoubles;

int n = int.Parse(Console.ReadLine());

GenericCountMethod<double> list = new GenericCountMethod<double>();

for (int i = 0; i < n; i++)
{
    double num = double.Parse(Console.ReadLine());
    list.Add(num);
}
double value = double.Parse(Console.ReadLine());
Console.WriteLine(list.Compare(value));
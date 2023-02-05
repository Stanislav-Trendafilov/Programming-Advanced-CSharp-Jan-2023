using Tuple;

for (int i = 1; i <= 3; i++)
{
    string[] tokens = Console.ReadLine().Split(" ");
    if (i == 1)
    {
        CustomTuple<string,string> tuple = new CustomTuple<string,string>();
        tuple.Item1 = $"{tokens[0]} {tokens[1]}";
        tuple.Item2 = tokens[2];
        Console.WriteLine(tuple.ToString());
    }
    else if (i == 2)
    {
        CustomTuple<string, int> tuple = new CustomTuple<string, int>();
        tuple.Item1 =tokens[0];
        tuple.Item2 = int.Parse(tokens[1]); ;
        Console.WriteLine(tuple.ToString());
    }
    else if (i == 3)
    {
        CustomTuple<int, double> tuple = new CustomTuple<int, double>();
        tuple.Item1 = int.Parse(tokens[0]);
        tuple.Item2 = double.Parse(tokens[1]);
        Console.WriteLine(tuple.ToString());
    }

}

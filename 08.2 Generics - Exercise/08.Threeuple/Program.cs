using Threeuple;

for (int i = 1; i <= 3; i++)
{
    string[] tokens = Console.ReadLine().Split(" ");
    if (i == 1)
    {
        CustomTuple<string, string,string> tuple = new CustomTuple<string, string,string>();
        tuple.Item1 = $"{tokens[0]} {tokens[1]}";
        tuple.Item2 = tokens[2];
        tuple.Item3= string.Join(" ", tokens.Skip(3));
        Console.WriteLine(tuple.ToString());
    }
    else if (i == 2)
    {
        CustomTuple<string, int,bool> tuple = new CustomTuple<string, int,bool>();
        tuple.Item1 = tokens[0];
        tuple.Item2 = int.Parse(tokens[1]);
        bool drunk = false;
        if (tokens[2]== "drunk")
        {
            drunk = true;
        }
        tuple.Item3= drunk;
        Console.WriteLine(tuple.ToString());
    }
    else if (i == 3)
    {
        CustomTuple<string, double,string> tuple = new CustomTuple<string, double,string>();
        tuple.Item1 = tokens[0];
        tuple.Item2 = double.Parse(tokens[1]);
        tuple.Item3 = tokens[2];
        Console.WriteLine(tuple.ToString());
    }

}

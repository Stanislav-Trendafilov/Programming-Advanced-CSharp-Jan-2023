int[] bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
string evenOrOdd = Console.ReadLine();
Action<int, int, string> evenOrOddNum = (start, end, type) =>
{
    for (int i = start; i <= end; i++)
    {
        if (type == "even" && i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
        else if (type == "odd" && i % 2 != 0)
        {
            Console.Write($"{i} ");
        }
    }
};
evenOrOddNum(bounds[0], bounds[1], evenOrOdd);
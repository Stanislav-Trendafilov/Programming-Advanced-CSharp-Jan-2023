string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
Action<string[]> action = name =>
{
    foreach (var n in name)
    {
        Console.WriteLine($"Sir {n}");
    }
};
action(names);
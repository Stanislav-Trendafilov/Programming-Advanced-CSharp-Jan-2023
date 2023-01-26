int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], string, int[]> func = (num, operation) =>
{
    if (operation == "add")
    { num= num.Select(num => num + 1).ToArray(); }

    else if (operation == "subtract")
    { num= num.Select(num => num - 1).ToArray(); }

    else if (operation == "multiply")
    { num=num.Select(num => num * 2).ToArray(); }

    return num;
};

string command = Console.ReadLine();
while (command != "end")
{
    if (command !="print")
    {
        nums = func(nums, command);
    }
    else
    {
        Console.WriteLine(String.Join(" ", nums));
    }

    command = Console.ReadLine();
}
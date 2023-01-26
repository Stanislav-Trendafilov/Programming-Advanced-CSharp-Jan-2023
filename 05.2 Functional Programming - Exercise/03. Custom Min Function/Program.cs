int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Func<int[], int> minElement = x => x.Min();
Console.WriteLine(minElement(nums));
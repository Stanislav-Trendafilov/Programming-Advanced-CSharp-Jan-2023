
using Froggy;

List<int> nums = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
Lake lake = new(nums);
lake.FindPath();

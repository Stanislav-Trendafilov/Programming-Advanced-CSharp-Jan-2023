Func<int[], int, int[]> function = (nums, num) =>
{
    return nums.Where(n => n % num != 0).Reverse().ToArray();
};
int[] nums1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int num = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(" ", function(nums1, num)));
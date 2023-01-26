Func<int, int[], bool> isDivisible = (num, dividers) =>
{
    foreach (var item in dividers)
    {
        if (num % item != 0)
        { return false; }
    }
    return true;
};
int num = int.Parse(Console.ReadLine());
int[] dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
for (int i = 1; i <= num; i++)
{
    if (isDivisible(i, dividers))
    {
        Console.Write($"{i} ");
    }
}
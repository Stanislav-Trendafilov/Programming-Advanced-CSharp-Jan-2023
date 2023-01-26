Func<string, int, bool> isWithLength = (name, length) => name.Length <= length;
int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => isWithLength(x, n)).ToArray();
Console.WriteLine(String.Join(Environment.NewLine, names));
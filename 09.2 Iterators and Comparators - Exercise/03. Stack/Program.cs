
using Stack;

List<int> nums = Console.ReadLine()
    .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .Select(int.Parse)
    .ToList();

CustomStack<int> stack = new CustomStack<int>(nums);

string command=string.Empty;

while ((command=Console.ReadLine())!="END")
{
    if(command=="Pop")
    {
        stack.Pop();
    }
    else
    {
        string[]cmdArg=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        int num = int.Parse(cmdArg[1]);
        stack.Push(num);
    }
}
foreach (var item in stack)
{
    Console.WriteLine(item);
}
foreach (var item in stack)
{
    Console.WriteLine(item);
}
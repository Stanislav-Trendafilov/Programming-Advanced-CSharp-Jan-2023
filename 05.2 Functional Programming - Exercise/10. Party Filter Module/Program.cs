
List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, string> commands = new Dictionary<string, string>();

Func<List<string>, string, string, string, List<string>> filter = (members, command, type, cmdArg) =>
{
    if (type == "Starts with")
    {
        members.RemoveAll(x => x.StartsWith(cmdArg));
    }
    else if (type == "Length")
    {
        members.RemoveAll(x => x.Length == int.Parse(cmdArg));
    }
    else if (type == "Contains")
    {
        members.RemoveAll(x => x.Contains(cmdArg));
    }
    else
    {
        members.RemoveAll(x => x.EndsWith(cmdArg));
    }
    return members;
};

string command = Console.ReadLine();

while (command != "Print")
{
    string[] cmdArg = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArg[0];
    string filterType = cmdArg[1];
    string filterValue = cmdArg[2];

    if (cmd == "Remove filter")
    {
        commands.Remove($"Add filter;{filterType};{filterValue}");
    }
    else
    {
        if (!commands.ContainsKey(command))
        {
            commands[command] = "0";
        }
    }
    command = Console.ReadLine();
}
foreach (var kvp in commands)
{
    string[] cmdArg = kvp.Key.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArg[0];
    string filterType = cmdArg[1];
    string filterValue = cmdArg[2];

    names = filter(names, cmd,filterType, filterValue);
}
if (names.Any())
{
    Console.WriteLine($"{String.Join(" ", names)}");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

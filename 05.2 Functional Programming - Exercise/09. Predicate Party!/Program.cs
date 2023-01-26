
List<string> names=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

Func<List<string>, string, string, string, List<string>> filter = (members, command, type, cmdArg) =>
{
    if(command== "Remove")
    {
        if(type== "StartsWith")
        {
            members.RemoveAll(x=>x.StartsWith(cmdArg));
        }
        else if(type== "Length")
        {
            members.RemoveAll(x => x.Length==int.Parse(cmdArg));
        }
        else
        {
            members.RemoveAll(x => x.EndsWith(cmdArg));
        }
    }
    else if(command== "Double")
    {
        if (type == "StartsWith")
        {
            List<string> newmem = members.FindAll(x => x.StartsWith(cmdArg));
            foreach (var mem in newmem)
            {
                members.Add(mem);
            }
        }
        else if (type == "Length")
        {
            List<string> newmem = members.FindAll(x => x.Length == int.Parse(cmdArg));
            foreach (var mem in newmem)
            { 
                members.Add(mem); 
            }
        }
        else
        {
            List<string> newmem = members.FindAll(x => x.EndsWith(cmdArg));
            foreach (var mem in newmem)
            {
                members.Add(mem);
            }
        }
    }
    return members;
};

string command=Console.ReadLine();

while(command!= "Party!")
{
    string[] cmdArg=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArg[0];
    string cmdType = cmdArg[1];
    string givenString = cmdArg[2];

    names=filter(names,cmd,cmdType,givenString);

    command =Console.ReadLine();
}
if (names.Any())
{
    Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

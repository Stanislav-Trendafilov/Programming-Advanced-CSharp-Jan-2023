using System;
using System.Collections.Generic;

using _1.ListyIterator;

ListyIterator<string> iterator;
string input = Console.ReadLine();
string[] cmdTokens = input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (cmdTokens.Length >= 2)
{
    iterator = new(cmdTokens[1..]);
}
else
{
    iterator = new();
}


while ((input = Console.ReadLine()) != "END")
{
    if (input == "Move")
    {
        Console.WriteLine(iterator.Move());
    }
    else if (input == "HasNext")
    {
        Console.WriteLine(iterator.HasNext());
    }
    else
    {
        iterator.Print();
    }
}
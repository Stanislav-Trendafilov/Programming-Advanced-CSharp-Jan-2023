string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Action<string[]> printing = name => { foreach (var n in name) Console.WriteLine(n); };
printing(names);
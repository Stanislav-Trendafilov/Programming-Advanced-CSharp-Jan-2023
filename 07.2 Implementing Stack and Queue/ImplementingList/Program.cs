
using ImplementingList;

CustomList list = new();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

Console.WriteLine($"Count {list.Count}");

list.RemoveAt(0);
list.RemoveAt(3);

list.ForEach(", ");

Console.WriteLine(list.Contains(3));

list.Swap(0, 2);

list.ForEach(", ");

list.Insert(0, 1);

list.ForEach(", ");

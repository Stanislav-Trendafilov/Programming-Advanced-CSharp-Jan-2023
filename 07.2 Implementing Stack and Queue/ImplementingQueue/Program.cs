
using ImplementingQueue;

CustomStack stack= new CustomStack();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Pop();

Console.WriteLine($"Count: {stack.Count}");

stack.ForEach(x => Console.WriteLine(x));

using ImplementingQueue;

CustomQueue queue=new CustomQueue();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

Console.WriteLine(queue.Count);

queue.ForEach(x=>Console.Write($"{x} "));

Console.WriteLine();

Console.WriteLine(queue.Peek());

queue.Dequeue();

queue.ForEach(x => Console.Write($"{x} "));
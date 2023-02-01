
LinkedList<int>stack=new LinkedList<int>();

//stack.Push() function
stack.AddFirst(0);
stack.AddFirst(1);
stack.AddFirst(2);
stack.AddFirst(3);
stack.AddFirst(4);

//print elements in the stack with Pop function
while(stack.Count > 0)
{
    //stack.Pop() 
    int value=stack.First.Value;
    stack.RemoveFirst();

    Console.WriteLine(value);
}

Stack<int> stack2 = new Stack<int>();

stack2.Push(0);
stack2.Push(1);
stack2.Push(2);
stack2.Push(3);
stack2.Push(4);

while (stack2.Count > 0)
{
    Console.WriteLine(stack2.Pop());
}
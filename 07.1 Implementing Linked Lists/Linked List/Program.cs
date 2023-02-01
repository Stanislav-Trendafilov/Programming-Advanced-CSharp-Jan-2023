
using Linked_List;

//Node node = new Node(1);
//Node node2 = new Node(2);
//Node node3 = new Node(3);
//Node node4 = new Node(4);

//node.Next= node2;
//node2.Next= node3;
//node3.Next= node4;

//Node current = node;
//while(current!=null)
//{
//    Console.WriteLine(current.Value);
//    current = current.Next;
//}

LinkedListSoftuni linkedList=new LinkedListSoftuni();

linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
linkedList.AddFirst(4); 
linkedList.RemoveFirst();

linkedList.ForEach(x =>
{
    Console.Write($"{x} ");
});
Console.WriteLine();

int[]arr=linkedList.ToArray();
Console.WriteLine(string.Join("; ",arr));

//Node node = linkedList.Head;
//while(node != null)
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;   
//}
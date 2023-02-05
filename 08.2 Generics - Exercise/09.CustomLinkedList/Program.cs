namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

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

            int[] arr = linkedList.ToArray();
            Console.WriteLine(string.Join("; ", arr));

            //Node node = linkedList.Head;
            //while(node != null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;   
            //}
        }
    }
}
namespace DataStructures_287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.Print();

            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            linkedList.Print();

            /***********************************************/

            CustomStack<int> stack = new CustomStack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Print();

            int topItem = stack.Peek();
            Console.WriteLine("Top item: " + topItem);

            int poppedItem = stack.Pop();
            Console.WriteLine("Popped item: " + poppedItem);

            stack.Print();

            stack.Clear();
            Console.WriteLine("Stack cleared.");

            stack.Print();

            /*********************************************************/

            CustomQueue<int> queue = new CustomQueue<int>(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Print();

            int frontItem = queue.Peek();
            Console.WriteLine("Front item: " + frontItem);

            int dequeuedItem = queue.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedItem);

            queue.Print();

            queue.Clear();
            Console.WriteLine("Queue cleared.");

            queue.Print();

            /***********************************************************/

            CRUDwithLinkedList.CRUD1();
            CRUDwithStack.CRUD2();
            CRUDwithQueue.CRUD3();


        }
    }
}
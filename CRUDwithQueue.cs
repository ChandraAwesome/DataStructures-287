using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_287
{
    internal class CRUDwithQueue
    {
     public static void CRUD3()
        {
            Queue<string> queue = new Queue<string>();

            // Create (Enqueue elements into the queue)
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            // Read (Display elements in the queue)
            Console.WriteLine("Elements in the queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Update (Modify the front element in the queue)
            if (queue.Count > 0)
            {
                queue.Dequeue(); // Remove the front element
                queue.Enqueue("Grapes"); // Enqueue a new element at the rear
            }

            Console.WriteLine("\nAfter updating the front element:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Delete (Dequeue the front element from the queue)
            if (queue.Count > 0)
            {
                queue.Dequeue();
            }

            Console.WriteLine("\nAfter removing the front element:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }

}

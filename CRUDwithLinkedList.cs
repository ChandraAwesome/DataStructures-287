using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_287
{
    internal class CRUDwithLinkedList
    { 
      public static void CRUD1()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            // Create (Add elements to the linked list)
            linkedList.AddLast("Apple");
            linkedList.AddLast("Banana");
            linkedList.AddLast("Cherry");

            // Read (Display elements in the linked list)
            Console.WriteLine("Elements in the linked list:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Update (Modify an element in the linked list)
            LinkedListNode<string> node = linkedList.Find("Banana");
            if (node != null)
            {
                node.Value = "Grapes";
            }

            Console.WriteLine("\nAfter updating 'Banana' to 'Grapes':");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Delete (Remove an element from the linked list)
            linkedList.Remove("Cherry");

            Console.WriteLine("\nAfter removing 'Cherry':");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }

}


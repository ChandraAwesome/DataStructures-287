using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_287
{
    internal class CRUDwithStack
    {
      public  static void CRUD2()
        {
            Stack<string> stack = new Stack<string>();

            // Create (Push elements onto the stack)
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");

            // Read (Display elements in the stack)
            Console.WriteLine("Elements in the stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Update (Modify the top element in the stack)
            if (stack.Count > 0)
            {
                stack.Pop(); // Remove the top element
                stack.Push("Grapes"); // Push a new element onto the top
            }

            Console.WriteLine("\nAfter updating the top element:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Delete (Pop the top element from the stack)
            if (stack.Count > 0)
            {
                stack.Pop();
            }

            Console.WriteLine("\nAfter removing the top element:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

}


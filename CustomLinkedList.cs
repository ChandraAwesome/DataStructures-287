using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_287
{ 
    public class LinkedListNode<T>
        {
            public T Value { get; set; }
            public LinkedListNode<T> Next { get; set; }

            public LinkedListNode(T value)
            {
                Value = value;
                Next = null;
            }
        }

        public class CustomLinkedList<T>
        {
            private LinkedListNode<T> head;
            private LinkedListNode<T> tail;

            public int Count { get; private set; }

            public void AddFirst(T value)
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>(value);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }

                Count++;
            }

            public void AddLast(T value)
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>(value);

                if (tail == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    tail = newNode;
                }

                Count++;
            }

            public void RemoveFirst()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The LinkedList is empty.");
                }

                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }

                Count--;
            }

            public void RemoveLast()
            {
                if (tail == null)
                {
                    throw new InvalidOperationException("The LinkedList is empty.");
                }

                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    LinkedListNode<T> currentNode = head;
                    while (currentNode.Next != tail)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = null;
                    tail = currentNode;
                }

                Count--;
            }

            public void Print()
            {
                LinkedListNode<T> currentNode = head;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Next;
                }
            }
        }

    }


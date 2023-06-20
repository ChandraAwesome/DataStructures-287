using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_287
{
    public class CustomStack<T>
    {
        private T[] stackArray;
        private int top;

        public int Count { get; private set; }

        public CustomStack(int capacity)
        {
            stackArray = new T[capacity];
            top = -1;
            Count = 0;
        }

        public void Push(T item)
        {
            if (top == stackArray.Length - 1)
            {
                throw new StackOverflowException("The Stack is full.");
            }

            top++;
            stackArray[top] = item;
            Count++;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }

            T item = stackArray[top];
            top--;
            Count--;

            return item;
        }

        public T Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }

            return stackArray[top];
        }

        public void Clear()
        {
            top = -1;
            Count = 0;
        }

        public void Print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }

}

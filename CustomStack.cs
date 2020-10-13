using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue_Palindrome
{
    public class CustomStack<T>
    {
        protected class StackNode<U>
        {
            public U data;
            public StackNode<U> next;

            public StackNode(U data)
            {
                this.data = data;
            }
        }

        public int Count { get; set; }
        private StackNode<T> top;
        int count = 0;

        public void Push(T item)
        {
            StackNode<T> t = new StackNode<T>(item)
            {
                next = top
            };
            top = t;
            count++;
        }

        public T Pop()
        {
            if (top == null) throw new ApplicationException();
            T item = top.data;
            top = top.next;
            count--;
            return item;
        }

        public T Peek()
        {
            if (top == null) throw new ApplicationException();
            return top.data;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }
    }

}

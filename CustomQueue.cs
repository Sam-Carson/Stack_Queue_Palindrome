﻿using System;

namespace Stack_Queue_Palindrome
{
    public class CustomQueue<T>
    {
        protected class QueueNode<G>
        {
            public G data;
            public QueueNode<G> next;

            public QueueNode(G data)
            {
                this.data = data;
            }
        }
        public int Count { get; private set; }

        private QueueNode<T> head;
        private QueueNode<T> tail;

        public void Enqueue(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if (tail != null)
            {
                tail.next = t;
            }
            tail = t;
            if (head == null)
            {
                head = tail;
                Count++;
            }
        }

        public T Dequeue()
        {
            if (head == null) throw new ApplicationException();
            {
                T item = head.data;
                head = head.next;
                Count--;
                return item;
            }
        }

        public T Peek()
        {
            if (head == null) throw new ApplicationException();
            {
                return head.data;
            }
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

    }

}

namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public T value;
            public Node(T item)
            {
                value = item;
            }

            public Node Previous { get; set; }
            public Node Next { get; set; }
        }
        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new Node(item);
            node.Next = null;
            node.Previous = null;

            if (Count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                var oldHead = head;
                head = node;
                node.Next = oldHead;
                oldHead.Previous = node;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            var node = new Node(item);
            node.Next = null;
            node.Previous = null;

            if (Count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                var oldTail = tail;
                oldTail.Next = node;
                tail = node;
                tail.Previous = oldTail;
            }

            Count++;
        }

        public T GetFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return head.value;
        }

        public T GetLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return tail.value;
        }

        public T RemoveFirst()
        {
            T value;

            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            if (Count == 1)
            {
                value = head.value;
                head = null;
                tail = null;
            }
            else
            {
                var oldHead = head;
                head = oldHead.Next;
                head.Previous = null;
                value = oldHead.value;
            }
            
            Count--;
            return value;
        }

        public T RemoveLast()
        {
            T value;
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            if (Count == 1)
            {
                value = head.value;
                head = null;
                tail = null;
                
            }
            else
            {
                var oldTail = tail;
                tail = oldTail.Previous;
                tail.Next = null;
                value = oldTail.value;
            }
            
            Count--;
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;

            while (current != null)
            {
                yield return current.value;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
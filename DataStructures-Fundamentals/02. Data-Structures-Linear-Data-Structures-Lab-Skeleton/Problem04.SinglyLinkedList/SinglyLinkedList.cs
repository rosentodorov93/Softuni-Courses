namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
            public Node(T value)
                : this(value, null)
            {

            }

            public T Value { get; set; }
            public Node Next { get; set; }
        }
        private Node head;
        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new Node(item);
            if (Count == 0)
            {
                head = node;
            }
            else
            {
                var oldHead = head;
                node.Next = oldHead;
                head = node;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            var node = new Node(item);

            if (Count == 0)
            {
                head = node;
            }
            else
            {
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public T GetFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return head.Value;
        }

        public T GetLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            if (Count == 1)
            {
                return head.Value;
            }
            else
            {
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                return current.Value;
            }
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            var oldHead = head;
            head = oldHead.Next;
            Count--;
            return oldHead.Value;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                var value = head.Value;
                head = null;
                Count--;
                return value;
            }
            else
            {
                var current = head;

                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                var value = current.Next.Value;
                current.Next = null;
                Count--;
                return value;
            }

            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
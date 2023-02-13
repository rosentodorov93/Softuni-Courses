namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
            public Node(T value)
                :this(value, null)
            {

            }

            public T Value { get; set; }
            public Node Next { get; set; }
        }

        private Node top;

        public int Count { get; private set; }

        public void Push(T item)
        {
            var node = new Node(item);
            if (Count == 0)
            {
                top = node;
            }
            else
            {
                var oldTop = top;
                node.Next = oldTop;
                top = node;
            }
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            var oldTop = top;
            top = oldTop.Next;
            Count--;
            return oldTop.Value;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return top.Value;
        }

        public bool Contains(T item)
        {
            var current = top;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = top;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
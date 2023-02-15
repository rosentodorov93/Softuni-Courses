namespace Problem01.CircularQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CircularQueue<T> : IAbstractQueue<T>
    {

        private T[] items;
        private int startIndex;
        private int endIndex;
        public CircularQueue(int capacity = 4)
        {
            items = new T[capacity];
        }
        public int Count { get; private set; }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            var value = items[startIndex];
            startIndex = (startIndex + 1) % items.Length;
            Count--;
            return value;
        }

        public void Enqueue(T item)
        {
            if (Count == items.Length)
            {
                Grow();
            }

            items[endIndex] = item;
            endIndex = (endIndex + 1) % items.Length;
            Count++;
            
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return items[startIndex];
        }

        public T[] ToArray()
        {
            return CopyElements(new T[Count]);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[(startIndex + i) % items.Length];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void Grow()
        {
            this.items = CopyElements(new T[items.Length * 2]);
            startIndex = 0;
            endIndex = Count;
        }

        private T[] CopyElements(T[] resultArrray)
        {
            for (int i = 0; i < Count; i++)
            {
                resultArrray[i] = items[(startIndex + i) % items.Length];
            }

            return resultArrray;
        }
    }

}

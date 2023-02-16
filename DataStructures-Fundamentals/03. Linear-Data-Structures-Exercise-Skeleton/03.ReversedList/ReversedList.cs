namespace Problem03.ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IAbstractList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] items;

        public ReversedList()
            : this(DefaultCapacity) { }

        public ReversedList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[(Count - index) - 1];
            }
            set
            {
                ValidateIndex(index);
                items[(Count - index) - 1] = value;
            }
        }

     

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count == items.Length)
            {
                Grow();
            }

            items[Count++] = item;
        }

        private void Grow()
        {
            var newArray = new T[items.Length * 2];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }

            return true;
        }

        public int IndexOf(T item)
        {
           
            for (int i = 1; i <= Count; i++)
            {
                if (items[Count - i].Equals(item))
                {
                    return i - 1;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);

            index = (Count - index) - 1;

            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index + 1] = item;
            Count++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            for (int i = (Count - index) - 1; i < Count; i++)
            {
                items[i] = items[i + 1];
            }

            Count--;
            return true;
        }
        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            Remove(items[(Count - index) - 1]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
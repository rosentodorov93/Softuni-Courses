namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] items;

        public List()
            : this(DEFAULT_CAPACITY) {
        }

        public List(int capacity)
        {
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set
            {
                ValidateIndex(index);
                items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count >= items.Length)
            {
                Grow();
            }

            items[Count++] = item;
        }

        public bool Contains(T item)
        {
            int result = IndexOf(item);
            if (result == -1)
            {
                return false;
            }

            return true;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);

            if (Count + 1 >= items.Length)
            {
                Grow();
            }

            for (int i = Count + 1; i >= index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            Count++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < Count; i++)
            {
                items[i] = items[i +1];
            }

            Count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);
            Remove(items[index]);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            };
        }
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void Grow()
        {
            T[] newArray = new T[items.Length * 2];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }
    }
}
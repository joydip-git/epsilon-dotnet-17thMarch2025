using System.Collections;

namespace GenericDemo
{
    interface IMyCollection<T> where T : struct
    {
        void Add(T item);
        int Count { get; }
        int Capacity { get; }
    }

    class MyCollection<T> : IEnumerable<T>, IMyCollection<T> where T : struct
    {
        T[] items;
        int index = 0;
        public MyCollection()
        {
            items = new T[4];
        }
        public void Add(T item)
        {
            if (index == items.Length)
            {
                T[] temp = new T[items.Length * 2];
                items.CopyTo(temp, 0);
                items = temp;

            }
            items[index] = item;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => index;
        public int Capacity => items.Length;

    }
}

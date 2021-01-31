using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Heap<T>
    {
        private readonly List<T> _items;
        private readonly Func<(T parent, T child), bool> _comparator;

        public int Count => _items.Count;

        public Heap(Func<(T parent, T child), bool> comparator)
        {
            _items = new List<T>();
            _comparator = comparator;
        }

        public void Insert(T item)
        {
            _items.Add(item);
            var current = _items.Count - 1;
            while (current != 0)
            {
                var parent = (int)Math.Floor((decimal)(current - 1) / 2);
                if (_comparator((_items[parent], _items[current])))
                    break;
                Swap(current, parent, _items);
                current = parent;
            }
        }

        public void Remove()
        {
            Swap(0, _items.Count - 1, _items);
            _items.RemoveAt(_items.Count - 1);

            var currentIndex = 0;
            while (true)
            {
                var leftChildIndex = currentIndex * 2 + 1;
                var rightChildIndex = leftChildIndex + 1;
                if (leftChildIndex >= _items.Count)
                    break;

                if (rightChildIndex >= _items.Count)
                    rightChildIndex = leftChildIndex;

                if (_comparator((_items[currentIndex], _items[leftChildIndex])) &&
                   _comparator((_items[currentIndex], _items[rightChildIndex])))
                    break;

                var minIndex = leftChildIndex;
                if (!_comparator((_items[minIndex], _items[rightChildIndex])))
                    minIndex = rightChildIndex;

                Swap(minIndex, currentIndex, _items);
                currentIndex = minIndex;
            }
        }

        public T Peek()
        {
            return _items[0];
        }

        private static void Swap(int source, int destination, List<T> items)
        {
            var item = items[source];
            items[source] = items[destination];
            items[destination] = item;
        }
    }
}

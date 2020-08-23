using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public sealed class CustomQueue
    {
        private Stack<int> _lifo;
        private Stack<int> _fifo;

        public CustomQueue()
        {
            _lifo = new Stack<int>();
            _fifo = new Stack<int>();
        }

        public void Enqueue(int item)
        {
            _lifo.Push(item);
        }

        public void Dequeue()
        {
            if (_fifo.Count == 0)
            {
                while (_lifo.Count > 0)
                    _fifo.Push(_lifo.Pop());
            }

            _fifo.Pop();
        }


        public int Peek()
        {
            if (_fifo.Count == 0)
            {
                while (_lifo.Count > 0)
                    _fifo.Push(_lifo.Pop());
            }

            return _fifo.Peek();
        }
    }
}

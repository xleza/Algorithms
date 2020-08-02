namespace Algorithms
{
    public sealed class DesignHashSet
    {
        private readonly bool[] _elements = new bool[1000001];
        public DesignHashSet()
        {

        }

        public void Add(int key)
        {
            _elements[key] = true;
        }

        public void Remove(int key)
        {
            _elements[key] = false;
        }

        public bool Contains(int key)
        {
            return _elements[key];
        }
    }
}

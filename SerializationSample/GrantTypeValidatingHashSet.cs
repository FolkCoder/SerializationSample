using System.Collections;
using System.Collections.Generic;

namespace SerializationSample
{
    public class GrantTypeValidatingHashSet : ICollection<string>
    {
        private readonly ICollection<string> _inner;

        public GrantTypeValidatingHashSet()
        {
            _inner = new HashSet<string>();
        }

        public GrantTypeValidatingHashSet(IEnumerable<string> values)
        {
            _inner = new HashSet<string>(values);
        }

        public int Count => _inner.Count;

        public bool IsReadOnly => _inner.IsReadOnly;

        public void Add(string item)
        {
            _inner.Add(item);
        }

        public void Clear()
        {
            _inner.Clear();
        }

        public bool Contains(string item)
        {
            return _inner.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            _inner.CopyTo(array, arrayIndex);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _inner.GetEnumerator();
        }

        public bool Remove(string item)
        {
            return _inner.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _inner.GetEnumerator();
        }
    }
}
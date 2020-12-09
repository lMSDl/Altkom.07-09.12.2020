using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<Tuple<T, T>>
    {
        private IEnumerable<T> _enumerable;

        public Buffer(IEnumerable<T> enumerable)
        {
            _enumerable = enumerable;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(_enumerable.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

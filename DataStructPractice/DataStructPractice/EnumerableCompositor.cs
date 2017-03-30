using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructPractice
{
    class EnumerableCompositor<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructPractice
{
    static class EnumerableCompositor
    {
        public static EnumerableCompositor<T> EC<T>(params IEnumerable<T>[] collections)
        {
            return new EnumerableCompositor<T>(collections);
        }
    }

    class EnumerableCompositor<T> : IEnumerable<T>
    {
        private List<IEnumerable<T>> _collections;

        public EnumerableCompositor()
        {
            _collections = new List<IEnumerable<T>>();
        }

        public EnumerableCompositor(IEnumerable<IEnumerable<T>> collections)
        {
            _collections = collections.ToList();
        }

        public void Add(IEnumerable<T> collection)
        {
            _collections.Add(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var collection in _collections)
            {
                foreach(var item in collection)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TCollection To<TCollection>() where TCollection : ICollection<T>, new()
        {
            var collection = new TCollection(); //This operation wouldn't be possible w/o the reference to 'new()'

            foreach(var item in this)   //This operation wouldn't be possible w/o the reference to 'ICollection<T>'
            {
                collection.Add(item);
            }

            return collection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        //private ICollection<T> _freeObjects = new List<T>();
        private ICollection<T> _objects = new List<T>();
        private Func<T, bool> _check;
        /*public ObjectPool(int size, Func<T> createFunc)
        {
            for (int i = 0; i < size; i++)
            {
                _freeObjects.Add(createFunc());
            }
        }*/
        public ObjectPool(int size, Func<T> createFunc, Func<T, bool> check)
        {
            _check = check;
            for (int i = 0; i < size; i++)
            {
                _objects.Add(createFunc());
            }
        }

        public T Acquire()
        {
            return _objects.FirstOrDefault(x => _check(x));
        }

        /*public T Acquire()
        {
            var @object = _freeObjects.FirstOrDefault();
            if (@object == null)
                return default;
            _freeObjects.Remove(@object);
            _objects.Add(@object);
            return @object;
        }

        public void Release(T @object)
        {
            _objects.Remove(@object);
            _freeObjects.Add(@object);
        }*/
    }
}

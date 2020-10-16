using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Buffer
{
    internal class Buffer<T> : IBuffer<T>, IEnumerable<T>
    {
        protected Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpry
        {
            get
            {
                return _queue.Count == 0;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
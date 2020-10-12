using System;
using System.Collections.Generic;
using System.Text;

namespace _10._1
{
    internal interface IMyList<T>
    {
        void Add(T item);

        T this[int index] { get; }

        int Count { get; }

        void Clear();

        bool Contains(T item);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _10._1
{
    internal class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index < array.Length & index >= 0)
                    return array[index];
                else
                {
                    return default;
                }
            }
        }

        public void Add(T item)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[0] = array[0];
            }
            tempArray[array.Length] = item;
            array = tempArray;
        }

        public void Clear()
        {
            array = null;
        }

        public bool Contains(T item)
        {
            if (array.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Count
        {
            get
            {
                if (array == null) return 0;
                return array.Length;
            }
        }
    }
}
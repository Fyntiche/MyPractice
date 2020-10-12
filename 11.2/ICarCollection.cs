using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _11._2
{
    internal interface ICarCollection
    {
        void Add(string name, int year);

        Car this[int index] { get; }

        public int Count { get; }
    }
}
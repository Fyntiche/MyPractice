using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _11._2
{
    internal class CarCollection : ICarCollection, IEnumerable

    {
        private List<Car> carCollection = new List<Car>();

        public Car this[int index]
        {
            get
            {
                return carCollection[index];
            }
        }

        public int Count
        {
            get
            {
                return carCollection.Count;
            }
        }

        public void Add(string name, int year)
        {
            carCollection.Add(new Car(name, year));
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in carCollection)
            {
                yield return item;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._0
{
    internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
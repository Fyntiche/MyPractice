using System;
using System.Net.Http.Headers;

namespace _09_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            BaseClass baseClass = derivedClass;
            DerivedClass derivedClass1 = (DerivedClass)baseClass;
            baseClass.Method();
            derivedClass1.Method();
            Console.ReadKey();
        }
    }
}

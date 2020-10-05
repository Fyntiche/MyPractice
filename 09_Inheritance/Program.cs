using System;

namespace _09_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
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
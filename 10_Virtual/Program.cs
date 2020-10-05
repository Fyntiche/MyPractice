using System;

namespace _10_Virtual
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            BaseClass baseClass = derivedClass;
            baseClass.Method();
            Console.ReadKey();
        }
    }
}
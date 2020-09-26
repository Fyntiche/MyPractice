using System;

namespace _10_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            BaseClass baseClass = derivedClass;
            baseClass.Method();
            Console.ReadKey();
        }
    }
}

using System;

namespace _06_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass1 = derivedClass;
            Console.WriteLine(baseClass.publicField);
            Console.WriteLine(derivedClass.publicField);
            Console.WriteLine(derivedClass.publicField2);
            Console.WriteLine(baseClass1.publicField);
            Console.ReadLine();
        }
    }
}
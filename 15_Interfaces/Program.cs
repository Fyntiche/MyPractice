using System;

namespace _15_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            Interface1 instance1 = new DerivedClass();
            Interface2 instance2 = new DerivedClass();
            instance1.Method();
            instance2.Method();
            Console.ReadKey();
        }
    }
}
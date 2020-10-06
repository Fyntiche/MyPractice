using System;

namespace _16_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1(1);
            derivedClass.Method2();
            derivedClass.Method3();

            Console.WriteLine(new string('-', 40));

            Interface1 instance = derivedClass as Interface1;
            instance.Method1(1);

            Interface2 instance2 = derivedClass as Interface2;
            instance2.Method2();

            BaseClass baseClass = derivedClass as BaseClass;
            baseClass.Method3();

            Console.ReadLine();
        }
    }
}
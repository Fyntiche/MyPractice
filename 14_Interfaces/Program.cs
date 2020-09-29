using System;

namespace _14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 instance1 = new DerivedClass();
            Interfaces2 instance2 = new DerivedClass();
            instance1.Method1();
            instance2.Method2();
            Console.ReadKey();
        }
    }
}

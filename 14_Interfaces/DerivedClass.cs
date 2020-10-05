using System;

namespace _14_Interfaces
{
    internal class DerivedClass : Interface1, Interfaces2
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
using System;

namespace _16_Interfaces
{
    internal class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1(int a)
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
using System;

namespace _15_Interfaces
{
    internal class DerivedClass : Interface1, Interface2
    {
        void Interface1.Method()
        {
            Console.WriteLine("Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Interface2");
        }
    }
}
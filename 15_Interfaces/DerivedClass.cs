using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Interfaces
{
    class DerivedClass : Interface1, Interface2
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

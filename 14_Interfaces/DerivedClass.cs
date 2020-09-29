using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Interfaces
{
    class DerivedClass : Interface1, Interfaces2
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

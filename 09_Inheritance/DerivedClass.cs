using System;

namespace _09_Inheritance
{
    internal class DerivedClass : BaseClass
    {
        public new void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
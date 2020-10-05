using System;

namespace _10_Virtual
{
    internal class DerivedClass : BaseClass
    {
        public override void Method()
        {
            base.Method();
            Console.WriteLine("DerivedClass");
        }
    }
}
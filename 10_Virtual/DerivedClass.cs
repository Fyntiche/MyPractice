using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Virtual
{
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            base.Method();
            Console.WriteLine("DerivedClass");
        }
    }
}

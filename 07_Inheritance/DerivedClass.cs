using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Inheritance
{
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";

            protectedField = "DerivedClass.protectedField";

        }
    }
}

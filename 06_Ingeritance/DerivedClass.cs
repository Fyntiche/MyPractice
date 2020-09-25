using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Inheritance
{
    class DerivedClass : BaseClass
    {
        public string publicField2 = "DerivedClass.field2";
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";

            

            protectedField = "DerivedClass.protectedField";

        }
    }
}

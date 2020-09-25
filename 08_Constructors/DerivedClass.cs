using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedNumber;

        public DerivedClass(int number1, int number2) 
            : base(number1)
        {
            derivedNumber = number2;
        }
    }
}

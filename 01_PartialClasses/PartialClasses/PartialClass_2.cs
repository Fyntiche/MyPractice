using System;
using System.Collections.Generic;
using System.Text;

namespace _01_PartialClasses.PartialClasses
{
    public partial class PartialClass
    {
        public void PrintPC2()
        {
            Console.WriteLine("Partial class 2");
        }

        partial void PrintPC3()
        {
            Console.WriteLine("Partial method");
        }

        public void CallPrintPC3Method()
        {
            PrintPC3();
        }
    }
}

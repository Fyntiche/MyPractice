using System;
using System.Collections.Generic;
using System.Text;

namespace _01_PartialClasses.PartialClasses
{
    public partial class PartialClass
    {
        public PartialClass()
        {
            field = "2";
        }
        public readonly string field;
        public void PrintPC2()
        {
            Console.WriteLine("Partial class 2");
        }

        partial void PrintPC3()
        {
            Console.WriteLine(field);
        }

        public void CallPrintPC3Method()
        {
            PrintPC3();
        }

    }
}

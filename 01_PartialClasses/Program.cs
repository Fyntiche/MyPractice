using _01_PartialClasses.PartialClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_PartialClasses
{
    class Program
    {
        static void Main()
        {
            PartialClass partialClass = new PartialClass();
            partialClass.PrintPC1();
            partialClass.PrintPC2();
            partialClass.CallPrintPC3Method();
            Console.Read();
        }
    }
}

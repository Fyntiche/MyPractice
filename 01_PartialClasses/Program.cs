using _01_PartialClasses.PartialClasses;
using System;

namespace _01_PartialClasses
{
    internal class Program
    {
        private static void Main()
        {
            PartialClass partialClass = new PartialClass();
            partialClass.PrintPC1();
            partialClass.PrintPC2();
            partialClass.CallPrintPC3Method();
            Console.Read();
        }
    }
}
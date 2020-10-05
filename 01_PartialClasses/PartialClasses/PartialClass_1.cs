using System;

namespace _01_PartialClasses.PartialClasses
{
    public partial class PartialClass
    {
        public void PrintPC1()
        {
            Console.WriteLine("Partial class 1");
        }

        partial void PrintPC3();
    }
}
using System;

namespace _17_Interfaces
{
    abstract class  AbsractClass : Interface1
    {
        public abstract void Method();
    }

    class Class1 : AbsractClass
    {
        public override void Method()
        {
            Console.WriteLine("Interface1");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Method();
            Console.ReadKey();
        }
    }
}

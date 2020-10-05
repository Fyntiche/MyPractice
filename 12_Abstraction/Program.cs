using System;

namespace _12_Abstraction
{
    internal class Program
    {
        private class ConcreteClass
        {
            public void Operation()
            {
                Console.WriteLine("operation");
            }
        }

        private abstract class AbsractClass : ConcreteClass
        {
            public abstract void Method();
        }

        private abstract class AbstractClass2
        {
            public abstract void Method2();
        }

        private class ConcreteClassB : AbsractClass
        {
            public override void Method()
            {
                Console.WriteLine("AbstractMethod");
            }
        }

        private static void Main(string[] args)
        {
            AbsractClass instance = new ConcreteClassB();
            instance.Operation();
            instance.Method();
            Console.ReadKey();
        }
    }
}
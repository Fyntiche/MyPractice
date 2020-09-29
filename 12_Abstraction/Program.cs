using System;

namespace _12_Abstraction
{
    class Program
    {
        class ConcreteClass
        {
            public void Operation()
            {
                Console.WriteLine("operation");
            }
        }

        abstract class AbsractClass : ConcreteClass
        {
            public abstract void Method();
        }

        abstract class AbstractClass2
        {
            public abstract void Method2();
        }

        class ConcreteClassB : AbsractClass
        {
            public override void Method()
            {
                Console.WriteLine("AbstractMethod");
            }
        }

        static void Main(string[] args)
        {
            AbsractClass instance = new ConcreteClassB();
            instance.Operation();
            instance.Method();
            Console.ReadKey();
        }
    }
}

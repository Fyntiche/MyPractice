﻿using System;

namespace _11_Abstraction
{
    internal abstract class AbstractClass
    {
        public abstract void Method();
    }

    internal class MyClass1 : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Class1");
        }
    }

    internal class MyClass3 : MyClass1
    {
        public override void Method()
        {
            Console.WriteLine("Class3");
        }
    }

    internal class MyClass2 : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Class2");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            AbstractClass myClass1 = new MyClass1();
            AbstractClass myClass2 = new MyClass2();
            AbstractClass myClass3 = new MyClass3();
            AbstractClass myClass4 = myClass3;
            myClass1.Method();
            myClass2.Method();
            myClass3.Method();
            myClass4.Method();
            Console.ReadKey();
        }
    }
}
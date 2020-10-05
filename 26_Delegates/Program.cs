using System;

namespace _26_Delegates
{
    internal class MyClass
    {
        public void Method()
        {
            Console.WriteLine("MyClass.Method");
        }
    }

    public delegate void MyDelegate();

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate @delegate = new MyDelegate(myClass.Method);
            @delegate += myClass.Method;
            @delegate.Invoke();
            @delegate();
            Console.ReadKey();
        }
    }
}
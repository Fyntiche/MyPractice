using System;

namespace _26_Delegates
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("MyClass.Method");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
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

using System;

namespace _41_Events
{
    internal delegate void EventDelegate();

    internal class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    internal class Program
    {
        public static void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        public static void Handler2()
        {
            Console.WriteLine("Handler2");
        }

        private static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2;

            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
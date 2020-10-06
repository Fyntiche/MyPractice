using System;

namespace _42_Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        private EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        {
            add
            {
                myEvent += value;
            }
            remove
            {
                myEvent -= value;
            }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    internal class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler2");
        }

        private static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            instance.InvokeEvent();
            Console.WriteLine(new string('_', 50));
            instance.MyEvent -= Handler1;
            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
using System;

namespace _44_Events
{
    public delegate void MyDelegate();
    interface EventInteface
    {
        event MyDelegate MyEvent;
    }

    class BaseClass : EventInteface
    {
        private MyDelegate eventDelegate = null;

        public virtual event MyDelegate MyEvent
        {
            add
            {
                eventDelegate += value;
            }
            remove
            {
                eventDelegate -= value;
            }
        }
        public void MyEventInvoke()
        {
            eventDelegate.Invoke();
        }
    }

    class DerivedClass : BaseClass
    {
        public override event MyDelegate MyEvent
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine("DerivedClass");
            }

            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("DerivedClass");
            }
        }
    }
    class Program
    {
        public static void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        public static void Handler2()
        {
            Console.WriteLine("Handler2");
        }

        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.MyEvent += Handler1;
            baseClass.MyEvent += Handler2;
            baseClass.MyEventInvoke();
            Console.WriteLine(new string('_', 50));
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.MyEvent += Handler2;
            derivedClass.MyEventInvoke();
            Console.WriteLine(new string('_', 50));
            DerivedClass derivedClass1 = new DerivedClass();
            derivedClass1.MyEvent += Handler1;
            derivedClass1.MyEvent += Handler2;
            derivedClass1.MyEventInvoke();
            Console.ReadKey();
        }
    }
}

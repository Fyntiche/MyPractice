using System;

namespace _33_Generics
{
    internal class MyClass<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass.Method();
            MyClass<string> myClass1 = new MyClass<string>();
            myClass1.field = "a";
            myClass1.Method();
            Console.ReadLine();
        }
    }
}
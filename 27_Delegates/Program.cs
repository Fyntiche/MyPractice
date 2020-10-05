using System;

namespace _27_Delegates
{
    internal class MyClass
    {
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }

    public delegate string MyDelegate(string name);

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate @delegate = new MyDelegate(myClass.Method);
            @delegate += myClass.Method;
            Console.WriteLine(@delegate("ivan"));
            Console.WriteLine(@delegate("ivans"));
            Console.ReadKey();
        }
    }
}
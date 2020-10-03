using System;

namespace _27_Delegates
{

    class MyClass
    {
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }

    public delegate string MyDelegate(string name);

    class Program
    {
        static void Main(string[] args)
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

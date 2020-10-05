using System;

namespace _13_Interfaces
{
    internal interface IInteface
    {
        void Method();
    }

    internal class MyClass : IInteface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IInteface myClass = new MyClass();
            myClass.Method();
            Console.ReadKey();
        }
    }
}
using System;

namespace _13_Interfaces
{
    interface IInteface
    {
        void Method();
    }


    class MyClass : IInteface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IInteface myClass = new MyClass();
            myClass.Method();
            Console.ReadKey();
        }
    }
}

using System;

namespace _39_Constraint
{
    internal class MyClass<T> where T : struct
    {
        public T variable;
    }

    internal class MyClass1<T> where T : class
    {
        public T variable;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine(myClass.variable.GetType());
            MyClass1<string> myClass1 = new MyClass1<string>();
            myClass1.variable = "1";
            Console.WriteLine(myClass1.variable.GetType());
            Console.ReadLine();
        }
    }
}
using System;

namespace _35_Generics
{
    internal class MyClass
    {
        public void Method<T, T1>(T argument, T1 argument1)
        {
            T variable = argument;
            T1 variable2 = argument1;
            Console.WriteLine(variable + " " + variable2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method(5, 6);
            Console.ReadKey();
        }
    }
}
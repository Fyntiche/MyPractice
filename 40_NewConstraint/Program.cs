using System;
using System.Collections.Generic;

namespace _40_NewConstraint
{
    internal class MyClass<T> where T : new()
    {
        public T variable = new T();

        public new void GetType()
        {
            Console.WriteLine(variable.ToString());
        }
    }

    internal class MyTest
    {
        public int MyVariable = 1;
        public int MyVariable1 = 2;

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyVariable1, MyVariable);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass<MyTest> myClass = new MyClass<MyTest>();
            myClass.GetType();
            Console.ReadLine();
            List<int> a = new List<int>();
        }
    }
}
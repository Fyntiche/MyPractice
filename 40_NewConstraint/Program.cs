using System;

namespace _40_NewConstraint
{
    class MyClass<T> where T : new()
    {
        public T variable = new T();

        public new void GetType()
        {
            Console.WriteLine(variable.ToString());
        }
    }

    class MyTest
    {
        public int MyVariable = 1;
        public int MyVariable1 = 2;

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyVariable1, MyVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<MyTest> myClass = new MyClass<MyTest>();
            myClass.GetType();
            Console.ReadLine();
        }
    }
}

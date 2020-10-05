using System;

namespace _34_Generics
{
    internal class MyClass<Type1, Type2>
    {
        private Type1 var1;
        private Type2 var2;

        public MyClass(Type1 var1, Type2 var2)
        {
            this.var1 = var1;
            this.var2 = var2;
        }

        public Type1 Var1
        {
            get { return var1; }
            set { var1 = value; }
        }

        public Type2 Var2
        {
            get { return var2; }
            set { var2 = value; }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass<int, int> myClass = new MyClass<int, int>(1, 2);
            Console.WriteLine(myClass.Var1 + myClass.Var2);
            MyClass<string, string> myClass1 = new MyClass<string, string>("Hello", "World");
            Console.WriteLine(myClass1.Var1 + " " + myClass1.Var2);
            Console.ReadLine();
        }
    }
}
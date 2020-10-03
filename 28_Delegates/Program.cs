using System;

namespace _28_Delegates
{
    class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("method1");
        }

        public void Method2()
        {
            Console.WriteLine("method2");
        }

        public void Method3()
        {
            Console.WriteLine("Method3");
        }
    }

    public delegate void MyDelegate();


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = myClass.Method1;
            MyDelegate myDelegate2 = myClass.Method2;
            MyDelegate myDelegate3 = myClass.Method3;

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;
            myDelegate = myDelegate - myDelegate3;

            Console.WriteLine("Set numbet 1 - 4");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myDelegate1();
                    break;
                case "2":
                    myDelegate2();
                    break;
                case "3":
                    myDelegate3();
                    break;
                case "4":
                    myDelegate();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}

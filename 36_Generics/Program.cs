using System;

namespace _36_Generics
{
    internal delegate R MyDelegate<T, T1, R>(T t, T1 t1);

    internal class Program
    {
        public static int Add(int i, int b)
        {
            return i + b;
        }

        public static string AddStr(int i, int b)
        {
            return i.ToString() + b.ToString();
        }

        private static void Main(string[] args)
        {
            MyDelegate<int, int, int> myDelegate = Add;
            Console.WriteLine(myDelegate(4, 5));
            MyDelegate<int, int, string> myDelegate1 = AddStr;
            Console.WriteLine(myDelegate1(5, 6));
            Console.ReadLine();
        }
    }
}
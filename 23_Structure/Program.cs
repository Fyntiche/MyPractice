using System;

namespace _23_Structure
{
    internal struct MyStruct
    {
        public int field;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyStruct myStruct;
            myStruct.field = 5;
            Console.WriteLine(myStruct.field);
            Console.ReadLine();
        }
    }
}
using System;

namespace _23_Structure
{

    struct MyStruct
    {
        public int field;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct;
            myStruct.field = 5;
            Console.WriteLine(myStruct.field);
            Console.ReadLine();
        }
    }
}

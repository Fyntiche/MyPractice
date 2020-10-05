using System;

namespace _20_Static
{
    internal class NoStaticClass
    {
        private int Id;
        public static int Field;

        public NoStaticClass(int id)
        {
            Id = id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field={1}", Id, Field);
        }
    }
}
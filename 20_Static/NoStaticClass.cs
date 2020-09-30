using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Static
{
    class NoStaticClass
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

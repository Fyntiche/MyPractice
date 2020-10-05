using System;

namespace _20_Static
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NoStaticClass noStatic = new NoStaticClass(3);
            NoStaticClass.Field = 5;
            noStatic.Method();
            Console.ReadKey();
        }
    }
}
using System;

namespace _08_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(1, 2);

            Console.WriteLine(derivedClass.baseNumber);
            Console.WriteLine(derivedClass.derivedNumber);

            Console.ReadKey();
        }
    }
}

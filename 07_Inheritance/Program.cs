using System;

namespace _07_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine(derivedClass.publicField);
            derivedClass.Show();
            Console.ReadLine();
        }
    }
}

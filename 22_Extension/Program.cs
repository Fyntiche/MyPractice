using System;

namespace _22_Extension
{
    internal static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }

    internal class Person
    {
        public int Age = 10;
    }

    internal static class ExtensionClassPerson
    {
        public static void ExtensionPerson(this Person person)
        {
            Console.WriteLine(person.Age);
        }

        public static void ExtensionPerson2(this Person person, string value)
        {
            Console.WriteLine(person.Age + value);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = "test";

            text.ExtensionMethod();

            ExtensionClass.ExtensionMethod(text);

            Person person = new Person();
            person.ExtensionPerson();
            person.ExtensionPerson2(" test");

            Console.ReadKey();
        }
    }
}
using _51_UserCollection.UserCollection;
using System;
using System.Collections;

namespace _51_UserCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UserCollection.UserCollection userCollection = new UserCollection.UserCollection();
            foreach (Element item in userCollection)
            {
                Console.WriteLine(item.Name + " " + item.Field1 + " " + item.Field2);
            }
            Console.WriteLine(new string('_', 50));

            IEnumerable enumerable = userCollection;

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine(element.Name + " " + element.Field1 + " " + element.Field2);
            }
            enumerator.Reset();
            Console.ReadLine();
        }
    }
}
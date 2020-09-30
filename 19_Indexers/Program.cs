using System;

namespace _19_Indexers
{
    class MyClass
    {
        private string[] my = { "1", "2", "3", "4", "5" };

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < my.Length)
                {
                    return my[index];
                }
                else 
                    return "Попытка обращения за пределы массива";
               
            }
            set
            {
                if (index >= 0 && index < my.Length)
                {
                    my[index] = value;
                }
                else
                    Console.WriteLine("Попытка обращения за пределы массива");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass[4]);
            myClass[2] = "4";
            Console.WriteLine(myClass[2]);
            Console.ReadLine();
        }
    }
}

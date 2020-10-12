using System;

namespace _6._1
{
    internal class Program
    {
        public struct Notebook
        {
            public string Model;

            public string Made;

            public double Price;

            public Notebook(string model, string made, double price)
            {
                Model = model;
                Made = made;
                Price = price;
            }
        }

        private static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Phone", "Apple", 12);
            Console.WriteLine(notebook.Made + " " + notebook.Model + " " + notebook.Price);
            Console.ReadLine();
        }
    }
}
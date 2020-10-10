using System;

namespace _3._2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("DOCHandler Chenge");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler Create");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler Open");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler Save");
        }
    }
}
using System;

namespace _3._2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("TXTHandler Chenge");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler Create");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler Open");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler Save");
        }
    }
}
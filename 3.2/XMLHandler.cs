using System;

namespace _3._2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("XMLHandler Chenge");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler Create");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHandler Open");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler Save");
        }
    }
}
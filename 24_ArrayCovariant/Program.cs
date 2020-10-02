using System;

namespace _24_ArrayCovariant
{

    interface IVoice
    {
        void Voice();
    }

    public struct Dog : IVoice
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

           // IVoice[] animal = dogs; Error
        }
    }
}

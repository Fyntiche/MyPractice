using System;

namespace _3._3
{
    internal class Player : IPlayable, IRecodable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("pause record music");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("record record music");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("stop record music");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("pause music");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("pause music");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("stop music");
        }
    }
}
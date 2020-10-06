using System;

namespace _43_Events
{
    public delegate void EventDelegate();

    internal class Keyboard
    {
        private EventDelegate aPressKey;
        private EventDelegate bPressKey;

        public event EventDelegate APressKey
        {
            add
            {
                aPressKey += value;
            }
            remove
            {
                aPressKey -= value;
            }
        }

        public event EventDelegate BPressKey
        {
            add
            {
                bPressKey += value;
            }
            remove
            {
                bPressKey -= value;
            }
        }

        public void APressKeyInvoke()
        {
            if (aPressKey != null)
            {
                aPressKey.Invoke();
            }
        }

        public void BPressKeyInvoke()
        {
            if (bPressKey != null)
            {
                bPressKey.Invoke();
            }
        }

        public void Run()
        {
            while (true)
            {
                string key = Console.ReadLine();
                switch (key)
                {
                    case "a":
                    case "A":
                        APressKeyInvoke();
                        continue;
                    case "b":
                    case "B":
                        BPressKeyInvoke();
                        continue;
                    case "exit":
                        break;
                }
            }
        }
    }

    internal class Program
    {
        private static void DrawAImage()
        {
            Console.WriteLine("a");
        }

        private static void DrawBImage()
        {
            Console.WriteLine("b");
        }

        private static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            keyboard.APressKey += DrawAImage;
            keyboard.BPressKey += DrawBImage;
            keyboard.Run();
        }
    }
}
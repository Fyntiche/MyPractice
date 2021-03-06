﻿using System;

namespace _25_Enums
{
    internal enum EnumType : byte
    {
        one,
        two,
        three
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(EnumType.one);
            Console.WriteLine((byte)EnumType.one);
            for (EnumType number = EnumType.one; number < EnumType.three; number++)
            {
                Console.WriteLine((byte)number);
            }
            Type @enum = EnumType.one.GetType();
            Console.WriteLine(@enum.Name);
            Console.WriteLine(@enum.FullName);
            Console.WriteLine(Enum.GetUnderlyingType(@enum));
            Console.Read();
        }
    }
}
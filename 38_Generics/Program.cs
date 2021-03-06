﻿using System;

namespace _38_Generics
{
    public interface IFont
    {
        string Name();

        int FontSize();
    }

    // Обобщенный интерфейс, имеющий ковариантность
    // по отношению к своему обобщенному типу
    public interface IFontColor<out T> : IFont
    {
        T BaseAndColorInfoFont();
    }

    // Обобщенный интерфейс обеспечивающий контравариантность
    public interface IFontInfo<in T> : IFont
    {
        void MyFontInfo(T obj);
    }

    internal class Font : IFontInfo<Font>
    {
        private string name;
        private int fontsize;

        public Font(string name, int fontsize)
        {
            this.name = name;
            this.fontsize = fontsize;
        }

        // Реализуем интерфейс IFontInfo
        public string Name()
        {
            return name;
        }

        public int FontSize()
        {
            return fontsize;
        }

        public virtual void MyFontInfo(Font obj)
        {
            Console.WriteLine(@"Информация о шрифте
                __________________
                Название:{0}
                Размер: {1}px", obj.Name(), obj.FontSize());
        }
    }

    internal class FontColor : Font, IFontColor<FontColor>
    {
        private string color;

        public FontColor(string name, int fontsize, string color)
            : base(name, fontsize)
        {
            this.color = color;
        }

        public FontColor BaseAndColorInfoFont()
        {
            FontColor fontBase = new FontColor("Arial", 20, "Red");
            return fontBase;
        }

        public override void MyFontInfo(Font obj)
        {
            base.MyFontInfo(obj);
            Console.WriteLine("Цвет: " + color);
        }
    }

    internal class Program
    {
        private static void Main()
        {
            // Создадим экземпляр класса Font, ссылающийся
            // на класс FontColor благодаря ковариантности
            Font ob = new FontColor("Times New Roman", 22, "Black");
        }
    }
}
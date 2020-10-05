using System;

namespace _37_Generics
{
    public abstract class Shape { };

    public class Circle : Shape { }

    public interface IFigure<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IFigure<T>
    {
        public T Figure { get; set; }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Circle circle = new Circle();
            IFigure<Circle> Figure = new Container<Circle>(circle);
            Console.WriteLine(Figure.Figure.ToString());
            Console.ReadLine();
        }
    }
}
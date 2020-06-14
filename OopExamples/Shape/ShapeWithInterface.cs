using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ShapeInterface
{
    public interface IShape //интерфейс как отношение "является"
    {
        double Area();

        void Draw();

        void Fill();
    }

    public class Circle: IShape
    {
        private double r;
        private readonly double pi = 3.14;

        public Circle(double r)
        {
            this.r = r;
        }
        public double Area() {
            return pi * r * r;
        }
        
        public void Draw()
        {
            Console.WriteLine($"Рисует круг радиусом {r}");
        }

        public void Fill()
        {
            Console.WriteLine("Заливка фигуры цветом - прямоугольник");
        }
    }

    public class Rectangle : IShape
    {
        
        private double a, b;
        
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Area()
        {
            return a*b;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисует прямоугольник {a} на {b}");
        }

        public void Fill()
        {
            Console.WriteLine("Заливка фигуры цветом - прямоугольник");
        }
    }

    public class Square: Rectangle
    {
        public Square(double a) : base(a, a) 
        { 
        }
    }

    public static class TestShapeExample
    {
        public static void Area()
        {
            List<IShape> list = new List<IShape>();
            list.Add(new Circle(15));
            list.Add(new Circle(25));
            list.Add(new Rectangle(10, 15));
            list.Add(new Square(10));

            foreach (var shape in list)
            {
                if(shape is Circle)
                {
                    Console.Write("Круг S =");
                }
                else if(shape is Rectangle)
                {
                    Console.Write("Прямоугольник S = ");
                }
                else if (shape is Square) //нюанс с отношением "является"
                {
                    Console.Write("Квадрат S = ");
                }

                Console.WriteLine(shape.Area());
            }
        }

        public static void Draw()
        {
            List<IShape> list = new List<IShape>();
            list.Add(new Circle(15));
            list.Add(new Circle(25));
            list.Add(new Rectangle(10, 15));
            list.Add(new Square(10));

            foreach (var shape in list)
            {
                shape.Draw();
                shape.Fill();
            }
        }
    }
   
}

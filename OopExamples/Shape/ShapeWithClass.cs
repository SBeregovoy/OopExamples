using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ShapeClass
{
    public abstract class Shape
    {
        public abstract double Area();

        public abstract void Draw();

        public virtual void Fill()
        {
            Console.WriteLine("Заливка фигуры цветом");
        }
    }

    public class Circle: Shape
    {
        private double r;
        private readonly double pi = 3.14;

        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area() {
            return pi * r * r;
        }
        
        public override void Draw()
        {
            Console.WriteLine($"Рисует круг радиусом {r}");
        }
    }

    public class Rectangle : Shape {
        
        private double a, b;
        
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return a*b;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисует прямоугольник {a} на {b}");
        }
    }

    public class Square: Rectangle
    {
        public Square(double a) : base(a, a) 
        { 
        }

        public override void Fill()
        {
            Console.WriteLine("Заливка квадрата цветом");
        }
    }

    public static class TestShapeExample
    {
        public static void Area()
        {
            List<Shape> list = new List<Shape>();
            list.Add(new Circle(15));
            list.Add(new Circle(25));
            list.Add(new Rectangle(10, 15));
            list.Add(new Square(10));

            foreach (var shape in list)
            {
                if (shape is Circle)
                {
                    Console.Write("Круг S =");
                }
                else if (shape is Square) //нюанс с отношением "является"
                {
                    Console.Write("Квадрат S = ");
                }
                else if (shape is Rectangle)
                {
                    Console.Write("Прямоугольник S = ");
                }

                Console.WriteLine(shape.Area());
            }
        }

        public static void Draw()
        {
            List<Shape> list = new List<Shape>();
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
